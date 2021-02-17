using EventAuth.Context;
using EventAuth.Helpers;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Linq;

namespace EventAuth.Models
{
    public class AuthRepository : IAuthRepository
    {
        private readonly EventAuthContext _eventContext;

        public AuthRepository(EventAuthContext context)
        {
            _eventContext = context;
        }
        public User ConfirmEmail(string Email, string Password)
        {
            throw new System.NotImplementedException();
        }

        public string Delete(string Email, string Password)
        {
            throw new System.NotImplementedException();
        }

        public string Login(string Email, string Password)
        {
            Validate.ValidateLogin(Email,Password);

            
            var user = _eventContext.Users.FirstOrDefault(x => x.Email == Email);

            if(user== null)
            {
                return "Login Failed";
            }
            //var hasher = new PasswordHasher();

            var passwordHash = Hasher.Hash(Password);

            if(Hasher.Verify(passwordHash,user.Password))
            {
                return JsonConvert.SerializeObject(user);
            }

            return "Login Failed";
        }

        public string Register(string Email, string Password)
        {
            Validate.ValidateLogin(Email, Password);

            if (_eventContext.Users.FirstOrDefault(x => x.Email == Email) != null)
                return "Registration Failed";

            var user = new User()
            {
                Password = Hasher.Hash(Password),
                Email = Email,
                RegistrationDate = DateTime.Now,
                Confirmed= false
            };

            _eventContext.Users.Add(user);

            _eventContext.SaveChanges();

            return "User Saved";
        }

        public string ResendEmail(string Email, string Password)
        {
            throw new System.NotImplementedException();
        }

        public string ResetPassword(string Email, string Password)
        {
            throw new System.NotImplementedException();
        }
    }
}
