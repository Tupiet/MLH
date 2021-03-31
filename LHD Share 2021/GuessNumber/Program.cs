using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correct = false;

            Random random = new Random();
            int rand = random.Next(0, 100);

            Console.WriteLine("Hello!");
            Console.WriteLine("Are you ready for guessing the number?");
            
            int intents = 1;

            while (correct == false) 
            {
                Console.WriteLine("Try a number:");
                string inputString = Console.ReadLine();
                int input = Int16.Parse(inputString);

                if (input == rand) Console.WriteLine("Correct! You won! You just spent " + intents + " intents.");
                else if (input > rand) Console.WriteLine("The value is lower!");
                else Console.WriteLine("The value is higher!");

                intents++;
            }
        }
    }
}
