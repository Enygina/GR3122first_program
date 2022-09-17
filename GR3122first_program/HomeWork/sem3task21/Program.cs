// /*Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/

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
double Сal(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1)+(z1-z2)*(z1-z2));
}
//Собираем данные
int x1 = ReadData("Введите x1: ");
int y1 = ReadData("Введите y1: ");
int z1 = ReadData("Введите z1: ");
int x2 = ReadData("Введите x2: ");
int y2 = ReadData("Введите y2: ");
int z2 = ReadData("Введите z2: ");

PrintResult(Math.Round(Сal(x1, x2, y1, y2, z1, z2)).ToString());//Вывод результата



void ReadChar()//Считываем координаты в массив, конвертируем его в int считаем расстояние
{
Console.WriteLine("Введите координаты точек X и Y через запятую без пробелов: ");
string? coordinate = (Console.ReadLine() ?? "0");//считываем координаты с консоли

string[] coorArray = coordinate.Split(new char[] { ',' });//записываем координаты в массив
int[] ArrayX = Array.ConvertAll(coorArray, s => int.Parse(s));//строковый массив переводим в целочисленный

Console.WriteLine(Math.Round (Math.Sqrt((ArrayX[3] - ArrayX[0])*(ArrayX[3] - ArrayX[0]) + (ArrayX[4] - ArrayX[1])
*(ArrayX[4] - ArrayX[1])+(ArrayX[5] - ArrayX[2])*(ArrayX[5] - ArrayX[2]))));
}
ReadChar();