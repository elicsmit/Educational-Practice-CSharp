using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Яблоко;Банан;Груша;Апельсин");

        char separator = ';'; 

        string[] parts = sb.ToString().Split(separator);

        Console.WriteLine("Разделенные строки:");
        foreach (string part in parts)
        {
            Console.WriteLine(part);
        }
    }
}
