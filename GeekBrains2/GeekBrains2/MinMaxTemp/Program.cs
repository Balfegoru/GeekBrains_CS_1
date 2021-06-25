using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную температуру");
            double temp = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите минимальную температуру");
            temp += double.Parse(Console.ReadLine());
            temp /= 2;

            Console.WriteLine($"Средняя температура за сутки {temp} градусов");
        }
    }
}
