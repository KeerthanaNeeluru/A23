using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib
{
    public class SharedValidation
    {
        public static bool IsEmailValid(string email)
        {

            return email.Contains("@");
        }

        public static bool IsPhoneNumberValid(string phoneNumber)
        {

            return !string.IsNullOrEmpty(phoneNumber) && phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }
    }
}
