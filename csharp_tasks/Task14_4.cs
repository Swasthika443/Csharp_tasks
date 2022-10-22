using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csharp_tasks
{
    internal class mobile
    {
        public static void Main()

        {

            number();

        }

        public static void number()

        {

            Console.WriteLine("Mobile number validation");

            Console.WriteLine("Enter mobile number which starts with 6,7,8,9");

            Console.WriteLine("Enter the 10 digit mobile number");

            var number = Console.ReadLine();

            var validate_number = Regex.IsMatch(number, @"^[987]\d{9}$");

            Console.WriteLine(validate_number);



        }
    }
}
