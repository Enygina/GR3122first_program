// #2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);


    // if (inputNumberA > inputNumberB)
    // {
    //     Console.WriteLine("Большее число: " + inputNumberA);
    //     Console.WriteLine("Меньшее число: " + inputNumberB);
    // }
    // else
    // {
    //     Console.WriteLine("Большее число: " + inputNumberB);
    //     Console.WriteLine("Меньшее число: " + inputNumberA);
    // }

    {
        int maximumNumber = Math.Max(inputNumberA, inputNumberB);
        int minimumNumber = Math.Min(inputNumberA, inputNumberB);

        Console.WriteLine("Большее число: " + maximumNumber);
        Console.WriteLine("Меньшее число: " + minimumNumber);
    }
}