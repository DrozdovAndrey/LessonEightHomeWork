// Задача 58: Задайте две матрицы. Напишите программу, 
// которая выведет матрицу произведения элементов двух предыдущих матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// 10 6 24 49

namespace HomeWork8
{
    class Task58
    {
        static void Main(string[] args)
        {
            int n = new Random().Next(3, 7);
            int m = new Random().Next(3, 7);
            int[,] array1 = new int[n, m];
            int[,] array2 = new int[n,m];
            FillArray(array1);
            Console.WriteLine("Начальный Массив 1");
            PrintArray(array1);
            FillArray(array2);
            Console.WriteLine("Начальный Массив 2");
            PrintArray(array2);
            Console.WriteLine("Массив состоящий из произведений элементов массива 1 и 2:");
            MultiplicationArraysItem(array1, array2);
            PrintArray(array1);



            
            
        }
        static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10);
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
        
        static void MultiplicationArraysItem(int[,] array1, int[,] array2)
        {
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] *= array2[i,j];
                }
            }
        }

        
    }
}