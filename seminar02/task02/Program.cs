﻿
// Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("введите 3х значное число: ");
int n = int.Parse(Console.ReadLine());


if (n < 100)
    Console.WriteLine("третьего числа не существует");
else
{
    Console.WriteLine(n.ToString()[2]);

}