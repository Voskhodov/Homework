// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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

int[,] MultMarixs(int[,] array1, int[,] array2)
{
    int[,] array3;
    if (array1.GetLength(1) != array2.GetLength(0))
        return null;
    array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
}

int[,] array1 = new int[10, 2];
int[,] array2 = new int[2, 10];
int[,] array3;

FillArray(array1);
PrintArray(array1);
System.Console.WriteLine();
FillArray(array2);
PrintArray(array2);
System.Console.WriteLine();
array3 = MultMarixs(array1, array2);
PrintArray(array3);

