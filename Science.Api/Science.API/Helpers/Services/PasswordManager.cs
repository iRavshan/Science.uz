using Science.API.Helpers.IServices;
using System.Security.Cryptography;
using System.Text;

namespace Science.API.Helpers.Services
{
    public class PasswordManager : IPasswordManager
    {
        public byte[] CreatePasswordHash(string password)
        {
            using (HMACSHA512 hmac = new HMACSHA512())
            {
                return hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public byte[] CreatePasswordSalt(string password)
        {
            using (HMACSHA512 hmac = new HMACSHA512())
            {
                return hmac.Key;
            }
        }

        public bool VerifyPasswordHash(string password)
        {
            using (HMACSHA512 hmac = new HMACSHA512(CreatePasswordSalt(password)))
            {
                byte[] computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(CreatePasswordHash(password));
            }
        }
    }
}
