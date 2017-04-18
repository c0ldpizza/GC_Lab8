using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the Grand Circus Batting Cage!");

            do
            {
                //Main code
                Console.WriteLine("How many at bats do you want to record for the batter?");
                int atBats = GetIntegerInRange(0, 1000);

                int[] BattingResults = new int[atBats];

                Console.WriteLine("0=out, 1=single, 2=double, 3=triple, 4=home run");

                for (int i = 0; i < atBats; i++)
                {
                    Console.Write("Enter the result for the {0}-th at bat:", i + 1);
                    BattingResults[i] = GetIntegerInRange(0, 4);
                }

               


            } while (Continue());

            Console.WriteLine("Goodbye!");
        }

        public static double BattingAverage(int[] input)
        {
            int x = 0;
            int y = input.Length;

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] != 0)
                {
                    x = x + 1;
                }
            }

            double battingAverage = x / y;
            return battingAverage;
        }

        public static bool Continue()
        {
            Console.WriteLine("Another batter? (y/n)");

            string input = Console.ReadLine();

            if (input.ToLower() == "n")
            {
                return false;
            }
            else if (input.ToLower() == "y")
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input");
                Continue();
                return true;
            }

        }

        public static int GetValidInteger()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid integer.");
            }

            return input;
        }

        //Validates that integer is within a given range
        public static int GetIntegerInRange(int min, int max)
        {
            int input;

            do
            {
                Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);
                input = GetValidInteger();
            } while (input < min || input > max);

            return input;
        }
    }
}