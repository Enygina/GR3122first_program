// Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23.

int inputNumber = 0;
void ReadData()
{
    Console.Write("Введите число: ");

    string? inputLine = Console.ReadLine();//Ввод числа
    if (inputLine != null)
    {
        int inputNumber = int.Parse(inputLine);//Перевод строки в целое число
    }
}

void ColPrint()
{
    if (inputNumber % 7 == 0 && inputNumber % 23 == 0)//проверка на кратность 7 и 23
    {
        Console.Write("Число кратно одновременно 7 и 23");
    }
    else
    {
        Console.Write("Число не кратно одновременно 7 и 23");
    }
}


int number, resultA, resultB;//Объявление переменный без присвоения значений
// запрашивает число у пользователь, 
//принимает текст запроса и команду выхода
int RequestNumber(string text = "Enter number", string exitCmd = "q")
{
    while (true) // цикл выполняется до введения целого числа или "q"
    {
        Console.Write(text + ": ");
        string? inputLine = Console.ReadLine();
        //Игнорируем пробел
        if (inputLine == null)// Определяем кратность чисел
        {
            continue;
        }
        //Выходим из программы
        if (inputLine.ToLower() == exitCmd)
        {
            Environment.Exit(0);
        }
        //Выдаем полученное число
        if (int.TryParse(inputLine, out int number))
        {
            return number;
        }
    }


}
void ReadData1()
{
    number = RequestNumber("Enter number");
}
void CalculateData()
{
    resultA = number % 7;
    resultB = number % 23;
}

// Вывод данных
void PrintData()
{
    if (resultA == 0 && resultB == 0)
    {

        Console.WriteLine("Число кртно 7 и 23");
    }
    else
    {
        Console.WriteLine("Число не кратно 7 и 23");
    }
}
ReadData1();
CalculateData();
PrintData();



string? inputLineA = Console.ReadLine();
if (inputLineA != null)//Проверка на пустоту
                       //Перевод в целочисленные+проверка кратноси на 7 и 23 ? (если да):(если нет)
    Console.Write(((int.Parse(inputLineA) % 7 == 0) && (int.Parse(inputLineA) % 23 == 0)) ? ("Кратно") : ("Не кратно"));

ReadData();
ColPrint();

