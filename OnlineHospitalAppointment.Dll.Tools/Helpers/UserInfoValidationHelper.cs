using OnlineHospitalAppointment.Dll.Tools.Enums;
using System.Text.RegularExpressions;

namespace OnlineHospitalAppointment.Dll.Tools.Helpers
{
    public static class UserInfoValidationHelper
    {
        /// <summary>
        /// بررسی صحت نام کاربری کاربر
        /// </summary>
        /// <param name="userName">نام کاربری</param>
        /// <returns></returns>
        public static (bool isValid, string errorMessage) UserNameValidation(string userName)
        {
            bool isValid = true;
            string errorMessage = string.Empty;
            int userNameLength = userName.Length;

            if (userNameLength < 4 || userNameLength > 50)
            {
                isValid = false;
                errorMessage = "username must between 4 to 50 char";
            }

            if (!Regex.IsMatch(userName, "^[a-zA-Z0-9_]+$"))
            {
                isValid = false;
                errorMessage = "username must contain a-z , A-Z , 0-9 , _";
            }

            return (isValid, errorMessage);
        }

        /// <summary>
        /// بررسی صحت رمز عبور کاربر
        /// </summary>
        /// <param name="password">رمز عبور</param>
        /// <returns></returns>
        public static (bool isValid, string errorMessage) PasswordValidation(string password)
        {
            bool isValid = password.Length >= 8;
            string errorMessage = isValid ? string.Empty : "passwod must bigger than 8 char";

            return (isValid, errorMessage);
        }

        /// <summary>
        /// بررسی صحت نام کاربر
        /// </summary>
        /// <param name="name">نام کاربر</param>
        /// <returns></returns>
        public static (bool isValid, string errorMessage) NameValidation(string name)
        {
            bool isValid = name.All(char.IsLetter) && (name.Length >= 3 && name.Length < 50);
            string errorMessage = "Enter Currect Name! Name between 3 to 50 digit";

            return (isValid, errorMessage);
        }

        /// <summary>
        /// بررسی صحت نام خانوادگی کاربر
        /// </summary>
        /// <param name="lastName">مم خانوادگی</param>
        /// <returns></returns>
        public static (bool isValid, string errorMessage) LastNameValidation(string lastName)
        {
            bool isValid = lastName.All(char.IsLetter) && (lastName.Length >= 4 && lastName.Length < 50);
            string errorMessage = "Enter Currect LastName! LastName between 3 to 50 digit";

            return (isValid, errorMessage);
        }

        /// <summary>
        /// بررسی صحت شماره بیمه کاربر
        /// </summary>
        /// <param name="insurance">شماره بیمه</param>
        /// <returns></returns>
        public static bool InsuranceNumberValidation(string insurance)
        {
            return insurance.All(char.IsNumber) && (insurance.Length == 8 || insurance.Length == 10) ||
                insurance == string.Empty;
        }

        /// <summary>
        /// بررسی صحت کد ملی کاربر
        /// </summary>
        /// <param name="nationalCode">کد ملی</param>
        /// <returns></returns>
        public static (bool isValid, string errorMessage) NationalCodeValidation(string nationalCode)
        {
            string errorMessage = "Enter Currect National Code!";

            if (nationalCode.Length != 10)
                return (false, errorMessage);

            string[] allDigitEqual = new[] { "0000000000", "1111111111", "2222222222",
                    "3333333333", "4444444444", "5555555555", "6666666666", "7777777777", "8888888888", "9999999999" };

            if (allDigitEqual.Contains(nationalCode))
                return (false, errorMessage);

            char[] charArray = nationalCode.ToCharArray();
            int num0 = Convert.ToInt32(charArray[0].ToString()) * 10;
            int num2 = Convert.ToInt32(charArray[1].ToString()) * 9;
            int num3 = Convert.ToInt32(charArray[2].ToString()) * 8;
            int num4 = Convert.ToInt32(charArray[3].ToString()) * 7;
            int num5 = Convert.ToInt32(charArray[4].ToString()) * 6;
            int num6 = Convert.ToInt32(charArray[5].ToString()) * 5;
            int num7 = Convert.ToInt32(charArray[6].ToString()) * 4;
            int num8 = Convert.ToInt32(charArray[7].ToString()) * 3;
            int num9 = Convert.ToInt32(charArray[8].ToString()) * 2;
            int num10 = Convert.ToInt32(charArray[9].ToString());

            int numbericValue = num0 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9;
            int mode = numbericValue % 11;

            bool isValid = mode < 2 && num10 == mode || mode >= 2 && 11 - mode == num10;

            return (isValid, errorMessage);
        }

        /// <summary>
        /// بررسی صحت شماره تلفن کاربر
        /// </summary>
        /// <param name="phoneNumber">شماره تلفن</param>
        /// <returns></returns>
        public static (bool isValid, string errorMessage) PhoneNumberValidation(string phoneNumber)
        {
            string errorMessage = "Enter Currect Mobile Phone Number!";

            if (!TryGetMobilePrefix(phoneNumber, out short prefix))
                return (false, errorMessage);

            bool isValid = OperatorsAndPreixes.Values
                .SelectMany(x => x)
                .Any(x => x == prefix);

            return (isValid, errorMessage);
        }

        private static bool TryGetMobilePrefix(string phoneNumber, out short prefix)
        {
            prefix = 0;

            if (phoneNumber.Length != 11)
                return false;

            prefix = short.Parse(phoneNumber[1..4]);

            return true;
        }

        private static Dictionary<OperatorId, short[]> OperatorsAndPreixes => new()
        {
            { OperatorId.MCI, new short[] { 910, 911, 912, 913, 914, 915, 916, 917, 918, 919, 990, 991, 992, 993, 994, 995, 996, 997, 998, 999 } },
            { OperatorId.MTN, new short[] { 930, 931, 933, 934, 935, 936, 937, 938, 939, 900, 901, 902, 903, 904, 905, 941 } },
            { OperatorId.RighTel, new short[] { 920, 921, 922, 923 } },
            { OperatorId.Taliya, new short[] { 932 } }
        };
    }
}