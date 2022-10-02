// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.


Console.Write(" Введите число a = ");
int a = int.Parse(Console.ReadLine());
Console.Write(" Введите число b = ");
int b = int.Parse(Console.ReadLine());
Console.Write(" Введите число v = ");
int v = int.Parse(Console.ReadLine());


int x = Math.Max(a, Math.Max(b, v));

Console.Write($"максимальное число {x}");