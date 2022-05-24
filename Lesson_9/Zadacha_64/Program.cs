// Задача 64: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.Write("Введите число m: ");
int n = Convert.ToInt32(Console.ReadLine());
int x = 0;

void PrintSumNums(int max)
{
    if (max < 0) max = max * -1;
    if (max > 0)
    {
        x = x + max % 10;
        max = max / 10;
        PrintSumNums(max);
    }


}
PrintSumNums(n);

Console.WriteLine($"Сумма чисел ровна {x}");