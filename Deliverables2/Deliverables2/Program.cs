using System;

namespace Deliverables2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string userResponse;
            //string author = hello;
            Console.WriteLine("Would you like to have a conversation.");
            userResponse = Console.ReadLine();

            while (userResponse == "yes")
            {
                //string lcaseAuthor = author.ToLower();
                //Console.WriteLine($"Lowercase: {lcaseAuthor}");
                userResponse = Console.ReadLine();
                if (userResponse == "hello")
                {

                    Console.Write("Hi good to see you ");

                    Console.Write("What's up?");

                }
                else if (userResponse == "sup")
                {

                    Console.Write("I am good ");

                    Console.Write("Obi-Wan?");

                }
                else if (userResponse == "hello there")
                {
                    Console.Write("General Kenobi ");

                    Console.Write("What's up?");

                }
                else if (userResponse == "bye")
                {
                    Console.Write("Good bye!");
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.Write("I don't understand");
                }
            }

        }
    }
}