// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8

namespace HomeWork8
{
    class Task54
    {
        static void Main(string[] args)
        {
            int n = new Random().Next(3, 7);
            int m = new Random().Next(3, 7);
            int[,] array = new int[n, m];
            FillArray(array);
            Console.WriteLine("Начальный Массив");
            PrintArray(array);
            OrderedArray(array);
            Console.WriteLine("Упорядоченный по строкам массив: ");
            PrintArray(array);
            
        }
        static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 10);
                }
            }
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void OrderedArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int minPosition = j;
                    for (int k = j + 1; k < array.GetLength(1); k++)
                    {
                        if (array[i,k] < array[i,minPosition]) minPosition = k;
                    }
                    int temprorary = array[i,j];
                    array[i,j] = array[i, minPosition];
                    array[i,minPosition] = temprorary;

                }
            }
        }
    }
}