using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        //3) Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.


        //Проверка значения
        static bool Check(int number) 
        {
            if(number >= 0 && number <= 255)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Запись и возврат имя файла куда была произведена запись
        static string Binary(byte[] number)
        {
            string filename = "binare.bin";
            
            File.WriteAllBytes(filename, number);

            return filename;
        }


        static void Byter(byte[] arrayByte)
        {
            int length = 0;

            while (length < arrayByte.Length)
            {

                Console.WriteLine("Введите значение от 0 до 255");
                string word = Console.ReadLine();
                if (Int32.TryParse(word, out int number) && Check(number))
                {
                    arrayByte.Append(Convert.ToByte(number));
                    length++;
                }
                else
                {
                    Console.WriteLine("Вы ввели неподходходящее значение");
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Сколько чисел вы хотите записать");
            int length = int.Parse(Console.ReadLine());
            byte[] arrayByte = new byte[length];
            Byter(arrayByte);

            string name = Binary(arrayByte);

            Console.WriteLine($"Запись была проведена в файл {name}");

        }

    }
}
