// Задача 29: Напишите программу, которая задаёт массив из некоторого количества 
// элементов и выводит их на экран с помощью функций. (можно спрашивать количество 
// вводимых элементов и вводить все значения с клавиатуры)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



Console.Clear();
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

System.Console.Write("Введите размер массива ");
int x = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[x];
for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write("Введите число для массива ");
    int xmass = Convert.ToInt32(Console.ReadLine());
    arr[i] = xmass;                                         //запись введенного числа в ячейку массива
}
Console.Clear();
Print(arr);                                                 // вывод результата
