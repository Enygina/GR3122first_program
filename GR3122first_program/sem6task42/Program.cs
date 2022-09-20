/*Задача №42
Напишите программу, которая будет
преобразовывать десятичное число в двоичное*/


// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string prefix,string data)
{
    Console.WriteLine(prefix+data);
}

string DecToBin(int number)
{
    string binNumber = String.Empty;
    while (number>0)
    {
        binNumber = number %2 + binNumber;
        number = number / 2;
    }
    return binNumber;
}

int inputNumber = ReadData("Введите число: ");

PrintResult("Исходное число в бинарном формате:",DecToBin(inputNumber));
// PrintResult($"Число(inputNumber)в двоичном представлении:{DecToBin(inputNumber)}");


int numb = ReadData("Введите число: ");
String numBin = Convert.ToString( numb, 2);
Console.WriteLine($"Число{numb} в двоичной системе: {numBin}");

numBin = Convert.ToString(numb, 8);
Console.WriteLine($"Число{numb} в восьмиричное системе: {numBin}");

numBin = Convert.ToString(numb, 16);
Console.WriteLine($"Число{numb} в шестнадцатиричное системе: {numBin}");