using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4 };

        int total = ArraySum(numbers, 0);

        Console.WriteLine($"Сумма элементов массива: {total}");
    }

    static int ArraySum(int[] array, int index)
    {
        if (index >= array.Length)
        {
            return 0;
        }

        return array[index] + ArraySum(array, index + 1);
    }
}
