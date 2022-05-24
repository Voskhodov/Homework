// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
void FillArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = new Random().Next(1, 100);
        }
    }

}

void PrintArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            System.Console.Write($"{array1[i, j],4}");
        }
        System.Console.WriteLine();
    }
}

void FillArray2(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray2(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            System.Console.Write($"{array2[i, j],4}");
        }
        System.Console.WriteLine();
    }
}

void SummaMarixs(int[,] array3)
{
    int[,] con3 = new int[3, 3];
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            array3[i, j] += array1[i, j] * array2[j, i];
        }
    }
}

int[,] array1 = new int[3, 3];
int[,] array2 = new int[3, 3];
int[,] array3 = new int[3, 3];

FillArray(array1);
PrintArray(array1);
FillArray2(array2);
PrintArray2(array2);
SummaMarixs(array3);