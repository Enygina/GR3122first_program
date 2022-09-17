/*Задача №24
Напишите программу, которая принимает на вход
число (А) и выдаёт сумму чисел от 1 до А.*/
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

//Метод вывода результата
void PrintResult(string line)
{
        Console.WriteLine(line);
}

int VariantSumSimple(int numA)
{
    int sumOfNumbers= 0;
    for(int i=1;i<=numA;i++)
    {
        sumOfNumbers+=i;
    }
    return sumOfNumbers;
}

int VariantSummaGause(int numA)
{
    int sumOfNumbers=0;
    sumOfNumbers=((1+numA)*numA)/2;
    return sumOfNumbers;
}

int number = ReadData("Введите число А:");
DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(number);
Console.WriteLine(DateTime.Now - d1);
DateTime d2 = DateTime.Now;
int res2 = VariantSummaGause(number);
Console.WriteLine(DateTime.Now - d2);
PrintResult("Сумма чисел от 1 до А ровна(простой метод):"+res1);
PrintResult("Сумма чисел от 1 до А ровна(метод Гауса):"+res2);