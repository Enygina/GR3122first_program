/*№52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
* Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
цветом.*/

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void Print1DArray(double[] array)//печать массива
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write((array[i]) + ",");
    }
    Console.WriteLine((array[array.Length - 1]));
}

void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}");
        }
        Console.WriteLine();
    }  
}

int[,] Fill2DArray(int downBorder,int topBorder, int row, int column)//Универсальный метод заполнения массива
{
      int[,] array2D = new int[row,column];

    if (downBorder < topBorder)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                array2D[i,j] = new Random().Next(downBorder, topBorder + 1);
            }
        }
    }
    return array2D;
}

double[]CalcAveragesColumn(int[,]arr)
{
    double[] averages = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0);i++)
    {
        for (int j = 0; j < arr.GetLength(1);j++)
        {
            averages[j] += arr[i, j];
        }
    }

        return DivideArr(averages,arr.GetLength(0));
}

double[]DivideArr(double[]arr,int divider)
{
    for (int i = 0; i < arr.Length;i++)
    {
        arr[i] = Math.Round(arr[i] / divider, 2);
    }
        return arr;
}
void PrintResult( string data)
{
Console.WriteLine(data);
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int downBorder = ReadData("Введите минимальное значение массива ");
int topBorder = ReadData("Введите максимальное значение массива ");
int[,] array2D = Fill2DArray(downBorder, topBorder, row, column);
Print2DArray(array2D);
Console.WriteLine();
PrintResult($"Среднее арифметическое по столбцам: ");
Print1DArray(CalcAveragesColumn(array2D));