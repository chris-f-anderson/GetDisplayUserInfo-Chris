using System;
using System.Collections.Generic;
using System.Text;

namespace Week3Project
{
    class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int favoriteNumber { get; set; }
        public int numberOfPets { get; set; }
        public string namesOfPets { get; set; }

        public string AnswerQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();

        }
        public int AnswerQuestionWithInteger(string question)
        {
            string stringAnswer = AnswerQuestion(question);
            return int.Parse(stringAnswer);

        }
    }
}
