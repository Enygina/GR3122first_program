/*Напишите пограмму, которая будет принимать 
на вход число N и возврашать сумму его чисел*/

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

int RecSumDigit(int num)
{
	return num == 0 ? 0 : num % 10 + RecSumDigit(num / 10);
}

// int num = ReadData("Введите число ");
// int sumDig=RecSumDigit(num);
// PrintResult("Сумма чисел в введенном числе : "+ sumDig);

PrintResult("Сумма чисел в введенном числе : "+(RecSumDigit(ReadData("Введите число "))));