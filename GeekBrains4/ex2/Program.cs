using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{


    /*2) Написать программу, принимающую на вход строку — набор чисел,
        разделенных пробелом, и возвращающую число — сумму всех чисел
        в строке.Ввести данные с клавиатуры и вывести результат на экран.*/


    class Program
    {

        static double StringToNumber(string numbers)
        {
            double sum = 0;
            string[] arrayString = numbers.Split();

            for(int i = 0;i < arrayString.Length; i++)
            {
                sum += Double.Parse(arrayString[i]);
            }

            return sum;
        }

        static void Main(string[] args)
        {

            double sum = StringToNumber("1,2 3,8 5,0 4,1 5,9");
            Console.WriteLine(sum);
        }
    }
}
