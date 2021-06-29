using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains1.Ex3
{
    class Program
    {

        static int[,]  DiagonalMssive(int[,] massive )
        {
            string tab = "";
            for(int i = 0; i < massive.GetLength(0);i++)
            {
                for(int j = 0; j < massive.GetLength(1);j++)
                {
                    Console.Write(tab);
                    Console.WriteLine(massive[i,j]);
                    tab += " ";
                }
            }

            return massive;
        }

        static void Vision(int[,] massive)
        {
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    
                    Console.Write(massive[i, j] + " ");
                    
                }

                Console.WriteLine();
            }
        }

        static int[,] GenerateMassive(int[,]  massive)
        {
            Random randome = new Random();

            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    massive[i, j] = randome.Next(0,10);
                }
            }
            

            return massive;
        }

        static void Main(string[] args)
        {
            int[,] massive = new int[5, 5];

            massive = GenerateMassive(massive);

            Vision(massive);

            DiagonalMssive(massive);
        }
    }
}
