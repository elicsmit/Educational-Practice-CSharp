using System;
using System.Collections.Generic; 
using System.Linq; 

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 2, 3, 4, 4, 5, 1 };

        int[] uniqueNumbers = numbers.GetUnique();

        Console.WriteLine("Уникальные элементы:");
        Console.WriteLine(string.Join(", ", uniqueNumbers));
    }
}
