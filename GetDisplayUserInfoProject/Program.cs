using System;

namespace GetDisplayUserInfoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo User = new UserInfo();
            Console.WriteLine("Hello! What's your first name?");
            User.firstName = Console.ReadLine();
            Console.WriteLine();
                        
            Console.WriteLine("What's your last name?");
            User.lastName = Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine("What's your favorite number?");
            User.favoriteNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("How many pets do you have?");
            User.numberOfPets = int.Parse(Console.ReadLine());
            if (User.numberOfPets <= 0)
            {
                Console.WriteLine("Nice to meet you. Your name is " + User.firstName + " " + User.lastName + ". Your favorite number is " + User.favoriteNumber + ". You have no pets.");
            }
            else if (User.numberOfPets == 1)
            {
                Console.WriteLine("What is its name?");
                User.namesOfPets = Console.ReadLine();
                Console.WriteLine("Nice to meet you. Your name is " + User.firstName + " " + User.lastName + ". Your favorite number is " + User.favoriteNumber + ". You have one pet. Its name is " + User.namesOfPets + ".");
            }
            else
            {
                Console.WriteLine("What are their names?");
                User.namesOfPets = Console.ReadLine();
                Console.WriteLine("Nice to meet you. Your name is " + User.firstName + " " + User.lastName + ". Your favorite number is " + User.favoriteNumber + ". You have " + User.numberOfPets + " pets. Their names are " + User.namesOfPets + ".");
            }
            
        }                
    }
}
