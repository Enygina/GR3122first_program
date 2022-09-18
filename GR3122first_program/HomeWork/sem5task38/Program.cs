/*№38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
минимальным элементов массива.
[3 7 22 2 78] -> 76
[2 0,4 9 7,2 78] -> 77,6
* Отсортируйте массив методом вставки и методом подсчета, а затем найдите
разницу между первым и последним элементом. Для задачи со звездочкой
использовать заполнение массива целыми числами.*/

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

double[] RealNumFillArray(int arrayLen, int downBorder, int topBorder)//Заполнение массива вещественными числами
{
    double[] arr = new double[arrayLen];
    Random random = new Random();
    for (int i = 0; i < arrayLen; i++)
    {
        arr[i] = random.NextDouble() * random.Next(downBorder, topBorder + 1);

    }
    return arr;
}

void Print1DArray(double[] array)//печать массива
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write((array[i]) + ",");
    }
    Console.WriteLine((array[array.Length - 1]));
}

double MinMaxDifference(double[] array)//разница между максимальным и минимальным значением
{
    double min = double.MaxValue;
    double max = double.MinValue;
    foreach (double i in array)  // Поиск максимального и минимального значения
    {
        if (min > i) min = i;
        if (max < i) max = i;
    }
    Console.WriteLine("Минимальное значение: " + min);
    Console.WriteLine("Максимальное значение: " + max);
    double dif = max - min;
    return dif;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrayLength = ReadData("Введите длину массива");
int downBorder = ReadData("Введите минимальное значение: ");
int topBorder = ReadData("Введите максимальное значение: ");
double[] inputRealArray = RealNumFillArray(arrayLength, downBorder, topBorder);
Print1DArray(inputRealArray);
PrintResult("Разница между иаксимальным и минимальным значением: " + MinMaxDifference(inputRealArray));




// Универсальный метод генерации и заполнение массива целыми числами
int[] FillArray(int arrayLength, int topBorder, int downBorder)
{
    Random rand = new Random();
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(topBorder, downBorder + 1);
    }
    return array;
}

void Swap(int[] array, int i, int j)//меняем местами значения через temp
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

int[] InsertSortArr(int[] array)//Сортировка методом вставки
{
    int x;
    int j;
    for (int i = 1; i < array.Length; i++)
    {
        x = array[i];
        j = i;
        while (j > 0 && array[j - 1] > x)
        {
            Swap(array, j, j - 1);
            j -= 1;
        }
        array[j] = x;
    }
    return array;
}

// сортировка подсчётом
void СountingSort(int[] arr, int min, int max)
{
    int[] count = new int[max - min + 1];
    int z = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        count[arr[i] - min]++;
    }
    for (int i = min; i <= max; i++)
    {
        while (count[i - min]-- > 0)
        {
            arr[z] = i;
            z++;
        }
    }
}


int FirstLastDigitDiff(int[] array)//поиск разница первого и последнего элемента массива
{
    int n = array.Length - 1;
    int i = 0;
    int dif = array[n] - array[i];
    return dif;
}


int[] inputArray = FillArray(arrayLength, downBorder, topBorder);
DateTime d1 = DateTime.Now;
InsertSortArr(inputArray);
Console.WriteLine(DateTime.Now - d1);
double[] doubleArray = Array.ConvertAll(inputArray, i => (double)i);
Print1DArray(doubleArray);
DateTime d2 = DateTime.Now;
СountingSort(inputArray,downBorder, topBorder);
Console.WriteLine(DateTime.Now - d2);
Print1DArray(doubleArray);
PrintResult("Разница между первым и последним элементом массива: " + FirstLastDigitDiff(inputArray));

