/*№47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
* При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)*/

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// печать результата
void PrintData(string prefix, string data) //разбили на две части вывод в консоль
{
    Console.WriteLine(prefix + data); //сначала выводим prefix + а потом данные data\
}

double[,] RealNumFill2DArray(int countRow, int countColumn, int downBorder, int topBorder)//Заполнение массива вещественными числами
{
    double[,] array2D = new double[countRow, countColumn];
    Random random = new Random();
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = random.NextDouble() * random.Next(downBorder, topBorder + 1);
        }
    }
    return array2D;
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};


void PrintColorElement(string data)
{
    foreach (char element in data)
    {
        Console.ForegroundColor = col[new System.Random().Next(0, 16)];
        Console.Write(element);
        Console.ResetColor();
    }
}

// Печать двумерного массива цветом
void Print2DArrayColored(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            PrintColorElement(Math.Round(matr[i, j],4)+ "\t");
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int downBorder = ReadData("Введите минимальное значение массива ");
int topBorder = ReadData("Введите максимальное значение массива ");

double[,] arr2D = RealNumFill2DArray(row, column, downBorder, topBorder);
Print2DArrayColored(arr2D);