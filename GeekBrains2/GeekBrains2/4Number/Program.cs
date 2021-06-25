using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Number
{
    class Program
    {
        static void Main(string[] args)
        {

            string total = "216.00";
            string name = "ГУП \"Волгофарм\"";
            string date = "19.01.1998";

            string startFinish = "=======================";
            string postStart = "-----------------------";

            Console.WriteLine(startFinish);
            Console.WriteLine($"=   {name}   =");
            Console.WriteLine(startFinish);
            Console.WriteLine($"Дата:      {date}");
            Console.WriteLine(postStart);
            Console.WriteLine(postStart);
            Console.WriteLine($"ИТОГ            ={total}");
            Console.WriteLine(startFinish);






        }
    }
}
