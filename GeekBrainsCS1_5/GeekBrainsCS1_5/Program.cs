using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace GeekBrainsCS1_5
{
    class Program
    {

        // 1) Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
        static void Main(string[] args)
        {

            Console.WriteLine("Введите данные");
            string str = Console.ReadLine();
            string filename = "myData.txt";

            File.WriteAllText(filename, str);
            
        }
    }
}
