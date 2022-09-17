//===========================================
// # 8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//===========================================
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber > 0)
    {
        int startNamber = 2;

        while (startNamber < inputNumber -(1))
        {
            Console.Write(startNamber + ", ");
            startNamber = startNamber + 2;
        }
        Console.Write(startNamber);
    }
}