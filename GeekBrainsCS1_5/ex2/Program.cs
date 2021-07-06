using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        //2) Написать программу, которая при старте дописывает текущее время в файл «startup.txt».

        private static void TimeText()
        {
            string filename = "startup.txt";

            if (!File.Exists(filename))
            {
                File.WriteAllText(filename, "");
            }

            DateTime nowTime = DateTime.Now;
            File.AppendAllText(filename, nowTime.ToString());
            File.AppendAllText(filename, Environment.NewLine);
        }


        static void Main(string[] args)
        {
            TimeText();
        }

        
    }
}
