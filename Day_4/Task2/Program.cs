using System;
using System.Collections.Generic; // Для работы с HashSet или List
using System.Linq; // Для простого способа через Distinct()

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 2, 3, 4, 4, 5, 1 };

        // Вызываем метод так, будто он принадлежит самому массиву
        int[] uniqueNumbers = numbers.GetUnique();

        Console.WriteLine("Уникальные элементы:");
        Console.WriteLine(string.Join(", ", uniqueNumbers));
    }
}
