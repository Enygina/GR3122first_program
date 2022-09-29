/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.*/

//Считываем данные пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
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

//Печать двумерного массива
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

//Перемножение двумерных массивов
int[,] Multiplication(int[,] arrA, int[,] arrB,int size)
{
    int[,] arrC = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                arrC[i, j] +=  + (arrA[i, k] * arrB[k, j]);
            }
        }
    }
    return arrC;
}

int size = ReadData("размерность матриц: ");

int[,] matrixA = new int[size, size];
Fill2DArray(matrixA,1,9);
Console.WriteLine("Матрица - А");
Print2DArray(matrixA);

int[,] matrixB = new int[size, size];
Fill2DArray(matrixB,1,9);
Console.WriteLine("Матрица - В");
Print2DArray(matrixB);

int[,] matrixC = new int[size, size];
Console.WriteLine("Произведение матриц А*В");
Print2DArray(Multiplication(matrixA,matrixB,size));