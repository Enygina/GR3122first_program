/*№36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
элементов, стоящих на нечётных позициях.*/

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

void Print1DArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write((array[i]) + ",");
    }
    Console.WriteLine(array[array.Length - 1]);

}

int EvenSumPosition(int[] arr)//Поиск суммы нечетных элементов
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrayLength = ReadData("Введите длину массива");
int downBorder = ReadData("Введите минимальное значение: ");
int topBorder = ReadData("Введите максимальное значение: ");
int[] inputArray = FillArray(arrayLength, downBorder, topBorder);
Print1DArray(inputArray);
int evenSum = EvenSumPosition(inputArray);
PrintResult("Сумма нечетных числел массива: " + evenSum);



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

void SearchPair(int[] array, int arrayLength)//перебором массива ищем парные значения
{

    for (int i = 0; i < arrayLength-1;)
    {
        for (int j = i + 1; j < arrayLength;)
        {
            if (array[i] == array[j])
            {
                Console.WriteLine("Число " + array[i] + " имеет пару");
                i += 2;
                j += 2;
            }
            else
            {
                i++;
                j++;
            }
        }
    }

}

int[] array = BubbleSort(FillArray(arrayLength, downBorder, topBorder));
Print1DArray(array);
SearchPair(array,arrayLength);


