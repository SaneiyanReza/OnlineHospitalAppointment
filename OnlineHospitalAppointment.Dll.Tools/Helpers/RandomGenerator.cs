using System.Security.Cryptography;
using System.Text;

namespace OnlineHospitalAppointment.Dll.Tools.Helpers
{
    public static class RandomGenerator
    {
        private static char[] chars =>
                "asdfghjkl132".ToCharArray();

        public static string GetUniqueCode(int size = 6)
        {
            byte[] data = new byte[size];
            using (RNGCryptoServiceProvider crypto = new())
            {
                crypto.GetBytes(data);
            }

            StringBuilder result = new(size);
            foreach (byte b in data)
            {
                result.Append(chars[b % chars.Length]);
            }
            return result.ToString();
        }
    }
}