// --------------------------------------
// Напишите программу, которая выводит
// случайное трёхзначное число и удаляет
// вторую цифру этого числа
// --------------------------------------

void Variant1()
{
System.Random numberGenerator = new System.Random();

int number = numberGenerator.Next(100, 1000);//случайный набор трехзначного числа

Console.WriteLine(number);

int firstDigit = number / 100;
int thirdDigit = number % 10;

Console.WriteLine(firstDigit * 10 + thirdDigit);
}

void Variant2()
{
    Console.WriteLine("Вариант 1:");
  

    int number = new Random().Next(100, 1000);

    Console.WriteLine(number);

    char[] charArray = number.ToString().ToCharArray();

    Console.Write(charArray[0]);
    Console.WriteLine(charArray[2]);
}

void Variant3()
{
    Console.WriteLine("Метод 1");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(100, 1000);

    Console.WriteLine(number);

    char [] charArray = number.ToString().ToCharArray();

    Console.WriteLine("" + charArray[0] + charArray[2]);
}

Variant1();
Variant2();
Variant3();


