// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void Sum(int[] array)
{
    int n1 = array.Length;
    int n2 = 0;

    for (int i = 0; i < n1; i++)
    {
        if (i % 2 != 0)
        {
            n2 = n2 + array[i];
        }
    }
    System.Console.WriteLine($"Сумма чисел в массиве на нечетных позициях ровна " + n2);
}

System.Console.Write("Введите длину массива ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];

Console.Clear();
Random(array);

System.Console.Write("Массив: ");
Print(array);

Sum(array);
System.Console.WriteLine();