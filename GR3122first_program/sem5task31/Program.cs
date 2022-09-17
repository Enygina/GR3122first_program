/*Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных
элементов массива.*/


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
            array[i] = numSintezator.Next(downBorder, topBorder+1);
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

int[] NegotivPositivSum(int[] arr)
{
    int[] sums = new int[2];
    for (int i= 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sums[0] += arr[i];
        }
        else
        {
            sums[1] += arr[i];
        }
    }
    return sums;
}
void PrintResult(string line)
{
    Console.WriteLine(line);
}
int arrayLength = ReadData("Введите длину массива");
int downBorder = ReadData("Введите нижнюю границу заполнения массива");
int topBorder = ReadData("Введите верхнюю границу заполнения массива");
int[] inputArray = FillArray(arrayLength, downBorder, topBorder);
Print1DArray(inputArray);
int []sumArray=NegotivPositivSum(inputArray);
PrintResult("Сумма > 0: " + sumArray[0] + " Сумма < 0: " + sumArray[1]);
Print1DArray(sumArray);



string RandowArr(int lng, int from, int to)
{
  int[] array = new int[lng];
  Random rnd = new Random();

  int sunNeg =0;
  int sunPos =0;
  for(int i = 0; i < lng; i++)
  {
    array[i] = rnd.Next(from, to+1);
    if(array[i]>0)sunPos+=array[i];
    else sunNeg+=array[i];
  }

  return (string.Join(", ", array)+"\n "+sunPos+" "+sunNeg);
}

Console.Write(RandowArr(12,-9,9));