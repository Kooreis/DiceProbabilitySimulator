# Python Documentation

# Dice Roll Simulation

This Python script simulates the rolling of dice and calculates the simulated percentage of each possible total roll. The user can specify the number of trials and the number of dice to roll.

## Script Explanation

The script is divided into four main functions:

1. `roll_dice(n)`: This function simulates the rolling of `n` dice. It uses the `random.randint(1, 6)` function to generate a random number between 1 and 6 (inclusive) for each die roll. The results are returned as a list.

2. `simulate(num_trials, num_dice)`: This function simulates a specified number of trials of rolling a certain number of dice. It keeps track of the total roll for each trial and counts the number of times each possible total roll occurs.

3. `print_results(results, num_trials)`: This function prints the results of the simulation. It calculates the simulated percentage for each possible total roll and prints this information in a nicely formatted table.

4. `main()`: This is the main function that runs the script. It prompts the user to enter the number of trials and the number of dice, and then calls the other functions to perform the simulation and print the results.

## Imported Libraries

The script imports the `random` library, which is used to generate random numbers. This is used in the `roll_dice(n)` function to simulate the random outcome of rolling a die.

## Usage

To use this script, simply run it in a Python environment. You will be prompted to enter the number of trials and the number of dice. The script will then simulate the specified number of trials of rolling the specified number of dice, and print the simulated percentage for each possible total roll.

## Example

If you run the script and enter 1000 for the number of trials and 2 for the number of dice, the script will simulate 1000 trials of rolling 2 dice and print the simulated percentage for each possible total roll from 2 to 12.

---

# C# Documentation

# Dice Probability Simulator

This is a simple C# console application that simulates the probability of rolling each number on a six-sided dice.

## Description

The script prompts the user to enter the number of dice rolls to simulate. It then uses a random number generator to simulate each roll, incrementing a counter for each possible outcome (1-6). Finally, it calculates and displays the probability of each outcome as a percentage of the total number of rolls.

## Code Explanation

```CSharp
using System;
```
The System namespace contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions.

```CSharp
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
```
The script begins by creating a new instance of the Random class, which is used to generate random numbers. It then creates an array to store the count of each possible dice roll (1-6). The user is prompted to enter the number of dice rolls to simulate, and this input is converted to an integer.

```CSharp
            for (int i = 0; i < numberOfRolls; i++)
            {
                int roll = random.Next(1, 7);
                diceRolls[roll - 1]++;
            }
```
The script then enters a loop that runs for the specified number of dice rolls. In each iteration of the loop, it generates a random number between 1 and 6 (inclusive) to simulate a dice roll, and increments the corresponding counter in the array.

```CSharp
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
Finally, the script calculates the probability of each possible outcome by dividing the count of each outcome by the total number of rolls. These probabilities are then displayed to the user as percentages.

---

# Java Documentation

# Dice Probability Simulator

This is a simple Java program that simulates the rolling of two dice and calculates the probability of each possible outcome.

## Description

The program prompts the user to enter the number of dice rolls. It then simulates that number of rolls, each time generating two random numbers between 1 and 6 (inclusive) to represent the outcomes of rolling two dice. The sum of the two numbers is calculated for each roll, and the frequency of each possible sum (from 2 to 12) is recorded. Finally, the program outputs the frequency and percentage of each possible sum.

## Libraries

The program uses the following Java libraries:

- `java.util.Random`: This library is used to generate random numbers, which are used to simulate the rolling of dice. The `nextInt(int bound)` method is used to generate a random integer between 0 (inclusive) and the specified bound (exclusive). In this case, the bound is 6, so the method generates a number between 0 and 5. We then add 1 to the result to get a number between 1 and 6, which represents the outcome of a dice roll.

- `java.util.Scanner`: This library is used to read input from the user. The `nextInt()` method is used to read an integer, which represents the number of dice rolls to simulate.

## Code

The main part of the program is a loop that simulates the specified number of dice rolls. For each roll, it generates two random numbers to represent the outcomes of the two dice, calculates the sum, and increments the corresponding element of the `diceCount` array.

After the loop, the program outputs the results. It loops over the `diceCount` array and for each element, it prints the sum (which is the index of the element), the frequency (which is the value of the element), and the percentage (which is the frequency divided by the total number of rolls, multiplied by 100).

## Usage

To run the program, compile it with a Java compiler and then run the resulting class file. When prompted, enter the number of dice rolls to simulate. The program will then simulate the rolls and output the results.

---
