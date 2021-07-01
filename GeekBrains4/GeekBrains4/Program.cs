using System;

namespace ex1
{
    class Program
    {

        /*1) Написать метод GetFullName(string firstName, string lastName, string patronymic),
            принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с
            ФИО.Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.*/


        static string GetFullName(string firstName, string lastName, string patronymic)
        {

            string result  = $"{firstName}\t{lastName}  \t{patronymic}";

            return result;
        }

        static void Screen(string result)
        {
            Console.WriteLine(result);
        }


        static void Main(string[] args)
        {
            Screen(GetFullName("Ivan", "Ivanov", "Ivanovich")); 
            Screen(GetFullName("Cain", "Cainov", "Cainitovich"));
            Screen(GetFullName("Georgy", "Makarov", "Vladimirovich"));
            Screen(GetFullName("Ivan", "Poddubny", "Maximovich"));
        }


        
    }
}

