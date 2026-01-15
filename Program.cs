// See https://aka.ms/new-console-template for more information
using Mission2Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        // initialize variables
        string userInput = "";
        int numRolls;
        int[] rollArray;
        double onePercent;
        double numStars;
        
        // Allow user to indicate how many times they want to roll the dice
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate? ");
        userInput = System.Console.ReadLine();
        numRolls = int.Parse(userInput);
        
        // create DiceRoll instance w/ user input
        DiceRoll dr = new DiceRoll();
        
        // run Roll method, return array of roll combinations (rollArray)
        rollArray = dr.Roll(numRolls);
        // numRolls divided by 100 is 1% of the total rolls
        onePercent = numRolls / 100.0;

        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + userInput + ".\n");

        // Print histogram by iterating through roll combination array (rollArray)
        for (int i = 2; i < 13; i++)
        {
            string stars = "";
            // calculate percentage per roll combination
            numStars = Math.Round(rollArray[i] / onePercent);
            for (int j = 0; j < numStars; j++)
            {
                stars += "*";
            }
            System.Console.WriteLine(i + ": " + stars);
        }

        // Exit message
        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}
