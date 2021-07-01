using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        /*3) Написать метод по определению времени года.
         * 
        На вход подаётся число – порядковый номер месяца.
        На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
        Написать метод, принимающий на вход значение из этого перечисления
        и возвращающий название времени года(зима, весна, лето, осень). 
        Используя эти методы, ввести с клавиатуры номер месяца и вывести 
        название времени года.Если введено некорректное число, вывести в 
        консоль текст «Ошибка: введите число от 1 до 12».*/

        enum Seasons
        {
            winter = 1,
            spring,
            summer,
            autumn

        }


        static Seasons SeasMonth()
        {
            int number;

            while (true)
            {
                Console.WriteLine("Введите номер месяца");
                bool success = Int32.TryParse(Console.ReadLine(), out number);

                if (number > 12 || number < 1 || !success)
                {
                    Console.WriteLine("Введите номер от 1 до 12 включительно");
                    continue;
                }
                else
                {
                    break;
                }
            }

            if(number <= 2 || number == 12 )
            {
                return Seasons.winter;
            }
            if(number >= 3 && number < 6 )
            {
                return Seasons.spring;
            }
            if(number >= 6 && number < 9)
            {
                return Seasons.summer;
            }
            if(number >=9 && number != 12)
            {
                return Seasons.autumn;
            }

            return 0;
        }

        static string TranslateSeason(Seasons number)
        {
            string result = "";


            switch (number)
            {
                case Seasons.winter: 
                    result = "Зима";
                    break;
                case Seasons.spring:
                    result = "Весна";
                    break;
                case Seasons.summer:
                    result = "Лето";
                    break;
                case Seasons.autumn:
                    result = "Осень";
                    break;
                default:
                    break;
            }

            return result;
        }


        static void Main(string[] args)
        {
            string result = TranslateSeason(SeasMonth());
            Console.WriteLine("Это " + result);
        }
    }
}
