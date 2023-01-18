using System;

namespace Jan18True
{ // PROGRAM ROLLS 2 DIE AND ADDS TOTAL TOGETHER AND DISPLAYS IN A HISTOGRAM BASED ON PERCENTAGE
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            // establishes array from 2-12
            int[] rollTotals = new int[13];

            // Asks user how many times to roll the dice
            Console.Write("Enter the number of times the dice will be rolled: ");
            int num_rolls = int.Parse(Console.ReadLine());

            // similuates the roll of the dice and adds total together per time rolled
            for (int i = 0; i < num_rolls; i++)
            {
                int firstDie = r.Next(1,7);
                int secondDie = r.Next(1,7);
                int total = firstDie + secondDie;

                rollTotals[total]++;
            }

            // Prints results and changes numbers to astericks. Also changes to percentage and displayed as histogram
            Console.WriteLine("\nResults: \nEach '*' represents 1% of the total number of rolls.");


            for (int i = 2; i < 13; i++)
            {
                double numAsterisks = 100 * rollTotals[i] / num_rolls;
                Console.WriteLine($"{i}: " + new string('*', (int)numAsterisks));

            }
        }
    }
}
