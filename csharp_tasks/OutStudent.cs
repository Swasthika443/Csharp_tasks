using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tasks
{
    internal class OutStudent
    {
        public static void Main()
        {
            int sid;
            string sname;
            string sdep;
            StudentDetails(out sid, out sname, out sdep);
            Console.WriteLine("student ID is:" +sid  );
            Console.WriteLine("student name :" + sname);
            Console.WriteLine("student department :" + sdep);
        }
        public static void StudentDetails(out int sid, out string sname, out string sdep )
        {
            Console.WriteLine("Enter Student details below(id,name,department):");
            sid = Convert.ToInt32(Console.ReadLine());
            sname = Console.ReadLine();

            sdep = Console.ReadLine();
            Console.WriteLine("-------------------");


        }
    }
}
