using System.Security.Cryptography;
using System.Text;

namespace OnlineHospitalAppointment.Dll.Tools
{
    public static class PasswordHelper
    {
        private const string hash = "asdfghjkl123";

        public static string HashPassword(string password)
        {
            string encryptPassword;
            byte[] data = Encoding.UTF8.GetBytes(password);
            using (MD5CryptoServiceProvider md5 = new())
            {
                byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDes = new()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    encryptPassword = Convert.ToBase64String(results);
                }
            }
            return encryptPassword;
        }
    }
}