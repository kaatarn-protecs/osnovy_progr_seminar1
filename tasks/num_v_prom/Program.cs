
// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
// Итерация №2
// Решение в группах задач: 20 мин
// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = -num;

while (count <= num) 
{
    Console.Write($"{count}, ");
    count++;
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


