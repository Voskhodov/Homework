// Задача 47: Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Введите длину массива по X ");
string d = Console.ReadLine();
int x = Convert.ToInt32(d);

Console.Write("Введите длину массива по Y ");
string b = Console.ReadLine();
int y = Convert.ToInt32(b);

double[,] a = new double[x, y];
Random random = new Random();
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j <a.GetLength(1); j++)
    {
        a[i, j] = random.NextDouble()*(5-(-5))-5; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
                                                  //https://stackoverflow.com/questions/1064901/random-number-between-2-double-numbers
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}