// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Clear();

void ArrayNumb(int[] mas)
{
    int k = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Clear();
        Console.Write($"Введите число " + (i) + ": ");
        mas[i] = Convert.ToInt32(Console.ReadLine());
        if (mas[i] > 0)
        {
            k++;
        }
    }
    System.Console.WriteLine($"Количество введенных положительных чисел: " + k);
}

void Print(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write(mas[i] + " ");
    }
    Console.WriteLine();
}


System.Console.Write("Введите количество чисел ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];

Console.Clear();
ArrayNumb(array);

System.Console.WriteLine($"Массив:");
Print(array);