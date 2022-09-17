//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


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

    if (inputNumber.ToString().Length > 2) //Проверка на наличие 3 цифры
    {
        char[] charArray = inputNumber.ToString().ToCharArray();// перевод числа в массив

        Console.WriteLine(charArray[2]);//печатаем значение с индексом 1
    }

    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}


ReadData();
ColPrint();


//Вариает 2 (Тернарный):
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

    if (inputNumber.ToString().Length > 2) //Проверка на трехзначность
    {
        // проверка на разрядность ? если да : если нет
        Console.WriteLine(inputNumber > 99 ? inputNumber.ToString()[2] : '-');

    }

    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

ReadData2();
ColPrint2();

//Вариант 3: (отсечение десятков/остаток от деления)
int result = 0;
void ReadData3()//Ввод числа
{
    Console.Write("Введите число: ");

    string? inputLine = Console.ReadLine();//Ввод числа
    if (inputLine != null)
    {
        inputNumber = int.Parse(inputLine);//Перевод строки в целое число
    }
}
void Col3()//Выполняем условие 
{
    while (inputNumber > 999)//пока число больше 999
    {

        inputNumber = inputNumber / 10;//Убираем разряд
    }
    result = inputNumber % 10;//находим остаток от деления
}
void Print3()//Печать результата
{
    Console.WriteLine(result);

}

ReadData3();
Col3();
Print3();

//Вариант 4:(поиск разряда логорифмом)
long convertedNumber = 0; //переменная для конвертации строки в long
double digitN = 0;
double ceilDigit = 0;
double thirdDigit = 0;


void ReadData4()//Ввод числа
{
    Console.Write("Введите число: ");

    string? inputLine = Console.ReadLine();//Ввод числа 
    {
        if (inputLine != null)//Проверка на пустоту
        {
            try
            {
                convertedNumber = Convert.ToInt64(inputLine); //конвертация в long  из string
            }
            catch
            {
                //если неверный формат
            }
        }
    }
}
void ColPrint4()
{

    digitN = Math.Log10(convertedNumber);//логорифмом находим ко-во цифр в числе
    ceilDigit = Math.Ceiling(digitN);//округляем до целого

    //Ищем заданный разряд
    if (convertedNumber > 99)
    {
        if (convertedNumber < 1000)//От 100 до 999
        {
            thirdDigit = convertedNumber % 10;//остаток от деления
            Console.WriteLine(thirdDigit);
        }
        else//от 1000
        {//отбрасываем цифры после третьей + остатоком от деления убираем превые 2
            thirdDigit = (Math.Floor(convertedNumber / (Math.Pow(10, ceilDigit - 3)))) % 10;
            Console.WriteLine(thirdDigit);
        }
    }
    else//меньше 100
    {
        Console.WriteLine("Нет третьей цифры");
    }
}

ReadData4();
ColPrint4();





