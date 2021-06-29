using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        //Работа в процессе реализации.Есть мысль попробовать случайное расположение кораблей

        static void ClearField(string[,] field) //Чистое поле
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = "O";
                }
            }
        }


        

        static void Randomazer(string[,] field, int numBoat) //Заполнение кораблями 
        {
            string x = "X";
            int boats = numBoat;
            Random randomer = new Random();

            //4 палубный

            while (true)
            {
                int i = randomer.Next(0, 11);
                int j = randomer.Next(0, 11);
                int ii = i;
                int jj = j;

                    if (field[i, j] != x)
                    {
                        field[i, j] = x;
                        boats--;
                    }
                    else
                    {
                        continue;
                    }

                    try
                    {
                        for (; boats > 0; boats--)
                        {
                            i++;
                            if (field[i, j] == x)
                            {
                                field[i, j] = x;
                            }
                        }
                    break;
                    }
                    catch
                    {
                        try
                        {
                        i = ii;
                        boats = numBoat;

                            for (; boats > 0; boats--)
                            {
                                i--;
                                if (field[i, j] == x)
                                {
                                    field[i, j] = x;
                                }

                            }
                        break;
                        }
                        catch
                        {
                            try
                            {
                            i = ii;
                            boats = numBoat;
                            for (; boats > 0; boats--)
                                {
                                    j++;
                                    if (field[i, j] == x)
                                    {
                                        field[i, j] = x;
                                    }
                                }
                            }
                            catch
                            {

                                try
                                {
                                    j = jj;
                                    i = ii;
                                boats = numBoat;
                                for (; boats > 0; boats--)
                                        {
                                            j--;
                                            if (field[i, j] == x)
                                            {
                                            field[i, j] = x;
                                            }
                                        }
                                    break;
                                }
                                catch
                                {
                                    continue;
                                }
                            }
                        }
                    }
            }
        }
                
     
        static void Vision(string[,] field) //Отображение
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i,j]);
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            string[,] field = new string[10, 10];

            ClearField(field);
            Vision(field);
            Randomazer(field,4);
            Console.WriteLine();
            Vision(field);
        }
    }
}

