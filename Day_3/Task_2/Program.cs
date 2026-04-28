using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }

    public override string ToString() => $"{Name} ({Age} лет) - Зарплата: {Salary:C}";
}

public static class EmployeeAnalytics
{
    public static Employee FindOldestEmployee(Employee[] employees)
    {
        if (employees == null || employees.Length == 0) return null;

        Employee oldest = employees[0];
        foreach (var emp in employees)
        {
            if (emp.Age > oldest.Age) oldest = emp;
        }
        return oldest;
    }

    public static Employee[] SortBySalary(Employee[] employees)
    {
        return employees.OrderByDescending(e => e.Salary).ToArray();
    }

    public static Employee[] FilterByMinAge(Employee[] employees, int minAge)
    {
        return employees.Where(e => e.Age >= minAge).ToArray();
    }

    public static decimal GetAverageSalary(Employee[] employees)
    {
        return employees.Length == 0 ? 0 : employees.Average(e => e.Salary);
    }
}

public static class DataGenerator
{
    private static readonly string[] Names = { "Иван", "Мария", "Алексей", "Елена", "Петр" };

    public static Employee[] GenerateEmployees(int count)
    {
        var random = new Random();
        var result = new Employee[count];

        for (int i = 0; i < count; i++)
        {
            result[i] = new Employee
            {
                Name = Names[random.Next(Names.Length)],
                Age = random.Next(18, 65),
                Salary = random.Next(30000, 150000)
            };
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
        Employee[] staff = DataGenerator.GenerateEmployees(5);
        Console.WriteLine("Список сотрудников:");
        Array.ForEach(staff, Console.WriteLine);

        Employee oldest = EmployeeAnalytics.FindOldestEmployee(staff);
        Console.WriteLine($"\nСамый старший: {oldest}");

        decimal avgSalary = EmployeeAnalytics.GetAverageSalary(staff);
        Console.WriteLine($"Средняя зарплата: {avgSalary:C}");

        Console.WriteLine("\nСотрудники старше 40 лет:");
        var experienced = EmployeeAnalytics.FilterByMinAge(staff, 40);
        Array.ForEach(experienced, Console.WriteLine);
    }
}
