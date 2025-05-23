using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Resume_V2.Application.Convertors;
using Resume_V2.Application.DTOs;
using Resume_V2.Application.Generator;
using Resume_V2.Application.Security;
using Resume_V2.Application.Senders.Interface;
using Resume_V2.Application.Services.Interfaces;
using Resume_V2.Application.StaticTools;
using Resume_V2.Domain.Models;
using Resume_V2.Infra.Data.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Services.Impelementations
{
    public class UserService : IUser
    {
        #region Constructor
        private readonly AppDbContext _context;
        private readonly IEmailService _emailService;
        private readonly IViewRenderService _viewRender;
        public UserService(AppDbContext context ,IEmailService emailService, IViewRenderService viewRender)
        {
            _context = context;
            _emailService = emailService;
            _viewRender = viewRender;
        }
        #endregion
        #region Login
        public async Task<LoginResult> CheckUserForLogin(LoginViewModel loginViewModel)
        {
            var user = await GetUserByEmail(loginViewModel.Email.Trim().ToLower().SanitizeText());
            if (user == null)
            {
                return LoginResult.UserNotFound;
            }

            var hashPassword = PasswordHelper.HashPassword(loginViewModel.Password.SanitizeText());
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

        public Task<User> GetUserByEmail(string email)
        {
            var user = _context.Users.FirstOrDefaultAsync(u => u.Email == email);

            return user;
        }
        #endregion
        #region Email Activation
        public async Task<User> GetUserByActivationCode(string activationCode)
        {
            return await _context.Users.FirstOrDefaultAsync(e => e.EmailActivationCode.Equals(activationCode));
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
            user.EmailActivationCode = NameGenerator.GenerateUniqCode();
            _context.Update(user);
            await _context.SaveChangesAsync();
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

            string bodyEmail = _viewRender.RenderToStringAsync("_ForgotPassword", user);
            await _emailService.SendEmail(user.Email, "بازیابی حساب کاربری", bodyEmail);

            return ForgotPasswordResualt.Success;


        }
		#endregion
		#region Reset Password

		public async Task<ResetPasswordResult> ResetPassword(ResetPasswordViewModel reset)
		{
			var user = await GetUserByActivationCode(reset.EmailActivationCode.SanitizeText());

			if (user == null || user.IsDelete)
			{
				return ResetPasswordResult.UserNotFound;
			}
			var password = PasswordHelper.HashPassword(reset.Password.SanitizeText());

			user.Password = password;
			user.IsEmailConfirmed = true;
			user.EmailActivationCode = NameGenerator.GenerateUniqCode();

			_context.Update(user);
			await _context.SaveChangesAsync();

			return ResetPasswordResult.Success;
		}

		#endregion
	}
}
