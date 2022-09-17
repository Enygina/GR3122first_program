/*Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.*/

int ReadData(string line)//вводим число
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

void PrintResult(string line)//печать резльтата
{
    Console.WriteLine(line);
}
   

string number = (ReadData("Введите число:")).ToString(); 

int SumChar(string number)//массив
{
int sum = (int)number.Select(n => Char.GetNumericValue(n)).Sum();//число записываем в массив, переводим в цисловой формат, перебирает, суммируем
return sum;
}

int num= ReadData("Введите число:");

int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

DateTime d1 = DateTime.Now;
SumChar(number);
Console.WriteLine(DateTime.Now - d1);
DateTime d2 = DateTime.Now;
SumDigit(num);
Console.WriteLine(DateTime.Now - d2);
//Отделить и суммировать заведомо быстрее, чем закинуть в массив, преобразовать, перебрать, сложить

PrintResult("Сумма цифр в числе:" + SumChar(number).ToString());
PrintResult("Сумма цифр в числе:" + SumDigit(num));