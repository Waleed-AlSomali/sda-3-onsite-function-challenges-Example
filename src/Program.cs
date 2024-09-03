using System;

namespace FunctionChallenges
{
    class Program
    {

        public static void StringNumberProcessor(params object[] numbers)
        {
            int sum = 0;
            string text = "";
            foreach (var item in numbers)
            {
                if (item is string)
                {
                    text = text + " " + item;
                }
                if (item is int)
                {
                    sum += Convert.ToInt32(item);
                }

            }
            Console.WriteLine($"{text};{sum}");

        }
        public static void GussingGame()
        {

            int numberOfLost = 0;
            while (true)
            {

                // Generating a Random number from 1 - 5 
                Random random = new Random();
                int randomNumber = random.Next(5) + 1;

                // Take a user input from 1-5
                Console.Write($"Enter a number from 1-5: ");
                string? input = Console.ReadLine(); // "4"

                bool isNumeric = int.TryParse(input, out int guessNumber);

                if (!isNumeric)
                {
                    Console.WriteLine($"Please give numeric value from 1-5");
                    continue;
                }
                else
                {
                    if (randomNumber == guessNumber)
                    {
                        Console.WriteLine($"You have won");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You are lost. Please try again.");
                        numberOfLost++;
                        continue;
                    }
                }
            }
            Console.WriteLine($"Number of time you have lost: {numberOfLost}");


        }
        static void Main(string[] args)
        {
            // GussingGame();
            StringNumberProcessor(100, 200, 300, "hello", "world");




        }

    }
}