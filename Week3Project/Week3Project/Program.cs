using System;

namespace Week3Project
{
    class Program : User
    {
        static void Main(string[] args)
        {
            var user = new User();

            user.firstName = user.AnswerQuestion("What's your first name?");


            user.lastName = user.AnswerQuestion("What's your last name?");


            user.favoriteNumber = user.AnswerQuestionWithInteger("What's your favorite number?");


            user.numberOfPets = user.AnswerQuestionWithInteger("How many pets do you have?");


            user.namesOfPets = user.AnswerQuestion("What are the names of your pets?");



            Console.WriteLine($"Your name is {user.firstName} {user.lastName}");
            Console.WriteLine($"Your favorite number is {user.favoriteNumber} and You have pet {user.numberOfPets}");
            Console.WriteLine($"And your pet name is {user.namesOfPets}");
        }
    }
}
