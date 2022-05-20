// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 9 9 9
// 1 1 1
// 5 6 7
// -> вторая строка

Console.Clear();
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],4}");
        }
        System.Console.WriteLine();
    }
}
void SummaRow(int[,] ArraySummaRow)
{
    int indexMinRow = 0;
    int MinRow = 0;
    for (int a = 0; a < ArraySummaRow.GetLength(0); a++)
    {
        for (int b = 0; b < ArraySummaRow.GetLength(1); b++)
        {
            MinRow += ArraySummaRow[a, b];
        }
    }
    int z = 0;
    for (int i = 0; i < ArraySummaRow.GetLength(0); i++)
    {
        for (int j = 0; j < ArraySummaRow.GetLength(1); j++)
        {
            indexMinRow += ArraySummaRow[i, j];
        }
        if (MinRow > indexMinRow)
        {
            MinRow = indexMinRow;
            z = i;

        }
        indexMinRow = 0;
    }
    System.Console.WriteLine($"В стороке №  {z + 1} минимальная сумма");
}

int[,] array1 = new int[3, 3];

FillArray(array1);
PrintArray(array1);
SummaRow(array1);