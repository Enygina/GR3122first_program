//===========================================
// # 1 Напишите программу, которая на вход принимает
//два числа и проверяет, является ли первое число
//квадратом второго.
//===========================================
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    //bool outResult = (inputNumberB * inputNumberB == inputNumberA);
    //bool outResult = (inputNumberA/inputNumberA == inputNumberB);
    bool outResult = (Math.Sqrt(inputNumberA) == inputNumberB);

    Console.WriteLine(outResult);
}

