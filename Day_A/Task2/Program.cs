using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите трёхзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int digit1 = number / 100;         
        int digit2 = (number / 10) % 10;   
        int digit3 = number % 10;       

        int product = digit1 * digit2 * digit3;

        Console.WriteLine($"Произведение цифр числа {number}: {product}");
    }
}
