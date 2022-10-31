// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.Console.WriteLine("введите количество столбцов");



Console.Write("введете количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.Write("введете количество колонок ");
int columns = int.Parse(Console.ReadLine());

int[,] arr = new int[rows, columns];
FillArrayRandomNumbers(arr);
PrintArray(arr);


for (int j = 0; j < arr.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        avarage = (avarage + arr[i, j]);
    }
    avarage = avarage / rows;
    double res = Math.Round(avarage, 1);
    Console.Write(res + " ; ");
}
Console.WriteLine($" -cреднее арифметическое каждого столбца");


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





