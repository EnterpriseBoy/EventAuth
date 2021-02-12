using EventAuth.Context;
using EventAuth.Helpers;
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

        public void Login(string Email, string Password)
        {
            Validate.ValidateEmail(Email);
            Validate.ValidatePassword(Password);
            
            var user = _eventContext.Users.First(x => x.Email == Email);
        }

        public string Register(string Email, string Password)
        {
            throw new System.NotImplementedException();
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
