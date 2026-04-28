using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        string result = string.Join(" ", input.Split(' ')
            .Select(word => new string(word.Reverse().ToArray())));

        Console.WriteLine("Результат:");
        Console.WriteLine(result);
    }
}
