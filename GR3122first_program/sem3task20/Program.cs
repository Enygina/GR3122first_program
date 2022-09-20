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
double Сal(double x1, double x2, double y1, double y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
}
//Собираем данные
double x1 = ReadData("Введите x1: ");
double y1 = ReadData("Введите y1: ");
double x2 = ReadData("Введите x2: ");
double y2 = ReadData("Введите y2: ");


PrintResult(Math.Round(Сal(x1, y1, x2, y2)).ToString());//Вывод результата
