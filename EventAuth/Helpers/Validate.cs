using EventAuth.Exceptions;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations;

namespace EventAuth.Helpers
{
    public static class Validate
    {
        private const  int minLength = 8;

        
        public static void ValidateLogin(string Email,string Password)
        {

            if(Email.Length < minLength)
            {
                throw new ValidationEx("Email is to short");
            }

            if (!new EmailAddressAttribute().IsValid(Email))
            {
                throw new ValidationEx("Email not valid");
            }

            if (Password.Length < minLength)
            {
                throw new ValidationEx("Password is to short");
            }

        }
    }
}
