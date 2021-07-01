using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {

        /*(4*) Написать программу, вычисляющую число Фибоначчи
        для заданного значения рекурсивным способом.*/



        //Метод для упрощения ввода с проверкой
        static int ResultFibonachi()
        {
            int userNumber;

            while (true)
            {
                Console.WriteLine("Введите порядковый номер");
                bool success = Int32.TryParse(Console.ReadLine(), out userNumber);

                if (success)
                {
                    //Использование метода
                    return Fibonachi(userNumber);

                }
                else
                {
                    Console.WriteLine("Введите целочисленное значение в качестве порядкового номера");
                    continue;
                }
            }
        }

        //Метод Фибоначи
        static int Fibonachi(int number)
        {
            
            //number == 1 || number == 2
            
            if(number < 0)
            {
                return number;
            }

            return  number + Fibonachi(number - 1) ;
        }
        static void Main(string[] args)
        {
            /*int result = ResultFibonachi();
            Console.WriteLine(result);*/

            //Пока не закончено

            Console.WriteLine(Fibonachi(1)); //0
            Console.WriteLine(Fibonachi(2)); //1
            Console.WriteLine(Fibonachi(3)); //1
            Console.WriteLine(Fibonachi(4)); //2
            Console.WriteLine(Fibonachi(5)); //3

            

        }
    }
}
