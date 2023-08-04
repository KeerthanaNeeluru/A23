using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLib;
namespace MainApp
{
    public class PhoneValid
    {
        
        public static void PhoneValidation(string phoneNumber)
        {
            if (SharedValidation.IsPhoneNumberValid(phoneNumber))
            {
                Console.WriteLine("Valid phone number.");
            }
            else
            {
                Console.WriteLine("Invalid phone number.");
            }
        }

    }
}
