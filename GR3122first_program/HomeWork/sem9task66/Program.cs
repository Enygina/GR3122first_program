/*Задача 66: Задайте значения M и N. Напишите 
программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.*/

// / Чтение данных из консоли
int ReadData(string line)
{
	Console.Write(line);
	int number = int.Parse(Console.ReadLine() ?? "0");
	return number;
}

// Вывод результата в консоль
void PrintResult(string data)
{
	Console.WriteLine(data);
}

int SumRecMN(int m, int n)
{
	int sum = (m == n) ? +n : m + SumRecMN(m + 1, n);
	return sum;
}

int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
if (m < n)
{
	PrintResult("Сумма чисел в промежутке от M до N равна " + SumRecMN(m, n));
}
else
{
	PrintResult("M N " + SumRecMN(n, m));
}
