using System;
using System.Linq;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        string result = string.Concat(input
            .ToLower()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(word => char.ToUpper(word[0]) + word.Substring(1)));

        Console.WriteLine("Результат в CamelCase:");
        Console.WriteLine(result);
    }
}
