using System;

namespace Deliverables2
{
    class Program
    {
        static void Main(string[] args)
        {

            string userResponse;
            //string author = hello;
            Console.WriteLine("What do you want to say to the bot?");

            userResponse = Console.ReadLine();
            if (userResponse.ToLower() == "hello")
            {

                Console.WriteLine("Hi good to see you");
                Console.WriteLine("What else do want to say?");
            }

            userResponse = Console.ReadLine();
            if (userResponse.ToLower() == "sup")
            {
                Console.WriteLine("I am good ");
                Console.WriteLine("What else do want to say?");

            }
             userResponse = Console.ReadLine();
             if (userResponse.ToLower() == "hello there")
            { 
                Console.WriteLine("General Kenobi");
                Console.WriteLine("What else do want to say?");
                userResponse = Console.ReadLine();

            }
 
            else _ = userResponse.ToLower() == "bye";
            {
                Console.WriteLine("Good bye!");
                System.Environment.Exit(1);
            }
        }
    }
}
