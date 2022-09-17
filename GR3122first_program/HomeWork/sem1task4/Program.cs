// #4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();
if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);

    // if (inputNumberA > inputNumberB)
    // {
    //     if (inputNumberA > inputNumberC)
    //     {
    //         Console.WriteLine("Максимальное число: " + inputNumberA);
    //     }
    //     else
    //     {
    //         Console.WriteLine("Максимальное число: " + inputNumberC);
    //     }
    // }
    // else
    // {
    //     if (inputNumberB > inputNumberC)
    //     {
    //         Console.WriteLine("Максимальное число: " + inputNumberB);
    //     }
    //     else
    //     {
    //         Console.WriteLine("Максимальное число: " + inputNumberC);
    //     }
    // }


// {
//     int maximumNumber = Math.Max(inputNumberA, Math.Max(inputNumberB, inputNumberC));
    
//     Console.WriteLine("Максимальное число: " + maximumNumber);
// }




    // int maximumNumber = inputNumberB>inputNumberA ? inputNumberB : inputNumberA ;
    // maximumNumber = maximumNumber>inputNumberC ? maximumNumber:inputNumberC;

    // Console.WriteLine("Максимальное число: " + maximumNumber);

    int maximumNumber= new[] {inputNumberA, inputNumberB, inputNumberC}.Max();
    
    Console.WriteLine("Максимальное число: " + maximumNumber);
}








