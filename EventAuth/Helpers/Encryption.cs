using System.Security.Cryptography;
using System.Text;

namespace EventAuth.Helpers
{
    public static class ShaEncryption
    {
        public static string Encrypt(string input)
        {
            //Convert to a string array of bytes
            var data = Encoding.ASCII.GetBytes(input);

            //Encrypt array
            data = new SHA256Managed().ComputeHash(data);

            //Converts byte array to string
            var hash = Encoding.ASCII.GetString(data);

            return hash;
        }

    }
}
