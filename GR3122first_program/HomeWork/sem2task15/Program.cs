//===========================================
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//===========================================

void Variant1()//Dictionaty
{
    Console.WriteLine("Введите значение:");
    int key = Convert.ToInt32(Console.ReadLine());//Получаем значение от пользователя

    var dayOfWeek = new Dictionary<int, string>()//Создаем словарь
    {
    {1,"Рабочий"},
    {2,"Рабочий"},
    {3,"Рабочий"},
    {4,"Рабочий"},
    {5,"Рабочий"},
    {6,"Выходной"},
    {7,"Выходной"}
    };


    if (dayOfWeek.ContainsKey(key))//проверка наличия значения в словаре
    {
        Console.WriteLine(dayOfWeek[key]);
    }
    else
    {
        Console.WriteLine("Значение не соответсвует дню недели");
    }
}
Variant1();

