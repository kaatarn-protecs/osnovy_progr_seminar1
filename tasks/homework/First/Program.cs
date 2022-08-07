// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > b) 
{
    Console.Write($"Максимальное число = {max}");
}
else
{
    max = b;
    Console.Write($"Максимальное число = {max}");    
}

// Console.WriteLine("Введите трехзначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a >= 100 && a < 1000)
// {
//     Console.WriteLine($"Последняя цифра числа {a}={a % 10}");
// }
// else
//     Console.WriteLine("Вы ввели не трезхначное число, повторите попытку");

// int a;
// do
// {
//     Console.WriteLine("Введите трехзначное число: ");
//     a = Convert.ToInt32(Console.ReadLine());
// } while (a <= 99 || a > 999);
// Console.WriteLine($"Последняя цифра числа {a}={a % 10}");


