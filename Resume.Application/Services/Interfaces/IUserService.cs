using Resume.Domain.Models;
using Resume.Domain.ViewModels.Account;
using Resume.Domain.ViewModels.CustomerFeedback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces
{
    public interface IUserService
    {

		Task<bool> IsExistsUserByEmail(string email);

		Task CreateUser(User user);
		Task Save();

        Task<User> GetUserByEmail(string email);

        #region UserAdmin
        Task<User> GetUserById(long id);
        Task<List<UserViewModel>> UserForIndex();
        Task<CreateOrEditUserAdminViewModel> FillCreateOrEditUserAdminViewModel(long id);
        Task<bool> CreateOrEditUserAdmin(CreateOrEditUserAdminViewModel userAdmin);
        Task<bool> DeleteUserAdmin(long id);


        #endregion


        #region Login

        Task<LoginResult> CheckUserForLogin(LoginViewModel login);


        #endregion

        #region Email Activation
        Task<User> GetUserByActivationCode(string activationCode);
        Task<bool> ActivateUserEmail(string activationCode);

        #endregion

        #region ForgotPassword

        Task<ForgotPasswordResualt> ForgotPassword(ForgotPasswordViewModel forgot);


        #endregion

        #region Reset Password

        Task<ResetPasswordResult> ResetPassword(ResetPasswordViewModel reset);

        #endregion
    }
}
