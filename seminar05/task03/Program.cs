// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
internal class Program
{
    private static void Main(string[] args)
    {
        float[] GetArr(int size, int minValue, int maxValue)
        {
            // int[] res = new int[size];
            float[] res = new float[size];
            int i;
            for (i = 0; i < size; i++)


            {

                res[i] = new Random().Next(minValue, maxValue);
                Console.Write($"{res[i]} ");


            }
            return res;

        }
        float[] res = GetArr(12, 0, 100);
        float minV = res[0];
        for (int i = 1; i < res.Length; i++)
        {
            if (res[i] < minV)
            {
                minV = res[i];
            }
        }

        float maxV = res[1];
        for (int i = 0; i < res.Length; i++)
        {
            if (res[i] > maxV)
            {
                maxV = res[i];
            }
        }

        Console.Write($"в массиве {res},разница между {minV} и {maxV} cоставляет {maxV - minV} ");
    }
}