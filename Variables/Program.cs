using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            string greeting = "Hello World";
            int date = 1492;
            bool dogOwnership = true;
            DateTime todayDate = DateTime.Today;
            decimal number = 5.45m;
            char letter = 'X';

            

            Console.WriteLine(greeting);
            Console.WriteLine($"Columbus sailed the world in {date}");
            Console.WriteLine($"It is {dogOwnership.ToString().ToLower()} that I have a dog at home.");
            Console.WriteLine($"Today is {todayDate}.");
            Console.WriteLine($"I spent {number:C} on a cheeseburger.");
            Console.WriteLine($"{letter} marks the spot.");

            // Part 2 & 3
            
            bool userInteraction = false;

            while (userInteraction != true)
            {
                Console.WriteLine("Please enter a number");
                string userInput = Console.ReadLine();
                decimal parsedInput = 0;
                bool parseSuccessful = Decimal.TryParse(userInput, out parsedInput);

                if (parseSuccessful)
                {
                    Console.WriteLine($"Thanks! You wrote the number {parsedInput}.");
                    userInteraction = true;
                }
                else
                {
                    Console.WriteLine("Something went wrong! Try entering numbers only");
                }
            }

            Console.ReadLine();
        }
    }
}
