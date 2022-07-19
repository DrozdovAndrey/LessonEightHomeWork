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
            int[,] array = new int[n, m];
            FillArray(array);
            Console.WriteLine("Начальный Массив");
            PrintArray(array);
            
            
            PrintArray2(FindSumStringElements(array));
            Console.WriteLine(MinSumString(OrderedArray(array)));
            
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

        static int[] FindSumStringElements(int[,] array)
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
            for (int i = 0; i < sum.Length; i++)
            {
                int min = sum[i];
                if (array[i+1] < array[min]) min = i;
            }

            return 
        }

        static void PrintArray2(int[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {

                    Console.Write(array[i] + " ");
                
            }
        }

        static int MinSumString(int[] array)
        {
            int min = 0;
            for (int i = 1; i <= array.Length; i++)
            {
                min = array[i-1];
                if (array[i] < array[min]) min = i;
            }
            
            return min;
        }
    }
}