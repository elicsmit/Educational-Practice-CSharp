using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите часы (H): ");
        int h = int.Parse(Console.ReadLine());
        Console.Write("Введите минуты (M): ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите секунды (S): ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("На сколько секунд уменьшить (T): ");
        int t = int.Parse(Console.ReadLine());

        DecTime(ref h, ref m, ref s, t);

        Console.WriteLine($"\nНовое время: {h:D2}:{m:D2}:{s:D2}");
    }

    static void DecTime(ref int h, ref int m, ref int s, int t)
    {
        long totalSeconds = (long)h * 3600 + m * 60 + s;

        totalSeconds -= t;

        if (totalSeconds < 0) totalSeconds = 0;

        h = (int)(totalSeconds / 3600);
        m = (int)((totalSeconds % 3600) / 60);
        s = (int)(totalSeconds % 60);
    }
}
