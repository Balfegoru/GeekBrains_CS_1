using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        /*2. Написать программу «Телефонный справочник»:
        создать двумерный массив 5х2, хранящий список
        телефонных контактов: первый элемент хранит имя
        контакта, второй — номер телефона/email.*/

        static void Init(string[,] massive)
        {

            string[] names =
            {
                "Maria",
                "Egor",
                "Victor",
                "Pavel",
                "Jana",

            };

            string[] numbers =
            {
                "8(927)8971232",
                "8(800)0912847",
                "8(926)0000011",
                "8(808)9900811",
                "8(777)0077700",

            };

            for (int i = 0; i < massive.GetLength(0); i++)
            {
                
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    massive[i, 0] = names[i];
                    massive[i, 1] = numbers[i];

                }
            }

        }


        static void Vision(string[,] massive)
        {
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                Console.Write($"Имя: {massive[i, 0]}\tТелефон: {massive[i, 1]}");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            string[,] telenumber = new string[5, 2];

            Init(telenumber);

            Vision(telenumber); 


        }
    }
}
