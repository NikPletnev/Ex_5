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
                int rows = Convert.ToInt32(Console.ReadLine());
                int[,] array = new int[strings, rows];
                Random rnd = new Random();
                int count = 0;
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

                for(int i = 0; i < strings; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        
                        if((i+1 == strings || array[i,j] > array[i+1,j]) && (j+1 == rows || array[i, j] > array[i , j +1]) && (i == 0 || array[i, j] > array[i-1, j]) && (j == 0 || array[i, j] > array[i, j - 1]))
                            {
                                count++;
                            }
                    }
                }

                Console.WriteLine($"Rоличество элементов массива, которые больше всех своих соседей одновременно: {count}");
                Console.WriteLine("\n Начать сначала?(y/n)");
                stertOver = Console.ReadLine() == "y" ? true : false;
            }


        }
    }
}
