/*Напишите программу, которая принимает на вход
число (N) и выдаёт таблицу квадратов чисел от 1 до
N.
*/

int ReadData(string line)//Выводит сообщение
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

string lineNambers(int numberN, int pow)//возвращает числа с шагом i по порядку и возводит их в степень pow
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + Math.Pow(i,pow) + "\t";
        ++i;
    }
    outLine = outLine + Math.Pow(numberN,pow);
    return outLine;
   
}

void PrintResult(string line)//Вывод результата
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N:");

PrintResult(lineNambers(num,1));
PrintResult(lineNambers(num,2));