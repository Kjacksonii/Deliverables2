using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string comOutput = "";
            string lastInput = "";
            bool foundResponse;
            bool shutdown = false;

            Console.WriteLine("What do you want to say to the bot?");

            while (!shutdown)
            {

                foundResponse = false;

                Console.Write("User: ");
                userInput = Console.ReadLine().ToLower();

                Console.Write("Computer: ");
                if (lastInput != userInput)
                {
                    switch (userInput)
                    {
                        case "hello":
                            comOutput = "Hi good to see you";
                            foundResponse = true;
                            break;
                        case "sup":
                            comOutput = "I am good";
                            foundResponse = true;
                            break;

                        case "hello there":
                            comOutput = "General Kenobi";
                            foundResponse = true;
                            break;

                        case "bye":
                            Console.WriteLine("Good bye!");
                            System.Environment.Exit(1);
                            foundResponse = true;
                            break;
                    }
                    if (foundResponse)
                    {
                        Console.WriteLine(comOutput);
                    }
                }
                else
                {
                    Console.WriteLine("I’m sorry but you have already said that");
                }
                lastInput = userInput;
            }
        }
    }
}
