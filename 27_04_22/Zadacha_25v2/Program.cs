// Задача 25: Напишите (функцию) цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3 в 5 степени)
// 2, 4 -> 16

Console.Clear();

System.Console.WriteLine("Введите число ");
double x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите степень ");
double Stepen = Convert.ToInt32(Console.ReadLine());

Console.Clear();
double result = Math.Pow(x, Stepen);
System.Console.WriteLine($"{x} в {Stepen} степени = {result}");