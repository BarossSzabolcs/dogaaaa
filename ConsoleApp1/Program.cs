using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmailValidator
    {
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            { 
                return false;
            }
            int atIndex = email.IndexOf("@");
            if (atIndex <= 0 || atIndex != email.LastIndexOf("@"))
            { 
                return false ;
            }
            string localPart = email.Substring(0, atIndex);
            string domainPart = email.Substring(atIndex + 1);
            if (string.IsNullOrEmpty(domainPart) || string.IsNullOrEmpty(localPart))
            { 
                return false;
            }
            int dotIndex = email.IndexOf(".");
            if (dotIndex <= 0)
            {
                return false;
            }
            

            return true;
        }

        static void Main(string[] args)
        {
            string email;
            ConsoleKey key;
            do
            {
                Console.Write("Add meg az e-mail címet: ");
                email = (Console.ReadLine());

                var email2 = new EmailValidator();

                Console.WriteLine($"{email2.IsValidEmail(email)}");
                Console.WriteLine("\nÚj e-mail megadása(ENTER)  |  Kilépés(ESC)\n");
                key = Console.ReadKey(true).Key;

            } while (key != ConsoleKey.Escape);
            Console.ReadKey();
        }
    }
}
