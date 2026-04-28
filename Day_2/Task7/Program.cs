using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        string result = new string(input.Where(c => !char.IsDigit(c)).ToArray());

        Console.WriteLine("Результат без цифр:");
        Console.WriteLine(result);
    }
}
