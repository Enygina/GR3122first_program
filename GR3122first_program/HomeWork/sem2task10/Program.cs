//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа


//Вариант 1(массив):
int inputNumber = 0;

void ReadData()//Ввод числа
{
    Console.Write("Введите число: ");

    string? inputLine = Console.ReadLine();//Ввод числа
    if (inputLine != null)
    {
        inputNumber = int.Parse(inputLine);//Перевод строки в целое число
    }
}
void ColPrint()//Выполняем условие и выводим результат
{

    if (inputNumber.ToString().Length == 3) //Проверка на трехзначность
    {
        char[] charArray = inputNumber.ToString().ToCharArray();// перевод числа в массив

        Console.WriteLine(charArray[1]);//печатаем значение с индексом 1
    }

    else
    {
        Console.WriteLine("Пожалуйста, введите трехзначное число");
    }
}


ReadData();
ColPrint();


//Вариает 2 (Отбрасывание разряда):
void ReadData2()//Ввод числа
{
    Console.Write("Введите число: ");

    string? inputLine = Console.ReadLine();//Ввод числа
    if (inputLine != null)
    {
        inputNumber = int.Parse(inputLine);//Перевод строки в целое число
    }
}
void ColPrint2()//Выполняем условие и выводим результат
{

    if (inputNumber.ToString().Length == 3) //Проверка на трехзначность
    {
        int SecondDigital = inputNumber / 10 % 10; //отбрасываем первый и третий разряд
        Console.WriteLine(SecondDigital);
    }

    else
    {
        Console.WriteLine("Пожалуйста, введите трехзначное число");
    }
}

ReadData2();
ColPrint2();