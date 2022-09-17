/*Задача №26
Напишите программу, которая принимает на вход
число и выдаёт количество цифр в числе.*/

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

void PrintResult(string line)
{
        Console.WriteLine(line);
}

int DigitCount(int num)
{
    int sum=0;
    while(num>0)
    {
        sum+=1;
        num=num/10;
    }
    return sum;
}

int LogDigit(int num)//Длинна логорифмом
{
return (int)(Math.Log10(num)+1);
}

int StringDigit(int num)//Длинна строки

{
    string numstring = num.ToString();
    return numstring.Length;
}


int number = ReadData("Введите число: ");
int nunberOfGigits=LogDigit(number);
PrintResult("Количество цифр в числе:"+nunberOfGigits);

nunberOfGigits=DigitCount(number);
PrintResult("Количество цифр в числе:"+nunberOfGigits);

nunberOfGigits=StringDigit(number);
PrintResult("Количество цифр в числе:"+nunberOfGigits);