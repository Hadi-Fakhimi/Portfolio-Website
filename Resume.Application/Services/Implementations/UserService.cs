using Microsoft.EntityFrameworkCore;
using Resume.Application.Generator;
using Resume.Application.Security;
using Resume.Application.Services.Interfaces;
using Resume.Application.StaticTools;
using Resume.Domain.ViewModels.Account;
using Resume.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User = Resume.Domain.Models.User;

namespace Resume.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        #region Constructor
        private readonly AppDbContext _dbContext;
        private readonly IEmailService _emailService;
        public UserService(AppDbContext dbContext, IEmailService emailService)
        {
            _dbContext = dbContext;
            _emailService = emailService;

        }

        #endregion
        public async Task CreateUser(User user)
        {
            await _dbContext.AddAsync(user);
        }
        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }
        public async Task<bool> IsExistsUserByEmail(string email)
        {
            return await _dbContext.Users.AnyAsync(s => s.Email == email);
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(s => s.Email.Equals(email));
        }

        #region UserAdmin

        public async Task<User> GetUserById(long id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id.Equals(id));
        }

        public async Task<List<UserViewModel>> UserForIndex()
        {
            List<UserViewModel> user = await _dbContext.Users.OrderBy(u => u.CreateDate).Select(u => new UserViewModel
            {
                Id = u.Id,
                CreateDate = u.CreateDate,
                Avatar = u.Avatar,
                Description = u.Description,
                Email = u.Email,
                EmailActivationCode = u.EmailActivationCode,
                FirstName = u.FirstName,
                IsAdmin = u.IsAdmin,
                LastName = u.LastName,
                IsDelete = u.IsDelete,
                IsEmailConfirmed = u.IsEmailConfirmed,
                Password = u.Password,
                PhoneNumber = u.PhoneNumber

            }).ToListAsync();

            return user;

        }

        public async Task<CreateOrEditUserAdminViewModel> FillCreateOrEditUserAdminViewModel(long id)
        {
            if (id == 0)
            {
                return new CreateOrEditUserAdminViewModel() { Id = 0 };
            }
            User user = await GetUserById(id);

            if (user == null)
            {
                return new CreateOrEditUserAdminViewModel() { Id = 0 };

            }
            return new CreateOrEditUserAdminViewModel()
            {
                Id = user.Id,
                CreateDate = user.CreateDate,
                Avatar = user.Avatar,
                Description = user.Description,
                Email = user.Email,
                EmailActivationCode = user.EmailActivationCode,
                FirstName = user.FirstName,
                IsAdmin = user.IsAdmin,
                LastName = user.LastName,
                IsDelete = user.IsDelete,
                IsEmailConfirmed = user.IsEmailConfirmed,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber
            };
        }

        public async Task<bool> CreateOrEditUserAdmin(CreateOrEditUserAdminViewModel userAdmin)
        {
            if (userAdmin.Id == 0)
            {
                var newUserAdmin = new User()
                {
                    CreateDate = userAdmin.CreateDate,
                    Avatar = userAdmin.Avatar,
                    Description = userAdmin.Description,
                    Email = userAdmin.Email,
                    EmailActivationCode = CodeGenerator.GenerateUniqCode(),
                    FirstName = userAdmin.FirstName,
                    IsAdmin = userAdmin.IsAdmin,
                    LastName = userAdmin.LastName,
                    IsDelete = userAdmin.IsDelete,
                    IsEmailConfirmed = userAdmin.IsEmailConfirmed,
                    Password = PasswordHelper.EncodePasswordMd5(userAdmin.Password),
                    PhoneNumber = userAdmin.PhoneNumber
                };

                await _dbContext.Users.AddAsync(newUserAdmin);

                await _dbContext.SaveChangesAsync();


                #region Send Activation Email
                var body = @$"
                <div>برای فعالسازی حساب کاربری روی لینک زیر کلیک کنید</div>
                <a href = '{FilePaths.SiteAddress}/Activate-Email/{newUserAdmin.EmailActivationCode}'>فعالسازی حساب کاربری</a>
                ";

                await _emailService.SendEmail(userAdmin.Email, "فعالسازی حساب کاربری", body);

                #endregion

                return true;
            }

            var currentUserAdmin = await GetUserById(userAdmin.Id);
            if (currentUserAdmin == null)
            {
                return false;
            }
            currentUserAdmin.CreateDate = userAdmin.CreateDate;
            currentUserAdmin.Avatar = userAdmin.Avatar;
            currentUserAdmin.Description = userAdmin.Description;
            currentUserAdmin.Email = userAdmin.Email;
            currentUserAdmin.EmailActivationCode = userAdmin.EmailActivationCode;
            currentUserAdmin.FirstName = userAdmin.FirstName;
            currentUserAdmin.IsAdmin = userAdmin.IsAdmin;
            currentUserAdmin.LastName = userAdmin.LastName;
            currentUserAdmin.IsDelete = userAdmin.IsDelete;
            currentUserAdmin.IsEmailConfirmed = userAdmin.IsEmailConfirmed;
            currentUserAdmin.Password = PasswordHelper.EncodePasswordMd5(userAdmin.Password);
            currentUserAdmin.PhoneNumber = userAdmin.PhoneNumber;

            _dbContext.Users.Update(currentUserAdmin);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteUserAdmin(long id)
        {
            var user = await GetUserById(id);
            if (user == null) { return false; }

            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();

            return true;
        }


        #endregion

        #region Login
        public async Task<LoginResult> CheckUserForLogin(LoginViewModel login)
        {
            var user = await GetUserByEmail(login.Email.Trim().ToLower().SanitizeText());

            if (user == null)
            {
                return LoginResult.UserNotFound;
            }
            var hashPassword = PasswordHelper.EncodePasswordMd5(login.Password.SanitizeText());

            if (hashPassword != user.Password)
            {
                return LoginResult.UserNotFound;
            }

            if (user.IsDelete)
            {
                return LoginResult.UserNotFound;
            }
            if (!user.IsEmailConfirmed)
            {
                return LoginResult.EmailNotActivated;
            }

            return LoginResult.Success;
        }

        #endregion


        #region Email Activation
        public async Task<User> GetUserByActivationCode(string activationCode)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(e => e.EmailActivationCode.Equals(activationCode));
        }
        public async Task<bool> ActivateUserEmail(string activationCode)
        {
            var user = await GetUserByActivationCode(activationCode);
            if (user == null)
            {
                return false;
            }
            if (user.IsDelete)
            {
                return false;
            }
            user.IsEmailConfirmed = true;
            user.EmailActivationCode = CodeGenerator.GenerateUniqCode();
            _dbContext.Update(user);
            await _dbContext.SaveChangesAsync();
            return true;

        }

        #endregion

        #region ForgotPassword

        public async Task<ForgotPasswordResualt> ForgotPassword(ForgotPasswordViewModel forgot)
        {
            var email = forgot.Email.SanitizeText().Trim().ToLower();

            var user = await GetUserByEmail(email);

            if (user == null || user.IsDelete)
            {
                return ForgotPasswordResualt.UserNotFound;
            }

            var body = $@"<div>برای فراموشی روی لینک زیر کلیک کنید</div>
            <a href = '{FilePaths.SiteAddress}/Reset-Password/{user.EmailActivationCode}'>فراموشی کلمه عبور</a>";

            await _emailService.SendEmail(user.Email, "فراموشی کلمه عبور", body);

            return ForgotPasswordResualt.Success;


        }




        #endregion

        #region Reset Password

        public async Task<ResetPasswordResult> ResetPassword(ResetPasswordViewModel reset)
        {
            var user = await GetUserByActivationCode(reset.EmailActivationCode.SanitizeText());

            if(user == null || user.IsDelete)
            {
                return ResetPasswordResult.UserNotFound;
            }
            var password = PasswordHelper.EncodePasswordMd5(reset.Password.SanitizeText());

            user.Password = password;
            user.IsEmailConfirmed = true;
            user.EmailActivationCode = CodeGenerator.GenerateUniqCode();

            _dbContext.Update(user);
            await _dbContext.SaveChangesAsync();

            return ResetPasswordResult.Success;
        }

        #endregion
    }
}
