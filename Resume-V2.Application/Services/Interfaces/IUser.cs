using Resume_V2.Application.DTOs;
using Resume_V2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Services.Interfaces
{
    public interface IUser
    {
        Task<LoginResult> CheckUserForLogin(LoginViewModel loginViewModel);
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserByActivationCode(string activationCode);
        Task<bool> ActivateUserEmail(string activationCode);
        Task<ForgotPasswordResualt> ForgotPassword(ForgotPasswordViewModel forgot);
        Task<ResetPasswordResult> ResetPassword(ResetPasswordViewModel reset);

	}
}
