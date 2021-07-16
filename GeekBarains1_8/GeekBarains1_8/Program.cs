using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GeekBrains1_8
{
    class Program
    {
        static void Main(string[] args)
        {

            if (string.IsNullOrEmpty(GeekBarains1_8.Properties.Settings.Default.NameUser))
            {

                Console.WriteLine("Введите имя пользователя:");
                GeekBarains1_8.Properties.Settings.Default.NameUser = Console.ReadLine();
                GeekBarains1_8.Properties.Settings.Default.Save();
            }

            if (string.IsNullOrEmpty(GeekBarains1_8.Properties.Settings.Default.AgeUser))
            {

                Console.WriteLine("Введите возраст пользователя:");
                GeekBarains1_8.Properties.Settings.Default.AgeUser = Console.ReadLine();
                GeekBarains1_8.Properties.Settings.Default.Save();
            }

            if (string.IsNullOrEmpty(GeekBarains1_8.Properties.Settings.Default.ProfessionUser))
            {

                Console.WriteLine("Введите имя пользователя:");
                GeekBarains1_8.Properties.Settings.Default.ProfessionUser = Console.ReadLine();
                GeekBarains1_8.Properties.Settings.Default.Save();
            }

            string greeting = GeekBarains1_8.Properties.Settings.Default.HelloUser;
            string userName = GeekBarains1_8.Properties.Settings.Default.NameUser;
            string userAge = GeekBarains1_8.Properties.Settings.Default.AgeUser;
            string userProf = GeekBarains1_8.Properties.Settings.Default.ProfessionUser;

            Console.WriteLine($"{greeting}, {userName}, в возрасте {userAge} и по профессии {userProf}!");
        }

        
    }
}
