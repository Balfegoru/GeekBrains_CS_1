using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        //4) Сохранить дерево каталогов и файлов по заданному пути в
        //текстовый файл — с рекурсией и без.

        //Реализация без рекурсии


        private static string DirAndFilesToText(string[] dirs)
        {
            string filename = "DirAndFiles.txt";

            if (!File.Exists(filename))
            {
                File.WriteAllText(filename, "");
            }

            foreach(string dir in dirs)
            {
                File.AppendAllText(filename, dir);
                File.AppendAllText(filename, Environment.NewLine);
            }

            return filename;
        }

        static string[] RootToString(string rootPath)
        {
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            return files;
        }

        static void Main(string[] args)
        {

            string rootPath = @"C:\Windows\Media";

            string filename = DirAndFilesToText(RootToString(rootPath));

            Console.WriteLine($"Запись была произведена в текстовый файл {filename}");

        }

    }
}
