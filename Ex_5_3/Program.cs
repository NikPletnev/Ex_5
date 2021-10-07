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
                int min = 0;
                string minIndex = "";
                Console.WriteLine("Массив: \n");
                for (int i = 0; i < strings; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        array[i, j] = rnd.Next(100);
                        Console.Write($"{array[i, j]}\t");
                        if (i == 0 && j == 0)
                        {
                            min = array[i, j];
                            minIndex = "[0 , 0]";
                        }
                        else
                        {
                            if (min > array[i, j])
                            {
                                min = array[i, j];
                                minIndex = $"[{i} , {j}]";
                            }
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"Индекс минимального элемента массива: {minIndex}");
                Console.WriteLine("\n Начать сначала?(y/n)");
                stertOver = Console.ReadLine() == "y" ? true : false;
            }


        }
    }
}
