// Задача №16
// Напишите программу, которая принимает
// на вход два числа и проверяет, является
// ли одно число квадратом другого.




int ReadData1(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine()?? "0");
    //Возвращаем значение
    return number;
}
bool SqrTest(int firstNum, int secondNum)//Тест на квадрат
{
    if (firstNum == secondNum * secondNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Вывод данных
void PrintData(int firstNum, int secondNum)
{
        if (SqrTest(firstNum, secondNum))
        {
            Console.WriteLine("Число " + firstNum + "квадрат числа" + secondNum);
        }
        else
        {
            Console.WriteLine("Число " + firstNum + " не квадрат числа" + secondNum);
        }
}


int num1 = ReadData1("Введите число 1:");
int num2 = ReadData1("Введите число 1:");

PrintData(num1, num2);
PrintData(num2, num1);


