using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{
    internal class NumberOfRolls
    {
        public int GetNumberOfRolls()
        {
            Console.Write("Welcome to the dice throwing simulator!");
            Console.Write("\nEnter the number of times you want to roll the dice: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int numberOfRolls) && numberOfRolls > 0)
                {
                    return numberOfRolls;
                }
                else
                {
                    Console.Write("Invalid input. Please enter a positive integer: ");
                }
            }
            

        }
    }
}
