//===========================================
// # 7 Напишите программу, которая принимает на вход
//трёхзначное число и на выходе
//показывает последнюю цифру этого числа.
//===========================================
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber3Digit = int.Parse(inputLine);
    if (inputNumber3Digit > 99&&inputNumber3Digit<1000)
    {
            int lastDigit = inputNumber3Digit%10;

            Console.Write(lastDigit);
    }
}
