using Task_3;

class Program
{
    static void Main()
    {
        var athletes = new Athlete[]
        {
                new Runner("Иван Иванов", 22, 5, 30.5),
                new Swimmer("Мария Сидорова", 20, 8, "Баттерфляй"),
                new Runner("Алексей Петров", 25, 3, 28.0),
                new Swimmer("Елена Волкова", 19, 12, "Кроль")
        };

        var club = new SportsClub(athletes);

        var star = club.GetMostAwardedAthlete();
        Console.WriteLine($"Самый титулованный: {star?.Name} ({star?.Medals} медалей)");

        var swimmers = club.GetAthletesBySport("Плавание");
        Console.WriteLine($"\nСпортсменов в категории 'Плавание': {swimmers.Count}");
        foreach (var s in swimmers) Console.WriteLine($"- {s.Name}");
    }
}
