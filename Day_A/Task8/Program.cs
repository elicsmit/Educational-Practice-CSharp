using System;

class Program
{
    static void Main()
    {
        double x = -1.0;

        double innerArg = Math.Sqrt(Math.Exp(x) + 1);

        double atanSquared = Math.Pow(Math.Atan(innerArg), 2);

        double y = 7 * atanSquared + Math.Abs(x);

        Console.WriteLine($"При x = {x}");
        Console.WriteLine($"Значение функции y = {y:F4}");
    }
}
