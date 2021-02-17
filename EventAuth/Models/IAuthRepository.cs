using System;

namespace EventAuth.Models
{
    public interface IAuthRepository
    {
        string Login(string Email, string Password);
        string Register(string Email, string Password);
        string ConfirmAccount(Guid AccountId);
        string Delete(string Email, string Password);
        string ResetPassword(string Email, string Password);
        string ResendEmail(string Email, string Password);
    }
}
