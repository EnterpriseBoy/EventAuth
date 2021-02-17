
using System.Security.Cryptography;

namespace EventAuth.Helpers
{
    public class Hasher
    {
        public static string Hash(string password)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                var ba = System.Text.Encoding.UTF8.GetBytes(password);
                var hashBa = md5.ComputeHash(ba);
                var sb = new System.Text.StringBuilder();
                foreach(var x in hashBa)
                {
                    sb.Append(x.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public static bool Verify(string password,string hash)
        {
            return password == hash;
        }

    }
}
