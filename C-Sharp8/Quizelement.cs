using System;
using System.Collections;
using System.Collections.Generic;

namespace C_Sharp8
{
    class Quizelement
    {
        public string Question;
        public string[] Answer;
        public string CallToAction;
        public static int userscore = 0;


        //public Quizelement(string question, string [] answer) => (Question, Answer) = (question, answer);
        //lambda expression (x)=>x*x

        public static void ChooseQuestionType()
        {
            Console.WriteLine("Which type of question do you choose?");
            string type = Console.ReadLine();

            if (type == "QuizSingle")
            {
                QuizSingle.AnswerQuizSingle();
            }
            else if (type == "QuizMultiple")
            {
                QuizMultiple.AnswerQuizMultiple();
            }
            else if (type == "QuizBinary")
            {
                QuizBinary.AnswerQuizBinary();
            }
            else if (type == "QuizGuess")
            {
                QuizGuess.AnswerQuizGuess();
            }
            else if (type == "QuizFree")
            {
                QuizFree.AnswerQuizFree();
            }
            else
            {
                Console.WriteLine("Invalid Argument: " + type);
            }
        }

        public static void AddNewQuestion()
        {

            Console.WriteLine("Enter a new question:");
            string addUserQuestion = Console.ReadLine();
            Console.WriteLine("How many possible answers should the question have?");
            int addHowManyAnswerds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the correct answer");
            Console.ReadLine();

        }
    }

}