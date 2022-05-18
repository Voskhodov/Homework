// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j], 4}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
void AverageNumber(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        float summa = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            summa += array[i, j];
        System.Console.Write($"Столбик № {j} ср={summa / array.GetLength(0), 4}| ");
    }
    System.Console.WriteLine();
}
Console.Clear();

int[,] Array = new int[4, 6];
FillArray(Array, -10, 10);
PrintArray(Array);
AverageNumber(Array);
