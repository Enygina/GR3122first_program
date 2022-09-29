/*Задача 60. ...Сформируйте трёхмерный массив из
неповторяющихся двузначных чисел. Напишите программу,
 которая будет построчно выводить массив, добавляя
 индексы каждого элемента.*/

int ReadData(string line)
{
	Console.Write(line);
	int number = int.Parse(Console.ReadLine() ?? "0");
	return number;
}

// Заполняем массив случайными числами
int[,,] Gen3DArr (int row, int column, int deep, int min,int max)
{
	int[,,] arr3D = new int[row, column, deep];
	List<int> numbs = Enumerable.Range(min,max-min+1).ToList();
Random rnd = new Random();
int index = 0;
	for (int i = 0; i < row; i++)
	{
		for (int j = 0; j < column; j++)
		{
			for (int k = 0; k < deep; k++)
			{
				index = rnd.Next(numbs.Count);
				arr3D[i, j, k] = numbs[index];
                numbs.RemoveAt(index);
            }
		}
	}
	return arr3D;
}

//Печать двумерного массива
void Print3DArray(int[,,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			for (int k = 0; k < matr.GetLength(1); k++)
			{
				Console.Write($"{matr[i, j, k]} ({i},{j},{k}) ");
			}
		}
		Console.WriteLine();
	}
	Console.WriteLine();
}

int row = ReadData("Введите размерность 1: ");
int column = ReadData("Введите размерность 2: ");
int deep = ReadData("Введите размерность 3: ");

Print3DArray(Gen3DArr(row, column, deep,10,99));



