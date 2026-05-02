using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Расчет параметров цилиндра ");

        Console.Write("Введите радиус основания (r): ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите высоту (h): ");
        double h = Convert.ToDouble(Console.ReadLine());

        double volume = Math.PI * Math.Pow(r, 2) * h;
        double area = 2 * Math.PI * r * (r + h);

        Console.WriteLine("\nРезультаты ");
        Console.WriteLine($"Объем цилиндра (V): {volume:F2}");
        Console.WriteLine($"Площадь поверхности (S): {area:F2}");

        Console.ReadKey();
    }
}
