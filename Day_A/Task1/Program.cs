using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Вычисление объема цилиндра.");
        Console.WriteLine("Введите исходные данные:");

        Console.Write("Радиус основания (см) = ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Высота цилиндра (см) = ");
        double h = Convert.ToDouble(Console.ReadLine());

        double volume = Math.PI * Math.Pow(r, 2) * h;

        Console.WriteLine($"Объем цилиндра: {volume:F2} куб. см.");
    }
}
