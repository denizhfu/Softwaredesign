using System;
using System.Collections;
using System.Collections.Generic;

namespace C_Sharp8
{
    class Quizelement
    {
        // variablenname klein schreiben
        public string Question;
        // Answer ist ein Klassenname aber hier ein Variablenname: Unterscheidung einbauen
        public string[] Answer;
      
        public string CallToAction;
        // Userscore static kann in die Main-Methode, trennt quizelement von userlogik
        public static int userscore = 0;


        //public Quizelement(string question, string [] answer) => (Question, Answer) = (question, answer);
        //lambda expression (x)=>x*x

        public static void ChooseQuestionType()
        {
            Console.WriteLine("Which type of question do you choose? Type: QuizSingle || QuizMultiple || QuizBinary || QuizGuess || QuizFree");
            string type = Console.ReadLine();
            
            // switchcase bei vielen abfragen eventuell einfacher/übersichtlicher
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
            // Wieviele Antworten oder welche Antwort ist korrekt? Worum geht es?
            int addHowManyAnswerds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the correct answer");
            Console.ReadLine();

        }
    }

}
