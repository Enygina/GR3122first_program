//===========================================
// # 3 Напишите программу, которая будет выдавать
//название дня недели по заданному номеру
//===========================================
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);

    // string[] dayOfWeek = new string[7];
    // dayOfWeek[0] = "Понедельник";
    // dayOfWeek[1] = "Вторник";
    // dayOfWeek[2] = "Среда";
    // dayOfWeek[3] = "Четверг";
    // dayOfWeek[4] = "Пятница";
    // dayOfWeek[5] = "Суббота";
    // dayOfWeek[6] = "Воскресенье";

    // if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    // {
    //     Console.WriteLine("Такого дня нет");
    // }
    // else
    // {
    //     Console.WriteLine(dayOfWeek[inputDayOfWeek - 1]);
    // }

    string outdayOfWeek = string.Empty;//""

    switch (inputDayOfWeek)
    {
        case  1: outdayOfWeek="Понедельник";    break;
        case 2: outdayOfWeek="Вторник";    break;
        case 3: outdayOfWeek="Среда";    break;
        case 4: outdayOfWeek="Четверг";    break;
        case 5: outdayOfWeek="Пятница";    break;
        case 6: outdayOfWeek="Суббота";    break;
        case 7: outdayOfWeek="Воскресенье";    break;
        default: outdayOfWeek="Такого дня нет";    break;
    }
    Console.WriteLine(outdayOfWeek);
}

