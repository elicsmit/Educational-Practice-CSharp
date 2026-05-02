using System;

class Program
{
    static void Main()
    {
        double x = 1.0;

        double numerator = Math.Sqrt(Math.Abs(1 - Math.Pow(Math.Sin(x), 2)));

        double denominator = Math.Cos(2 * Math.PI / 3);

        double exponent = Math.Exp(4 * Math.Sqrt(x));

        double y = Math.Pow(x, 2) - (numerator / denominator) * exponent;

        Console.WriteLine($"При x = {x}");
        Console.WriteLine($"Значение функции y = {y:F4}");
    }
}
