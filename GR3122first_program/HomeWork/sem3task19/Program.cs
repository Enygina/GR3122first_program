/*Задача 19
Напишите программу, которая принимает на вход
пятизначное число и проверяет, является ли оно
палиндромом.
*/
//Вариант 1(массив):

long ReadDataLong(string line) //Ввод числа 
{
    Console.Write(line);

    string? inputLine = (Console.ReadLine() ?? "0"); //Ввод числа
    long inputNumber = Convert.ToInt64(inputLine); //Перевод строки в целое длинное число
    return inputNumber;
}

void CharPalinTest(long inputNumber) //вводим два массива, один переводачиваем и сравниваем
{
    char[] charArray = inputNumber.ToString().ToCharArray();
    char[] revCharArray = inputNumber.ToString().ToCharArray();
    Array.Reverse(revCharArray);

    bool palinTest = charArray.SequenceEqual(revCharArray);
    Console.WriteLine("Введенное число {0}", palinTest ? "палиндром" : "не палиндром");
}
long inputNumber = ReadDataLong("Введите число для проверки на палиндром: ");

CharPalinTest(inputNumber);


//Вариант 2 словарь

Dictionary<int, string> palin = new Dictionary<int, string>();

for (int i = 1; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        palin.Add(i * 1000 + j * 100 + j * 10 + i, "палиндром");
    }
}

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

bool PalinLenfthTest(int number)//проверка на пятизначность
{
    if (Math.Log10(number) <= 5 && Math.Log10(number) >= 4)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool DicPalinTest(int number, Dictionary<int, string> palin)//Все пятизначные проверяем на наличие в словаре палиндромов
{

    if (PalinLenfthTest(number))
    {
        int palinFour = number / 1000 * 100 + number % 100;//преодразуем пятизначное число в четырехзначное
        return palin.ContainsKey(palinFour);//четырехзначное сверяем с ключем
    }
    else
    {
        return false;
    }
}

void PrintTest(string line)//печать результата
{
    Console.WriteLine(line);
}
int number = ReadData("Введите число для проверки на палиндром");
PrintTest(DicPalinTest(number, palin) ? "Число палиндром" : "Число не палиндром или имеет более 5 символов");


bool PalinCharTest(int number)//сравнение индексов массива
{
    if (PalinLenfthTest(number))
    {
        char[] PalinAr = number.ToString().ToCharArray();
        if (PalinAr[0] == PalinAr[4] && PalinAr[1] == PalinAr[3])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }
}
PrintTest(PalinCharTest(number) ? "Число палиндром" : "Число не палиндром или имеет более 5 символов");

//вариант hash


Dictionary<int, int> GenerateDicPoli()
{
    Dictionary<int, int> palindrom = new Dictionary<int, int>();

    for (int i = 10; i < 100; i++)
    {
        int polik = (i) * 100 + (i % 10) * 10 + i / 10;
        palindrom.Add(polik,0);
    }
    return palindrom;
}
Dictionary<int, int> palindrom = GenerateDicPoli();
bool TestPalindKey(int namber, Dictionary<int, int> palindrom)
{
    if (palindrom.ContainsKey(number))
    {
        return true;
    }
    else
    {
        return false;
    }
}

DateTime d = DateTime.Now;
TestPalindKey(number,palindrom);
Console.WriteLine(DateTime.Now - d);