/*Задача №28 Напишите программу, которая принимает на вход
число N и выдаёт произведение чисел от 1 до N.*/

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

long SumDigit(long num)//Подсчет суммы через while
{
    int i = 1;
    long sum = 1;
    while (num >= i)
    {
        sum = sum * i;
        i++;
    }
    return sum;
}

long ColculateFactorial(int num)
{
    long factorial = 1;
    for (long i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int number = ReadData("Введите число: ");
long SumNumbers = SumDigit(number);
PrintResult("Произведение чисел от 1 до вееденого:" + SumNumbers);

SumNumbers = ColculateFactorial(number);
PrintResult("Произведение чисел от 1 до вееденого:" + SumNumbers);