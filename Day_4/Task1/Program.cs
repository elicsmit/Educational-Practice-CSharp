using System;

class Program
{
    
    public static int FindIndex(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target) return i; 
        }
        return -1; 
    }

    static void Main()
    {
        int[] numbers = { 10, 25, 30, 45, 50 };
        int target = 30;

        int index = FindIndex(numbers, target);

        Console.WriteLine(index != -1
            ? $"Элемент найден на индексе: {index}"
            : "Элемент не найден");
    }
}
