using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение a: ");
        if (double.TryParse(Console.ReadLine(), out double a))
        {
 
            if (a == 0 || a == 2 || a == -2)
            {
                Console.WriteLine("Ошибка: при данном 'a' происходит деление на ноль.");
                return;
            }

            double part1 = (1 + a + Math.Pow(a, 2)) / (2 * a + Math.Pow(a, 2));
            double part2 = (1 - a + Math.Pow(a, 2)) / (2 * a - Math.Pow(a, 2));

            double bracket = part1 + 2 - part2;
            double z1 = Math.Pow(bracket, -1) * (5 - 2 * Math.Pow(a, 2));

            double z2 = (4 - Math.Pow(a, 2)) / 2;

            Console.WriteLine($"\nРезультаты ");
            Console.WriteLine($"z1 = {z1:F4}");
            Console.WriteLine($"z2 = {z2:F4}");
        }
        else
        {
            Console.WriteLine("Ошибка: введено не число.");
        }
    }
}
