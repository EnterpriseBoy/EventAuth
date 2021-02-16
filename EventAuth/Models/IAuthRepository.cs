namespace EventAuth.Models
{
    public interface IAuthRepository
    {
        string Login(string Email, string Password);
        string Register(string Email, string Password);
        User ConfirmEmail(string Email, string Password);
        string Delete(string Email, string Password);
        string ResetPassword(string Email, string Password);
        string ResendEmail(string Email, string Password);
    }
}
