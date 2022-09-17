//===========================================
// # 5 Напишите программу, которая на вход принимает
//одно число (N), а на выходе показывает все целые
//числа в промежутке от -N до N.
//===========================================
string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);
    if (inputNumberN > 0)
    {
        int startNamber = (-1) * inputNumberN;

        while (startNamber < inputNumberN)
        {
            Console.Write(startNamber + ", ");
            startNamber = startNamber + 1;
        }
        Console.Write(startNamber);
    }
}
