// Напишите программу, которая будет
// принимать на вход два числа и выводить,
// является ли второе число кратным
// первому. Если второе число некратно
// первому, то программа выводит о статок
// от деления .

void Variant1()
{
    Console.Write("Введите первое число: ");//Ввод первое число
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");//Ввод второго числа
    string? inputLineB = Console.ReadLine();

    if ((inputLineA != null) && (inputLineB != null))
    {
        int inputNumberA = int.Parse(inputLineA);//перевод в целое число
        int inputNumberB = int.Parse(inputLineB);


        //тенарный оператор(см. остаток от деления) ? (выводтся, если да) : (выводится, если нет)
        Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("Остаток от деления: " + inputNumberB % inputNumberA));
    }
}
Variant1();
void Variant2()
{
    // Ввод первого числа
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    //  Ввод второго числа
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();

    if (inputLineA != null && inputLineB != null) //проверка на пустоту
    {
        int inputNumberA = (int)int.Parse(inputLineA);//перевод в целое число
        int inputNumberB = (int)int.Parse(inputLineB);

        Console.WriteLine(inputNumberB % inputNumberA == 0 ? "Является кратным" : "Остатак от деления " + inputNumberB % inputNumberA);
    }
}
Variant2();
int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

void ReadData()//Получаем два числа от пользователя
{
    Console.Write("Введите первое число: ");//Ввод первое число
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");//Ввод второго числа
    string? inputLineB = Console.ReadLine();
    if (inputLineA != null && inputLineB != null) //проверка на пустоту
    {
        inputNumberA = int.Parse(inputLineA);//перевод в целое число
        inputNumberB = int.Parse(inputLineB);
    }
}
void ConculateData()//Определяем кратность чисел
{
    result = (inputNumberB % inputNumberA == 0);
}
void PrintData()//Выводим данные вычисления
{
    if (result)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Остаток от деления: " + inputNumberB % inputNumberA);
    }
}

ReadData();
ConculateData();
PrintData();