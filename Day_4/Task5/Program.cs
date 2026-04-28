using Task5;

class Program
{
    static void Main()
    {
        Book myNovel = new Novel("Преступление и наказание", "Ф. Достоевский");
        Book myTextbook = new Textbook("Алгебра 9 класс", "Ю. Макарычев", "Математика");

        myNovel.DisplayInfo();
        myNovel.Read();

        Console.WriteLine();

        myTextbook.DisplayInfo();
        myTextbook.Read();
    }
}