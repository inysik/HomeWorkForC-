// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("введите число n: ");
int n = int.Parse(Console.ReadLine());
int n1 = n / 10000;
int n2 = (n / 1000) % 10;
int n4 = (n / 10) % 10;
int n5 = n % 10;
if (n1 == n5 && n2 == n4)
{
    Console.WriteLine($"число {n} - является палидромом ");
}
else
{
    Console.WriteLine($"число {n} - не  является палидромом ");
}