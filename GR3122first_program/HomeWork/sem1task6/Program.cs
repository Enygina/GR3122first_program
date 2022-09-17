//===========================================
// # 6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//===========================================
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    // int result = inputNumber%2;

    // if (result==0)
    // {
    //     Console.Write(inputNumber + " это четное число");
    // }
    // else
    // {
    //     Console.Write(inputNumber + " это нечетное число");
    // }


    if ((inputNumber / 2) * 2 == inputNumber)
    {
        Console.Write(inputNumber + " это четное число");
    }
    else
    {
        Console.Write(inputNumber + " это нечетное число");
    }

}

