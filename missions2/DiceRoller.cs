using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DiceRoller
{
    private Random random = new Random();

    public int[] RollDice(int numRolls)
    {
        int[] results = new int[11]; 

        for (int i = 0; i < numRolls; i++)
        {
            int rollOne = random.Next(1, 7);
            int rollTwo = random.Next(1, 7);
            int sum = rollOne + rollTwo;
            results[sum - 2]++; 
        }

        return results;
    }
}