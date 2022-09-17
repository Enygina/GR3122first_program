/*Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную 
степень B.*/

int ReadData(string line)//воодим число
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

long Pow(int a, int b)//возведение в степень
{
    long result = 1;
    for (int i = 0; i < b; i++)
        result = result * a;
    return result;
}

double MathPow(int a, int b)//mathpow метод
{
    double result = Math.Pow(a, b);
    return result;
}

void PrintResult(long nam)//печать результата
{
    Console.WriteLine(nam);
}

int numA = ReadData("Введите число A:");
int numB = ReadData("Введите число B:");

PrintResult(Pow(numA, numB));
PrintResult((long)MathPow(numA, numB));



double numberX = Convert.ToDouble(ReadData("Введите первое число: "));
double numberY = Convert.ToDouble(ReadData("Введите второе число: "));
Console.Write("Выбирите действие (+, -, *, /, ^): ");
char action = (char)Console.Read();

switch (action)//кейсовый калькулятор
{
    case '+':
        double result = numberX + numberY;
        Console.WriteLine("{0} + {1} = {2}", numberX, numberY, result);
        break;

    case '-':
        result = numberX - numberY;
        Console.WriteLine("{0} - {1} = {2}", numberX, numberY, result);
        break;

    case '*':
        result = numberX * numberY;
        Console.WriteLine("{0} * {1} = {2}", numberX, numberY, result);
        break;

    case '/':
        result = numberX / numberY;
        Console.WriteLine("{0} / {1} = {2}", numberX, numberY, result);
        break;

    case '^':
        result = Math.Pow(numberX ,numberY) ;
        Console.WriteLine("{0} ^ {1} = {2}", numberX, numberY, result);
        break;

    default:
        Console.WriteLine("Недопустимый оператор");
        break;

}

