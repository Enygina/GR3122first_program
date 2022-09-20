/*№41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
* Пользователь вводит число нажатий, затем программа следит за нажатиями и
выдает сколько чисел больше 0 было введено.
*/


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
void PrintResult(string prefix, string line)
{
    Console.WriteLine(prefix + line);
}

//Метод подсчета введенных положительных чисел
int Count(int n)
{
    int res = 0;

    while (n > 0)
    {
        int num = ReadData("Введите  число");
        if (num > 0)
        {
            res++;
        }
        n--;
    }
    return res;
}

int numLen = ReadData("Введите количество элементов:");
PrintResult("Вы ввели ", (Count(numLen)) + " чисел больше 0");

