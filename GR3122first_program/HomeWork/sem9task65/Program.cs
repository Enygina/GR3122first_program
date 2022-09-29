/*Задача 65 Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до M. */

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

string RecMN(int m,int n)
{
	string outLine = (m == n )? n+"" : m + " " + RecMN(m + 1, n);
	return outLine;
}

int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
if (m < n)
{
	PrintResult("Числа в промежутке от M до N " + RecMN(m, n));
}
else
{
	PrintResult("Числа в промежутке от M до N " + RecMN(n, m));
}

