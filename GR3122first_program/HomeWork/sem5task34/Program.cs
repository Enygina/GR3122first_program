/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество
 чётных чисел в массиве.*/

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

int[] FillArray(int arrayLen, int downBorder, int topBorder)//Универсальный метод заполнения массива
{
    Random numSintezator = new Random();
    int[] array = new int[arrayLen];

    if (downBorder < topBorder)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = numSintezator.Next(downBorder, topBorder + 1);
        }
    }
    return array;
}
//Сортировка массива от мешьщего к большему
int[] BubbleSort(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
    }
return array;
}

//печать одномерный массив
void Print1DArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write((array[i]) + ",");
    }
    Console.WriteLine(array[array.Length - 1]);

}
//тест на четность
bool EvenTest(int count)
{
    return (count % 2 == 0);
}
//подсчтет четных значений в массиве
int EvenCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (EvenTest(arr[i]))
        {
            count++;
        }
    }
    return count;
}
//вывод на печать
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrayLength = ReadData("Введите длину массива");
int downBorder = 100;
int topBorder = 999;
int[] inputArray = BubbleSort(FillArray(arrayLength, downBorder, topBorder));
Print1DArray(inputArray);
int evenCount = EvenCount(inputArray);
PrintResult("Всего в массиве " + evenCount + " четных чисел");


