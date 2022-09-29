/*Задача 56: Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку 
 с наименьшей суммой элементов.*/
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
int MinFindRow(int[,] arr)
{
    int min =int.MaxValue;
    int sum = 0;
    int outIndexRow = -1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (min > sum) { min = sum; outIndexRow = i; }
        sum = 0;

    }
    return outIndexRow;
}
// Метод, принимает строку, выводит в консоль
void PrintResult( string line)
{
    Console.WriteLine(line);
}

int[,] array2D = new int[6, 6];
Fill2DArray(array2D, 0, 9);
Print2DArray(array2D);
PrintResult("Минимальная сумма чисел в строке: "+(MinFindRow(array2D)-1));