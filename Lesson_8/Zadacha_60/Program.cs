// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Вывод:
// a[0, 0, 0] = 2
// a[0, 0, 1] = 4

void FillArray(int[,,] array)
{
    var list = new List<int>();

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Boolean Proverka = true;
                int RandomNumber = 0;
                while (Proverka == true)
                {
                    RandomNumber = new Random().Next(10, 99);
                    //System.Console.WriteLine(RandomNumber);
                    if (list.Contains(RandomNumber) == false)
                    {
                        Proverka = false;
                    }
                }
                //System.Console.WriteLine(list[k]);
                array[i, j, k] = RandomNumber;
                list.Add(RandomNumber);
                System.Console.WriteLine($"{i},{j},{k}  =  {array[i, j, k]}");
            }
        }
    }
}

int[,,] array1 = new int[3, 3, 3];

FillArray(array1);

System.Console.WriteLine();