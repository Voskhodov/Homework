// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
void Random(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(100, 999);
    }
}

void Print(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write(mas[i] + " ");
    }
    Console.WriteLine();
}

void Quantity(int[] array)
{
    int n1 = array.Length;
    int n2 = 0;

    for (int i = 0; i < n1; i++)
    {
        if (array[i] % 2 == 0)
        {
            n2 = n2 + 1;
        }
    }
    System.Console.WriteLine($"Четных чисел в массиве  " + n2);
}

System.Console.Write("Введите длину массива ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];

Console.Clear();
Random(array);

System.Console.WriteLine($"Массив:");
Print(array);

Quantity(array);