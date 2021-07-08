using System;
using System.Diagnostics;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] localAll = Process.GetProcesses();
            VievProcess(localAll);
            ProcessKiller(localAll);

        }

        private static void VievProcess(Process[] localAll)
        {
            foreach (Process process in localAll)
            {
                Console.WriteLine($"ID процесса: {process.Id} Имя процесса: {process.ProcessName}");
            }
        }

        private static void ProcessKiller(Process[] localAll)
        {
            while (true)
            {
                Console.WriteLine("\nВы можете используя ID или по имени принудительно завершить процесс");
                Console.WriteLine("1 - По имени, 2 - По Id , 3 - Выйти из программы");

                bool success = Int32.TryParse(Console.ReadLine(), out int number);

                if (success)
                {
                    if (number == 1)
                    {
                        Console.WriteLine("Введите имя процесса");
                        string name = Console.ReadLine();

                        foreach (Process process in localAll)
                        {
                            if (process.ProcessName == name)
                            {
                                process.Kill();
                                Console.WriteLine("Процесс завершен");
                                break;
                            }
                        }
                        
                    }

                    if (number == 2)
                    {
                        Console.WriteLine("Введите ID процесса");
                        int id = int.Parse(Console.ReadLine());

                        foreach (Process process in localAll)
                        {
                            if (process.Id == id)
                            {
                                process.Kill();
                                Console.WriteLine("Процесс завершен");
                                break;
                            }
                        }
                        
                    }

                    if (number == 3)
                    {
                        break;
                    }

                }



            }
        }
    }
}