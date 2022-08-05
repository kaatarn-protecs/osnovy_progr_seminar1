// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


Console.Write("Введите число: ");
int numweek = Convert.ToInt32(Console.ReadLine());

if (numweek > 0)
{
    if (numweek == 1) 
    {
        Console.Write("Выбранный день недели - Понедельник");
    }
    else if (numweek == 2) 
    {
        Console.Write("Выбранный день недели - Вторник");
    }
    else if (numweek == 3) 
    {
        Console.Write("Выбранный день недели - Среда");
    }
    else if (numweek == 4) 
    {
        Console.Write("Выбранный день недели - Четверг");
    }
    else if (numweek == 5) 
    {
        Console.Write("Выбранный день недели - Пятница");
    }
    else if (numweek == 6) 
    {
        Console.Write("Выбранный день недели - Суббота");
    }
    else if (numweek == 7) 
    {
        Console.Write("Выбранный день недели - Воскресенье");
    }
    else
    {
        Console.Write("Вы ввели некорректное число!");
    }
}
else
{
    Console.Write("Вы ввели некорректное число!");
}
