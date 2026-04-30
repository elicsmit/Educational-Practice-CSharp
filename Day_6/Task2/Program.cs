using System;
using System.Collections.Generic;
using System.Linq;

public delegate bool TextFilter(string text);

class Program
{
    public static void FilterText(string[] lines, TextFilter filter, string label)
    {
        Console.WriteLine($"{label}");
        foreach (var line in lines)
        {
            if (filter(line))
            {
                Console.WriteLine($"Подходит: {line}");
            }
        }
        Console.WriteLine();
    }

    public static bool ContainsDigit(string text)
    {
        return text.Any(char.IsDigit);
    }

    public static bool ContainsSpecialCharacters(string text)
    {
        return text.Any(ch => !char.IsLetterOrDigit(ch));
    }

    static void Main()
    {
        string[] data = { "Apple", "User123", "Hello!", "Admin", "Pass#1" };

        FilterText(data, ContainsDigit, "Строки с цифрами");

        FilterText(data, ContainsSpecialCharacters, "Строки со спецсимволами");
    }
}
