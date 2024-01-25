internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many dice rolls would you like to simulate? ");
        int numRolls = int.Parse(Console.ReadLine());

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numRolls}.\n");

        DiceRoller diceRoller = new DiceRoller();
        int[] results = diceRoller.RollDice(numRolls);

        for (int i = 0; i < results.Length; i++)
        {
            int number = i + 2; 
            double percentage = (double)results[i] / numRolls * 100;
            Console.Write($"{number}: ");

            for (int Count = 0; Count < (int)percentage; Count++)
            {
                Console.Write("*");
            }
            Console.WriteLine($" ({percentage:0.00}%)");
        }
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}
