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
        }
    }
}