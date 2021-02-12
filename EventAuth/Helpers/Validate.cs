using EventAuth.Exceptions;

namespace EventAuth.Helpers
{
    public static class Validate
    {
        private const  int minLength = 8;

        
        public static void ValidateEmail(string Email)
        {

            if(Email.Length < minLength)
            {
                throw new ValidationException("Email is to short");
            }

        }


        public static void ValidatePassword(string Password)
        {

            if (Password.Length < minLength)
            {
                throw new ValidationException("Password is to short");
            }

        }
    }
}
