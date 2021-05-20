using System;

namespace Deliverables2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResponse;
            bool hello = true;
            bool sup = true;
            bool hellothere = true;

            do
            {

                Console.WriteLine("What do you want to say to the bot?");

                userResponse = Console.ReadLine();
                if (userResponse == "hello")
                {
                    if (hello)
                    {
                        Console.WriteLine("Hi good to see you");
                        hello = false;
                    }
                    else
                    {
                        Console.WriteLine("I’m sorry but you have already said that");
                    }

                }


                if (userResponse == "sup")
                {
                    if (hello)
                    {
                        Console.WriteLine("I am good");
                        sup = false;
                    }
                    else
                    {
                        Console.WriteLine("I’m sorry but you have already said that");
                    }

                }

                if (userResponse == "hello there")
                {

                    if (hellothere)
                    {
                        Console.WriteLine("General Kenobi");
                        hellothere = false;
                    }
                    else
                    {
                        Console.WriteLine("I’m sorry but you have already said that");
                    }

                }

                if (userResponse == "bye")
                {
                    Console.WriteLine("Good bye!");
                    System.Environment.Exit(1);
                }

                Console.WriteLine("What else do want to say? (yes/no)");
                userResponse = Console.ReadLine();
            } while (userResponse.ToLower() == "yes");
        }
    }
}
