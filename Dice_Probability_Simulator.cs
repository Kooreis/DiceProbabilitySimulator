```CSharp
using System;

namespace DiceProbabilitySimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] diceRolls = new int[6];
            Console.WriteLine("Enter the number of dice rolls:");
            int numberOfRolls = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfRolls; i++)
            {
                int roll = random.Next(1, 7);
                diceRolls[roll - 1]++;
            }

            Console.WriteLine("Dice Roll Probability Simulator Results:");
            for (int i = 0; i < diceRolls.Length; i++)
            {
                double probability = (double)diceRolls[i] / numberOfRolls;
                Console.WriteLine($"Number {i + 1}: {probability * 100}%");
            }
        }
    }
}
```