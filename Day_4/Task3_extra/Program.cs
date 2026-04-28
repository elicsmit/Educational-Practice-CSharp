using System;

class Program
{
    static void Main()
    {
        double salesAmount = 1000.0;

        double regularComm = CalculateCommission(salesAmount);
        Console.WriteLine($"Комиссия (обычная): {regularComm}"); 

        double vipComm = CalculateCommission(salesAmount, true);
        Console.WriteLine($"Комиссия (VIP): {vipComm}"); 
    }

    static double CalculateCommission(double sales)
    {
        return sales * 0.10;
    }

    static double CalculateCommission(double sales, bool isVIP)
    {
        if (isVIP)
        {
            return sales * 0.15;
        }
        return CalculateCommission(sales);
    }
}
