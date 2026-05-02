using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        var culture = new CultureInfo("ru-RU");

        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine().Replace('.', ','), culture);

        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine().Replace('.', ','), culture);

        if (a != 0)
        {
            double result = b / a;

            Console.WriteLine($"{b:F2}/{a:F3}={result:F2}", culture);
        }
        else
        {
            Console.WriteLine("Ошибка: деление на ноль.");
        }

        Console.WriteLine("Для продолжения нажмите любую клавишу . . .");
        Console.ReadKey();
    }
}
