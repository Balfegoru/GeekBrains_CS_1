using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            while (true)
            {
                Console.WriteLine("Введите число");
                

                bool success = Int32.TryParse(Console.ReadLine(), out number);

                if(success)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите целочисленное значение");
                }

            }
            
            if(number%2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }


        }
    }
}
