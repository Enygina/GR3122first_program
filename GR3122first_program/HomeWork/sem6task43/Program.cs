/*№43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
* Найдите площадь треугольника образованного пересечением 3 прямых*/

int ReadData(string line)//вводим число
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

void Print1DArray(double[] array)//печать массива
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write((array[i]) + ",");
    }
    Console.WriteLine((array[array.Length - 1]));
}
//поиск точки пересечения двух прямых
double[] PointFind(double k1, double b1, double k2, double b2)
{
    double[] outArr = new double[2];
    if ((k1 == k2 && b1 != b2) || (k1 == k2 && b1 == b2))
    {
        Console.WriteLine("Прямые не пересекаютя");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        outArr[0] = x;
        outArr[1] = y;
    }
    return outArr;
}


// double k1 = (ReadData("Введите число k1"));
// double b1 = (ReadData("Введите число b1"));
// double k2 = (ReadData("Введите число k2"));
// double b2 = (ReadData("Введите число b2"));

// PrintResult("Прямые пересекуться в точке с координатами: ");
// Print1DArray(PointFind(k1, b1, k2, b2));




// double k3 = (ReadData("Введите число k3"));
// double b3 = (ReadData("Введите число b3"));

//поиск точки пересечения трех прямых
double[] PointFindTriangle(double k1, double b1, double k2, double b2, double k3, double b3)
{
    double[] outArr = new double[6];
    if (k1 == k2 || k2 == k3 || k1 == k3)
    {
        Console.WriteLine("Прямые не образуют треугольник");
    }
    else
    {
        double x = Math.Round(((b2 - b1) / (k1 - k2)),4);
        double y = Math.Round((k1 * x + b1),4);
        double x1 = Math.Round(((b3 - b1) / (k1 - k3)),4);
        double y1 = Math.Round((k1 * x1 + b1),4);
        double x2 = Math.Round(((b2 - b3) / (k3 - k2)),4);
        double y2 = Math.Round((k3 * x2 + b3),4);
        outArr[0] = x;
        outArr[1] = y;
        outArr[2] = x1;
        outArr[3] = y1;
        outArr[4] = x2;
        outArr[5] = y2;
    }
    Print1DArray(outArr);
    return outArr;
}
//по точкам пересечения находим длинну сторон триугольника
double[] Сal(double [] arr)
{
  double[] trnSide = new double[3];
    double a =Math.Sqrt((Math.Pow(arr[2] - arr[0],2)) + (Math.Pow((arr[3] - arr[1]),2)));
    double b = Math.Sqrt((Math.Pow(arr[4] - arr[0],2)) + (Math.Pow((arr[5] - arr[1]),2)));
    double c = Math.Sqrt((Math.Pow(arr[4] - arr[2],2)) + (Math.Pow((arr[5] - arr[3]),2)));
    trnSide[0] = a;
    trnSide[1] = b;
    trnSide[2] = c;
    Print1DArray(trnSide);
    return trnSide;
}

double TriangleArea(double[] arr)
{
    double p = 0.5 * (arr[0] + arr[1] + arr[2]);//полупериметр треугольника
    double result = Math.Sqrt(p * (p - arr[0]) * (p - arr[1]) * (p - arr[2]));
    return result;
}
// PrintResult("Площедь треугольника: "+TriangleArea(Сal(PointFindTriangle(k1, b1, k2, b2, k3, b3))));




// Задача 43(+)
// * Найдите площадь треугольника образованного пересечением 3 прямых
// ---------------------------------------------------------------------

// // Чтение данных из консоли
// double ReadData(string line)
// {
// // Выводим сообщение
// Console.Write(line);
// // Считываем число
// double number = double.Parse(Console.ReadLine() ?? "0");
// // Возвращаем значение
// return number;
// }

// Печать результата
void PrintResult(string prefix, string data)
{
Console.WriteLine(prefix + data);
}

// // Поиск точки пересечения двух прямых
// double[] PointFind(double k1, double b1, double k2, double b2)
// {
// double[] outtArr = new double[2];
// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;
// outtArr[0] = x;
// outtArr[1] = y;
// return outtArr;
// }

// Нахождение длины отрезка по двум точкам
double Segment(double[] pointA, double[] pointB)
{
return Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2) + Math.Pow(pointA[1] - pointB[1], 2));
}

// Нахождение площади треугольника
double SquareTriangle(double AB, double BC, double CA)
{
double p = (AB + BC + CA) / 2;
return Math.Round(Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA)), 2);
}

// Нахождение площади треугольника по кординатам вершин
double SquareTriangleWithPoint(double[] pointA, double[] pointB, double[] pointC)
{
return Math.Abs((pointB[0] - pointA[0]) * (pointC[1] - pointA[1]) - (pointC[0] - pointA[0]) * (pointB[1] - pointA[1])) / 2;
}

double k1 = ReadData("Введите k1: ");
double b1 = ReadData("Введите b1: ");
double k2 = ReadData("Введите k2: ");
double b2 = ReadData("Введите b2: ");
double k3 = ReadData("Введите k3: ");
double b3 = ReadData("Введите b3: ");

double[] pointA = PointFind(k1, b1, k2, b2);
double[] pointB = PointFind(k1, b1, k3, b3);
double[] pointC = PointFind(k3, b3, k2, b2);

double AB = Segment(pointA, pointB);
double BC = Segment(pointC, pointB);
double CA = Segment(pointA, pointC);

double square = SquareTriangle(AB, BC, CA);
double squarePoint = SquareTriangleWithPoint(pointA, pointB, pointC);

PrintResult("Площадь треугольника равна: ", square.ToString());
PrintResult("Площадь треугольника равна (Второй вариант): ", squarePoint.ToString());