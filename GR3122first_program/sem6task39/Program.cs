/*Задача №39
Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на
первом месте, а первый - на последнем и т.д.)
Например:
[1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
Комментарий: эту задачу можно решить 2 способами: 1)
менять числа местами в исходном массиве; 2) создать
новый массив и в него записать перевёрнутый исходный
массив по элементам.*/

// Заполняем массив
int[] GenArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.Next(start, stop + 1);
    }
    return array;
}
// печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}
//метод разворота массива с созданием нового массива
int[] SwapNewArray(int[] array)
{
    int[] outArr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        outArr[i] = array[array.Length - 1 - i];
    }
    return outArr;
}


//метод разворота массива с созданием нового массива
int[] SwapArray(int[] array)
{
    int bufElement = 0;
    for (int i = 0; i < array.Length/2;i++)
    {
        bufElement = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = array[i];
        array[i] = bufElement;
    }
        return array;
}

int[] array = GenArray(20, 1, 100);
Console.WriteLine("Исходный массив");
PrintArray(array);

int[] copyArray = SwapNewArray(array);
Console.WriteLine("Новый перевернутый массив массив");
PrintArray(copyArray);
Console.WriteLine("Исходный массив");
PrintArray(array);

array = SwapArray(array);
Console.WriteLine("Перевернутый исходный массив массив");
PrintArray(array);