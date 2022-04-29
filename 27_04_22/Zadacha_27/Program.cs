// Задача 27: Напишите функцию, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



Console.Clear();
void Print(int sum)
{
    int i = 0;
    int y = sum;
    while (sum !=0)
        {
            i = i + (sum % 10);
            sum = sum / 10;

        }
    System.Console.WriteLine($"Сумма всех цифер в числе {y} равна {i}");
}

System.Console.Write("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Print(x);