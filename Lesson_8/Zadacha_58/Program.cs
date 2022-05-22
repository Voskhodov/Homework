int CheckSpecialNumber(int[,,] array, int minValue, int maxValue)
{
    int number = new Random().Next(minValue, maxValue);
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                if (array[a, b, c] == number)
                    number = CheckSpecialNumber(array, minValue, maxValue);
            }
        }
    }
    return number;
}
