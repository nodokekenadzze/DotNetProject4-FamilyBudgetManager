using System;

class Program
{
    // Constant for the minimum salary
    const int MINIMAL_SALARY = 1000;

    static void Main()
    {
        // User input for name and salary
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your salary: ");
        double salary = double.Parse(Console.ReadLine());

        // Calculate how many times the salary exceeds the minimum salary
        double multiplier = salary / MINIMAL_SALARY;
        Console.WriteLine($"{name}, your salary exceeds the minimum salary by {multiplier} times.");

        // Monthly expenses array (Rent, Utilities, Food)
        double[] expenses = new double[3];

        // User input for rent, utilities, and food expenses
        Console.Write("Enter your rent: ");
        expenses[0] = double.Parse(Console.ReadLine());
        Console.Write("Enter your utility bills: ");
        expenses[1] = double.Parse(Console.ReadLine());
        Console.Write("Enter your food expenses: ");
        expenses[2] = double.Parse(Console.ReadLine());

        // Calculate total expenses
        double totalExpenses = expenses[0] + expenses[1] + expenses[2];

        // Calculate remaining amount after expenses
        double remainingAmount = salary - totalExpenses;

        // Display the expenses
        Console.WriteLine("\nYour monthly expenses:");
        Console.WriteLine($"Rent: {expenses[0]}");
        Console.WriteLine($"Utilities: {expenses[1]}");
        Console.WriteLine($"Food: {expenses[2]}");
        Console.WriteLine($"Total expenses: {totalExpenses}");

        // Check if total expenses exceed salary
        if (remainingAmount < 0)
        {
            Console.WriteLine("WARNING: Your expenses exceed your salary!");
        }
        else
        {
            Console.WriteLine($"Remaining money after expenses: {remainingAmount}");
        }

        // Ask user if they want to save money and how much
        Console.Write("Enter the amount you want to save: ");
        double savingsGoal = double.Parse(Console.ReadLine());

        // Calculate how many months it will take to save the desired amount
        if (remainingAmount > 0)
        {
            double monthsToSave = savingsGoal / remainingAmount;
            Console.WriteLine($"It will take you {monthsToSave} months to save {savingsGoal} GEL.");
        }
        else
        {
            Console.WriteLine("You don't have enough money left to save.");
        }
    }
}
