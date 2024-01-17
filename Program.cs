using Mission_2;

internal class Program
{
    private static void Main(string[] args)
    {
        NumberOfRolls b = new NumberOfRolls();

        // Console.WriteLine("Hello, World!");

        int NumberOfRolls = b.GetNumberOfRolls();
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\r\nEach \"*\" represents 1% of the total number of rolls." +
            "\r\nTotal number of rolls = " + NumberOfRolls + ".\n");

        // Create an array to store the count of each sum
        int[] diceSumCounts = new int[13];

        // Initialize a random number generator
        Random random = new Random();

        // Simulate the rolling of two dice and count the sums
        for (int i = 0; i < NumberOfRolls; i++)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);

            // Calculate the sum of the two dice
            int sum = die1 + die2;

            // Increment the count for the sum
            diceSumCounts[sum]++;
        }


    }
}