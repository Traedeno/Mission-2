using Mission_2;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Welcome to the dice throwing simulator!");
        Console.Write("\nEnter the number of times to roll the dice: ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        NumberOfRolls diceRoller = new NumberOfRolls();
        int[] results = diceRoller.SimulateRolls(numberOfRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls." +
"\nTotal number of rolls = " + numberOfRolls + ".\n");
        PrintHistogram(results, numberOfRolls);
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }

    // This prints out the histogram results
    static void PrintHistogram(int[] results, int totalRolls)
    {
        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i] * 100 / totalRolls;

            Console.Write($"{i}: {new string('*', percentage)}");
            Console.WriteLine();
        }
    }
}