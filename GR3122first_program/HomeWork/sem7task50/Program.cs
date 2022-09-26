/*№50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
* Заполнить числами Фиббоначи и выделить цветом найденную цифру*/

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

double[] Fibonacci(int number)//Заполняем одномерный массив числами Фибоначчи
{
    double[] fibonacciArr = new double[number];
    fibonacciArr[1] = 1;

    for (int i = 2; i < number; i++)
    {
        fibonacciArr[i] = fibonacciArr[i - 2] + fibonacciArr[i - 1];
    }

    return fibonacciArr;
}

double[,] Convert1DTo2DArray(double[] arr1D, int countRow, int countColumn)//Конвертация одномерного массива в двумерный
{
    int index = 0;
    double[,] arr2D = new double[countRow, countColumn];

    for (int i = 0; i < countRow; ++i)
        for (int j = 0; j < countColumn; ++j)
        {
            arr2D[i, j] = arr1D[index];
            index++;
        }


    return arr2D;
}

void Print2DArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

bool CheckExistSorchingElement(int i, int j, int x, int y)
{
    if (i > x && j > y)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Печать двумерного массива цветом
void Print2DArrayColoredElement(double[,] matr, int x, int y)//Печать двумерного массива с выделением искомого элемента цветом
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == x && j == y)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{matr[i, j]} ");
                Console.ResetColor();
            }
            else
            {
                Console.Write($"{matr[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

// Метод, выведения результата
void PrintResult(int row,int column,int x,int y, int arrLength)
{
    if (CheckExistSorchingElement(row, column, x, y))
    {
        Print2DArrayColoredElement(Convert1DTo2DArray(Fibonacci(arrLength), row, column), x, y);
    }
    else
    {
        Console.WriteLine("Искомого элемента в массиве нет");
    }
}

int row = ReadData("Введите количество столбцов: ");
int column = ReadData("Введите количество сток: ");
int arrLength = row * column;
Print2DArray(Convert1DTo2DArray(Fibonacci(arrLength), row, column));
int x = ReadData("Введите строчку искомого элемента ");
int y = ReadData("Введите столбец искомого элемента ");
PrintResult(row, column, x, y, arrLength);