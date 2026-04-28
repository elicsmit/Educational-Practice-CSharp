using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "<div>Привет! Это <b class='bold'>жирный текст</b> и <a href='#'>ссылка</a>.</div>";

        string pattern = @"<[^>]+>";

        Console.WriteLine("Найденные теги:");

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
