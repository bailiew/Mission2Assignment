namespace Mission2Assignment;

internal class DiceRoll
{
    
    // Generate 2 Random Numbers - return array of dice roll combinations
    public int[] Roll(int tempRolls)
    {
        // initialize instance of Random class
        Random rnd = new Random();
        
        // initialize variables
        int dice1;
        int dice2;
        int diceCombination;
        int[] rollLog = new int[13];

        // loop to roll dice per user input
        for (int i = 0; i < tempRolls; i++)
        {
            dice1 = rnd.Next(1, 7);
            dice2 = rnd.Next(1, 7);
            diceCombination = dice1 + dice2; //will be a number between 2-12
            rollLog[diceCombination]++; // increment count in the spot that = the diceCombination
        }
        
        // return array of roll combinations
        return rollLog;
    }
}