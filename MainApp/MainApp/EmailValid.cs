using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLib;
namespace MainApp
{
    public class EmailValid
    {

        public static void EmailValidation(string email)
        {
            if (SharedValidation.IsEmailValid(email))
            {
                Console.WriteLine("Valid email.");
            }
            else
            {
                Console.WriteLine("Invalid email.");
            }
        }
    }
}
