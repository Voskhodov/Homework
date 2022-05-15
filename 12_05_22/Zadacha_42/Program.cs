// Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями: 
// y = k1 * x + b1, 
// y = k2 * x + b2; 

// значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5, b1 = 2, k2 = 9, b2 = 4,  -> (-0,5; -0,5)


Console.Clear();
System.Console.Write("Введите k1 ");
string buf;
buf = Console.ReadLine();
double k1 = float.Parse(buf);

System.Console.Write("Введите k2 ");
buf = Console.ReadLine();
double k2 = float.Parse(buf);

System.Console.Write("Введите b1 ");
buf = Console.ReadLine();
double b1 = float.Parse(buf);

System.Console.Write("Введите b2 ");
buf = Console.ReadLine();
double b2 = float.Parse(buf);

double x = (b1 - b2) / (k2 - k1);
double y = k1 * x + b1;

Console.Clear();
System.Console.Write($"Координаты пересечения " + x + ";" + y);