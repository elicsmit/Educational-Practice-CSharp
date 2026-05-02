using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int d1 = number / 1000;         
        int d2 = (number / 100) % 10;   
        int d3 = (number / 10) % 10;     
        int d4 = number % 10;           

        int reversed = d4 * 1000 + d3 * 100 + d2 * 10 + d1;

        Console.WriteLine($"Число справа налево: {reversed:D4}");
    }
}
