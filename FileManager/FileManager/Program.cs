using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class Program
    {

        static void ManagerMenu()
        {
            while (true)
            {
                string a = "";
                switch (a)
                {
                    case "!view" : View();break;
                    case "!delf" :DelFile();break;
                    case "!cref" : CreateFile();break;
                    default:Console.WriteLine("mistake comand");break;
                }
            }

        }

        private static void CreateFile()
        {
            throw new NotImplementedException();
        }

        private static void DelFile()
        {
            throw new NotImplementedException();
        }

        private static void View()
        {
            
        }

        static void Main(string[] args)
        {

            

        }
    }
}
