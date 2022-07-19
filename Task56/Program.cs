// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

namespace HomeWork8
{
    class Task56
    {
        static void Main(string[] args)
        {
            int n = new Random().Next(3, 7);
            int m = new Random().Next(3, 7);
            int[,] array2 = new int[n, m];
            int[] array1 = new int[n];
            FillArray(array2);
            Console.WriteLine("Начальный Массив");
            PrintArray2(array2);
            array1 = FindSumStringElements(array2, array1);
            Console.WriteLine("Сумма всех элементов в строках");
            PrintArray1(array1);
            Console.WriteLine("");
            Console.WriteLine("Номер строки с минимальной суммой элементов:");
            MinSumString(array1);
            
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

        static void PrintArray2(int[,] array)
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

        static int[] FindSumStringElements(int[,] array, int[] array2)
        {
            int[] sum = new int[array.GetLength(0)];
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum1 = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum1 += array[i,j]; 

                }
                sum[i] = sum1;
            }
            return sum;
        }

        static void PrintArray1(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                    Console.Write(array[i] + " ");
            }
        }

        static void MinSumString(int[] array)
        {
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[min]) min = i;
            }
            Console.WriteLine(min+1);
        }
    }
}