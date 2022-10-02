// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.Write(" Введите число a = ");
int a = int.Parse(Console.ReadLine());
Console.Write(" Введите число b = ");
int b = int.Parse(Console.ReadLine());

// int a = 5; int b = 6;
if (b > a)
    Console.WriteLine($"{b} больше, а {a} меньше");
else
    Console.WriteLine($"{a} больше, а {b} меньше");