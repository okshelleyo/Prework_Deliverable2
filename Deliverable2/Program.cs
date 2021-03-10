using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            // set up variables
            string userInput; // user's chat reponse
            bool newChat = false;
            string oldUserInput = "";
            
            //welcome the user

            Console.WriteLine("Welcome to the Chat Bot!");           

            
            while (newChat == false)
            {
                Console.WriteLine("What would you like to chat about?");
                Console.WriteLine();
                userInput = Console.ReadLine().ToLower();

                //comparing user input to determine bot response

                if (userInput == "bye")
                {
                    Console.WriteLine("Goodbye!");
                    newChat = true;
                }
                
                else if (userInput == oldUserInput)
                {
                    Console.WriteLine("I'm sorry, but you have already said that.");
                }

                else if (userInput == "hello")
                {
                    Console.WriteLine("Hi, good to see you!");
                }

                else if (userInput == "sup")
                {
                    Console.WriteLine("I am good.");
                }

                else if (userInput == "hello there")
                {
                    Console.WriteLine("General Kenobi");
                }

                else                
                {
                    Console.WriteLine("I do not understand.");                    
                }

                //track user input in case they enter the same input twice
                oldUserInput = userInput;             

            }
                    

        }

    }
}

