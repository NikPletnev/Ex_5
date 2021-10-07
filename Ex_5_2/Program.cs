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
                int max = 0;
                Console.WriteLine("Массив: \n");
                for (int i = 0; i < strings; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        array[i, j] = rnd.Next(100);
                        Console.Write($"{array[i, j]}\t");
                        if (i == 0 && j == 0)
                        {
                            max = array[i, j];
                        }
                        else
                        {
                            max = max < array[i, j] ? array[i, j] : max;
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"Максимальное значение: {max}");
                Console.WriteLine("\n Начать сначала?(y/n)");
                stertOver = Console.ReadLine() == "y" ? true : false;
            }


        }
    }
}
