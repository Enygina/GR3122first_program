/*Задача №30
Напишите программу, которая выводит массив из 8
элементов, заполненный нулями и единицами в
случайном порядке.*/

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

int[] GenArray(int arrayLen)
{

    int[] array = new int[arrayLen];
    Random ren = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ren.Next(0, 2);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write((array[i]) + ",");
    }
        Console.WriteLine(array[array.Length - 1]);
    
}

PrintArray(GenArray(ReadData("Ведите длинну массива")));