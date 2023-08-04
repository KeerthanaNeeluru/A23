using SharedLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class Program
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
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("Select\n1.PhoneNumber Validation\t2.EmailValidation");
                int choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter PhoneNumber");
                        string ph=Console.ReadLine();
                       
                        PhoneValidation(ph);
                        break;
                    case 2:
                        Console.WriteLine("Enter Email ID");
                        string em=Console.ReadLine();
                        EmailValidation(em);
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
                Console.WriteLine("If you want to continue press y");
                ch = char.Parse(Console.ReadLine().ToLower());
            } while (ch == 'y');
        }
    }
}
