using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // Tip Calculator
        // Author: Tom Williams
        // Date: 10-01-2020

        // Problem Statement
        /*
         * Create a simple tip calculator.
         * The program should prompt for a bill amount and a tip percentage.
         * The program must compute the tip.
         * Display both the tip and the total amount of the bill.
         */

        static void Main(string[] args)
        {
            while (true)
            {
                // Inputs
                // Define varables for the inputs and outputs and initialize them to zero.
                // Prompt the user for the bill amount.
                // Convert user's input from string to double
                Console.WriteLine("What is the bill amount?");
                double billAmount = Convert.ToDouble(Console.ReadLine());

                // Prompt the user for the tip percentage.
                // Convert user's input from string to double
                Console.WriteLine("What is the tip percentage?");
                double tipPercentage = Convert.ToDouble(Console.ReadLine());

                // Calculate the tip by multiplying bill amount with the tip rate divided.
                double tipAmount = Math.Round(billAmount * (tipPercentage / 100));

                // Calculate the total amount including the tip.
                double totalAmount = billAmount + tipAmount;

                // Display the total amount and tip to the console.
                Console.WriteLine("Bill Amount: {0}", billAmount);
                Console.WriteLine("Tip Percentage: {0}", tipPercentage);
                Console.WriteLine("Tip amount: £ {0}", tipAmount);
                Console.WriteLine("Total Amount: £ {0}", totalAmount);

                // Calculate again?
                Console.WriteLine("Calculate Again? [Y or N]");

                // Get the answer to Calculate again.
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

    }
}
