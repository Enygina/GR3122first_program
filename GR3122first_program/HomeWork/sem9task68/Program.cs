/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

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

//Метод вычисления функции Аккермана:
int AckermannFunction (int numM, int numN)
{
	if (numM == 0) return numN + 1;
	if (numM != 0 && numN == 0) return AckermannFunction(numM - 1, 1);
	if (numM > 0 && numN > 0) return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
return AckermannFunction(numM, numN);
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
PrintResult($"Функция Аккермана для чисел A({numM},{numN}) = {AckermannFunction(numM, numN)}");