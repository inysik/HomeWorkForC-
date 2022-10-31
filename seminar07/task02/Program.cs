// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7]->такого числа в массиве нет ([1,7] это позиция элемента)

Console.Write("введете количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.Write("введете количество колонок ");
int columns = int.Parse(Console.ReadLine());

int[,] arr = new int[rows, columns];
FillArrayRandomNumbers(arr);
PrintArray(arr);

int[,] numbers = new int[10, 10];
FillArrayRandomNumbers(numbers);

if (rows > numbers.GetLength(0) || columns > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {rows} строки и {columns} столбца равно {numbers[rows - 1, columns - 1]}");
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
