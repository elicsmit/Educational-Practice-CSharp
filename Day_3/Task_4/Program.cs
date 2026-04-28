using System;
using Task_4;

class Program
{
    static void Main()
    {
        var menuItems = new Dish[]
        {
            new Dish("Стейк Рибай", "Горячие блюда", 1500, 350),
            new Dish("Тирамису", "Десерты", 450, 150),
            new Dish("Борщ", "Супы", 380, 400),
            new Dish("Чизкейк", "Десерты", 400, 120)
        };

        var myRestaurant = new Restaurant(menuItems);

        var expensive = myRestaurant.GetMostExpensiveDish();
        Console.WriteLine($"Самое дорогое блюдо: {expensive.Name} за {expensive.Price}р.");

        var desserts = myRestaurant.GetDishesByCategory("Десерты");
        Console.WriteLine("\nСписок десертов:");
        foreach (var d in desserts)
        {
            d.DisplayInfo(); 
        }
    }
}
