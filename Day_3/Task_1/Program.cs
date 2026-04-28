using System;

class A
{
    public int a;
    public int b;

    public A(int valA, int valB)
    {
        a = valA;
        b = valB;
    }
    public double CalculateExpression()
    {
        return a * Math.Sqrt(b) - Math.Sin(a);
    }

    public double CubeOfProduct()
    {
        return Math.Pow(a * b, 3);
    }
}

class Program
{
    static void Main()
    {
        A obj = new A(2, 9);

        Console.WriteLine($"Поля класса: a = {obj.a}, b = {obj.b}");
        Console.WriteLine($"Результат выражения a*sqrt(b) - sin(a): {obj.CalculateExpression():F4}");
        Console.WriteLine($"Куб произведения a и b: {obj.CubeOfProduct()}");
    }
}
