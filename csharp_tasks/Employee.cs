using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tasks
{
    internal class Employee
    {
        public static void Main()

        {

            Static();

        }

        public static void Static()

        {

            Console.WriteLine("Enter Employee details: ");

            Console.WriteLine("Enter Employee ID: ");

            int empID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");

            String empName = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary: ");

            int Salary = Convert.ToInt32(Console.ReadLine());

            Employee emp = new Employee();

            emp.Instance(empID, empName, Salary);

        }

        public void Instance(int empID, String empName, int Salary)

        {

            Console.WriteLine("Employee ID is: " + empID);

            Console.WriteLine("Employee Name is: " + empName);

            Console.WriteLine("Employee Salary is: " + Salary);



        }
    }
}
