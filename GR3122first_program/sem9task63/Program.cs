/*Задача 63
Напишите программу, которая выдает все нантуральные числа
в промежутке от 1 до n*/


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

string LineGenRec(int numN)
{
	//точка остановки
	if (numN==0) return "";
	string outLine =LineGenRec(numN - 1)+ " "+ numN;
	return outLine;
}

int numN = ReadData("Введите число  ");
string resultLine = LineGenRec(numN);
PrintResult(resultLine);
