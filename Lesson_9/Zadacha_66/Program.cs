// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите число m: ");
int n = Convert.ToInt32(Console.ReadLine());
int d = 0;

void PrintSumNums(int max)
{
    if (max < 0) max = max * -1;
    if (max > 0)
    {
        d = d + max % 10;
        max = max / 10;
        PrintSumNums(max);
    }
}
PrintSumNums(n, m);

Console.WriteLine($"Сумма чисел ровна {x}");