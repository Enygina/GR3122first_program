/*Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между
ними в 2D пространстве.
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

void PrintResult(string line)//Вывод результата
{
    Console.WriteLine(line);
}
//расстоянение между двумя точками
double Сal(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
}
//Собираем данные
int x1 = ReadData("Введите x1: ");
int y1 = ReadData("Введите y1: ");
int x2 = ReadData("Введите x2: ");
int y2 = ReadData("Введите y2: ");


PrintResult(Math.Round(Сal(x1, y1, x2, y2)).ToString());//Вывод результата
