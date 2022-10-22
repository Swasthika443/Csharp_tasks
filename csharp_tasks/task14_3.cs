using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace TE_CSharp

{

    public class Bns

    {

        protected int bonus;



    }

    public class Staff : Bns

    {

        protected int salary = 40000;

        public void GetBonus1()

        {

            bonus = 3 * salary;

            Console.WriteLine($"Staff salary:{salary} and Bonus={bonus}");

            Console.WriteLine("-----------------------------------------");

        }

    }

    public class NonStaff : Staff

    {

        protected int salary = 15000;

        public void GetBonus2()

        {

            bonus = 2 * salary;

            Console.WriteLine($"Staff salary:{salary} and Bonus={bonus}");

            Console.WriteLine("-----------------------------------------");

        }



    }



    internal class inher

    {

        class program

        {

            public static void Main()

            {

                Staff s = new Staff();

                s.GetBonus1();

                NonStaff n = new NonStaff();

                n.GetBonus2();

            }

        }

    }

}