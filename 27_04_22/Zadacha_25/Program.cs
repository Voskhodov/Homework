// Задача 25: Напишите (функцию) цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3 в 5 степени)
// 2, 4 -> 16

Console.Clear();

System.Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
int result = x;
System.Console.WriteLine("Введите степень ");
int Stepen = Convert.ToInt32(Console.ReadLine());

Console.Clear();
for (int i = 2; i <= Stepen; i++)
{
    result *=x;
}
System.Console.WriteLine($"{x} в степени {Stepen} = {result}");