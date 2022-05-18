// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите координату по X ");
string d = Console.ReadLine();
int x = Convert.ToInt32(d);

Console.Write("Введите координату по Y ");
string b = Console.ReadLine();
int y = Convert.ToInt32(b);

double[,] a = new double[5, 10];
Random random = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        a[i, j] = random.NextDouble()*(5-(-5))-5; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
                                                  //https://stackoverflow.com/questions/1064901/random-number-between-2-double-numbers
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}
