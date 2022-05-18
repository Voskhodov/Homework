// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

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
            System.Console.Write($"{array[i, j],4}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

Console.Clear();
Console.Write("Введите координату по X ");
string d = Console.ReadLine();
int x = Convert.ToInt32(d);

Console.Write("Введите координату по Y ");
string b = Console.ReadLine();
int y = Convert.ToInt32(b);

int[,] Array = new int[4, 6];
FillArray(Array, -10, 10);
PrintArray(Array);
if (x < 4 || y < 6)
{
    System.Console.WriteLine(Array[x, y]);
}
System.Console.WriteLine("такого числа в массиве нет");