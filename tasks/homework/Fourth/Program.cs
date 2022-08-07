// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

if (num > 0) 
{
    while (count != num+1) 
    {
        if (count % 2 == 0) 
        {
            Console.Write($"{count} ");
        }
        count++;
    }
}
else if (num < 0)
{
    Console.Write($"Число {num}, является отрицательным! Это создаст переполнение! Перезапустите программу и введите положительное число");
}
else if (num == 0) 
{
    Console.Write($"Введенное число равно 0!");   
}
