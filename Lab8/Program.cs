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

            } while (Continue());

            Console.WriteLine("Goodbye!");
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
                return true;
            }
            else
                Console.WriteLine("Invalid input");
            Continue();
            return true;
            {
            }

        }
    }
