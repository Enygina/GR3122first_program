/*Задача 69 Возьмите число А и В и возведите
 число А в целую степень число В*/
 
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

int RecPow(int a,int b)
{
	return b == 1 ? a : a *RecPow(a,b-1);
}

int a = ReadData("Введите число А: ");
int b = ReadData("Введите число B: ");
PrintResult("А в степени В: " + RecPow(a, b));