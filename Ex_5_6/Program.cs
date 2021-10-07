using System;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stertOver = true;
            while (stertOver)
            {
                Console.WriteLine("Введите границы массива: ");
                int strings = Convert.ToInt32(Console.ReadLine());
                int rows = strings;
                int[,] array = new int[strings, rows];
                Random rnd = new Random();
                int buffer;
                Console.WriteLine("Массив: \n");
                for (int i = 0; i < strings; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        array[i, j] = rnd.Next(100);
                        Console.Write($"{array[i, j]}\t");
                    }
                    Console.WriteLine();
                }

                for (int i = 1; i < strings; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        buffer = array[i, j];
                        array[i, j] = array[j, i];
                        array[j, i] = buffer;
                    }
                }

                Console.WriteLine("Транспонированная матрица:");
                for (int i = 0; i < strings; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        Console.Write($"{array[i, j]}\t");
                    }
                    Console.WriteLine();
                }


                Console.WriteLine("\n Начать сначала?(y/n)");
                stertOver = Console.ReadLine() == "y" ? true : false;
            }


        }
    }
}
