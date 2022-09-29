/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}
int[,] UpdateArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        List<int> pow = new List<int>();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            pow.Add(arr[i, j]);
            pow.Sort();
        }
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = pow[arr.GetLength(1)-j-1];
        }

    }
    return arr;
}

int[,] array2D = new int[4, 4];
Fill2DArray(array2D, 0, 9);
Print2DArray(array2D);
UpdateArr(array2D);
Print2DArray(array2D);