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
                //Get inputs from user
                //Console.WriteLine("How many at bats do you want to record for the batter?");
                //int atBats = GetIntegerInRange(0, 100);

                Console.WriteLine("How many batters do you wish to enter data for?");
                int batters = GetIntegerInRange(0, 10);

                int[][] BatterData = new int[batters][];

                for (int r = 0; r < batters; r++)
                {
                    Console.WriteLine("How many at bats does batter No. {0} have?", r + 1);
                    BatterData[r] = new int[int.Parse(Console.ReadLine())];

                    Console.WriteLine("Enter batting data for batter {0}:", r + 1);

                    for (int c = 0; c < BatterData[r].Length; c++)
                    {
                        BatterData[r][c] = int.Parse(Console.ReadLine());
                    }

                }
                
                for (int r = 0; r < batters; r++)
                {
                    decimal x, y, BA, SP = 0;
                    x = BattingAverage(BatterData[r]);
                    y = SluggingPercentage(BatterData[r]);

                    BA = Math.Round(x, 3);
                    SP = Math.Round(y, 3);

                    //output results to user
                    Console.WriteLine("Batter {0} Batting average: {1}\t Slugging percentage: {2}", r+1 , BA.ToString("#0.000"), SP.ToString("#0.000"));
                }

            } while (Continue());

            Console.WriteLine("Goodbye!");
        }

        //calculate Batting Average
        public static decimal BattingAverage(int[] input)
        {
            decimal x = 0;
            decimal y = input.Length;

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] != 0)
                {
                    x = x + 1;
                }
            }

            decimal battingAverage = x / y;
            return battingAverage;
        }

        //Calculate Slugging Percentage
        public static decimal SluggingPercentage(int[] input)
        {
            decimal x = 0;
            decimal y = input.Length;

            for (int i = 0; i < input.Length; i++)
            {
                x = x + input[i];


            }
            decimal sluggingPercentage = x / y;
            return sluggingPercentage;

        }

        //Prompts user to continue
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