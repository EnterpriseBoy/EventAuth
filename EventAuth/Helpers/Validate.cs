using EventAuth.Exceptions;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations;

namespace EventAuth.Helpers
{
    public static class Validate
    {
        private const  int minLength = 8;

        
        public static void ValidateEmail(string Email)
        {

            if(Email.Length < minLength)
            {
                throw new ValidationEx("Email is to short");
            }

            if (!new EmailAddressAttribute().IsValid(Email))
            {
                throw new ValidationEx("Email not valid");
            }

        }


        public static void ValidatePassword(string Password)
        {
            if (Password.Length < minLength)
            {
                throw new ValidationEx("Password is to short");
            }

        }
    }
}
