using System;
using System.Collections.Generic;
using System.Linq;

public delegate List<int> ListProcessor(List<int> numbers);

class Program
{
    static void Main()
    {
        List<int> myNumbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        FilterEvenNumbers filterer = new FilterEvenNumbers();
        MultiplyByTwo multiplier = new MultiplyByTwo();

        ListProcessor processor;

        processor = filterer.Process;
        List<int> evenNumbers = processor(myNumbers);
        Console.WriteLine("Четные числа: " + string.Join(", ", evenNumbers));

        processor = multiplier.Process;
        List<int> multipliedNumbers = processor(myNumbers);
        Console.WriteLine("Умноженные на 2: " + string.Join(", ", multipliedNumbers));
    }
}
