
using System.Security.Cryptography;

namespace EventAuth.Helpers
{
    public class Hasher
    {
        public static string Hash(string password)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                var b = System.Text.Encoding.UTF8.GetBytes(password);
                b = md5.ComputeHash(b);
                var sb = new System.Text.StringBuilder();
                foreach(var x in b)
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
