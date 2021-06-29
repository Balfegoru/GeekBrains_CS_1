using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{       
    //3. Написать программу, выводящую введённую пользователем строку
    //в обратном порядке(olleH вместо Hello).


    class Program
    {

        static string Cda(string line)
        {
            string result = "";
            
            for(int i = line.Length-1; i > -1; i--)
            {
                result += line[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string line = Console.ReadLine();

            line = Cda(line);
            
            Console.WriteLine($"\n{line}");
        }
    }
}
