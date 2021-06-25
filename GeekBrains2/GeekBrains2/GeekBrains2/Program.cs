using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains2
{
    class Program
    {
        //[Flags]
        enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите порядковый номер месяца");
            Month UserMonth = (Month)int.Parse(Console.ReadLine());
            Console.WriteLine($"Месяц с таким номером {UserMonth}");

        }
    }
}
