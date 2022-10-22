using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace TE_CSharp

{

    internal class exception

    {

        static void Main(String[] args)

        {

            int Num1, Num2, Result;

            try

            {

                Console.WriteLine("Enter First Number");

                Num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Second Number");

                Num2 = int.Parse(Console.ReadLine());

                Result = Num1 / Num2;

                Console.WriteLine($"Result:{Result}");

            }

            catch (DivideByZeroException DBZE)

            {

                Console.WriteLine("Second number should not be zero");

            }

            catch (FormatException FE)

            {

                Console.WriteLine("Enter only integer numbers");

            }

            Console.ReadKey();

        }

    }

}