// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76

Console.Clear();
void Random(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-99, 99);
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

void Subtraction(int[] array)
{
    int n1 = array.Length;
    int max = array[0];
    int min = array[0];
    int sub;

    for (int i = 0; i < n1; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    sub = max - min;
    System.Console.Write($"Минимальное число в массиве {min}");
    System.Console.WriteLine();
    System.Console.Write($"Максимальное число в массиве {max}");
    System.Console.WriteLine();
    System.Console.Write($"Разница между максимальным и минимальным числом в массиве равна {sub}");
}

System.Console.Write("Введите длину массива ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];

Console.Clear();
Random(array);

System.Console.Write("Массив: ");
Print(array);

Subtraction(array);
System.Console.WriteLine();