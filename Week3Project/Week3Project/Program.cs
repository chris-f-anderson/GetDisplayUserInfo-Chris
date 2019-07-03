using System;

namespace Week3Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name?");
            string response1 = Console.ReadLine();
            Console.WriteLine("What's your last name?");
            string response2 = Console.ReadLine();
            Console.WriteLine("What's your favorite number?");
            string response3 = Console.ReadLine();
            Console.WriteLine("How many pets do you have?");
            string input = Console.ReadLine();
            int num = -1;
            if (!int.TryParse(input, out num))
            {
                Console.WriteLine("Not an integer");
            }
            else
            {
                
           }
            Console.WriteLine("What are the names of your pets?");
            string response5 = Console.ReadLine();


            Console.WriteLine("Your first name is " + response1 + " Your last name is " + response2 
                + " Your favorite number is\n" + response3 + " You have pet " + response4 
                + " and your pet's name is " + response5 );
        }
    }
}
