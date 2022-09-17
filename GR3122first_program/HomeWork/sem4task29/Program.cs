// /*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*/

int ReadData(string line)//вводим число
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int meaning = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return meaning;
}

// int[] GenArray(int arrayLen, int start, int stop)//задаем массив в пределах заданной длины и значений
// {

//     int[] array = new int[arrayLen];
//     Random ren = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = ren.Next(start, stop);
//     }
//     return array;
// }

// void PrintArray(int[] array)//печать массива
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write((array[i]) + ",");
//     }
//     Console.WriteLine(array[array.Length - 1]);

// }


// int start = ReadData("Введите минимальное число произвольгого массива");
// int stop = ReadData("Введите максимальное число произвольгого массива");
// PrintArray(GenArray(ReadData("Ведите длинну массива"), start, stop));


string oneName=string.Empty;
int namesint =(ReadData("Введите имена через запятую или пробел"));
string names = namesint.ToString();
//"Кто за пивом"
// string ReadData1(string line)//вводим строку
// {
//     //Выводим сообщение
//     Console.WriteLine(line);
//     //Считываем значение
//     string meaning = Console.ReadLine() ?? "0";
//     //Возвращаем значение
//     return meaning;
// }

string RendomNameChoice(string nam)//разбивает строку на мссив, выбирает одно значение
{
    string[] nameList = names.Split(' ',',');

    foreach (var word in nameList)
    {
     oneName=nameList[new Random().Next(0,nameList.Length) ] ;
    }
return oneName;
}

void PrintResult(string line)//печать результата
{
    Console.WriteLine(line);
}

PrintResult(RendomNameChoice(names));