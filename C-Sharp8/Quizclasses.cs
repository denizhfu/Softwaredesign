using System;
using System.Collections;
using System.Collections.Generic;

namespace C_Sharp8
{
    class QuizSingle : Quizelement
    {
        public int correctAnswer;
        
        // Constructor von variablen trennen macht es sofort ersichtlich
        public QuizSingle(string question, string[] answer, int correct) => (Question, Answer, correctAnswer) = (question, answer, correct);

        public static void AnswerQuizSingle()
        {
            
            List<QuizSingle> listofQuizelements = new List<QuizSingle>();
            listofQuizelements.AddRange(new List<QuizSingle>{
            new QuizSingle("Wer ist Kanzler?", new string[]{"Merkel","Obama","Trump","Putin"},1)
        });
            // var vermeiden stattdessen Datentyp definieren. Verhindert missverständnisse
            foreach (var questionitem in listofQuizelements)
            {
                Console.WriteLine(questionitem.Question);
            }
            foreach (var answeritem in listofQuizelements)
            {
                for (int i = 0; i < answeritem.Answer.Length; i++)
                {

                    Console.WriteLine($"Answer:  " + answeritem.Answer[i]);
                }
            }
            Console.WriteLine("Please choose an answer: ");
            int AnswerChoice = Convert.ToInt32(Console.ReadLine());

            foreach (var correct in listofQuizelements)
            {
                int myAnswer = correct.correctAnswer;
                if (AnswerChoice == myAnswer)
                {
                    userscore = userscore + 10;
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            }
        }
    }

    class QuizMultiple : Quizelement
    {
        public int[] correctAnswers;
        public QuizMultiple(string question, string[] answer, int[] correct) => (Question, Answer, correctAnswers) = (question, answer, correct);

        public static void AnswerQuizMultiple()
        {
            List<QuizMultiple> listofQuizelements = new List<QuizMultiple>();
            listofQuizelements.AddRange(new List<QuizMultiple>{
            new QuizMultiple("Wer war schonmal Weltmeister?", new string[]{"Deutschland","Sibirien","England","Norwegen"}, new int []{1,3})
        });
            foreach (var questionitem in listofQuizelements)
            {
                Console.WriteLine(questionitem.Question);
            }
            foreach (var answeritem in listofQuizelements)
            {
                for (int i = 0; i < answeritem.Answer.Length; i++)
                {

                    Console.WriteLine($"Answer:  " + answeritem.Answer[i]);
                }
            }
            Console.WriteLine("Please enter your choices: ");
            string[] selectedAnswers = Console.ReadLine().Split(",");

            int a = int.Parse(selectedAnswers[0]);

            int b = int.Parse(selectedAnswers[1]);

            foreach (var correct in listofQuizelements)
            {
                if (a == correct.correctAnswers[0] && b == correct.correctAnswers[1])
                {
                    userscore = userscore + 10;
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            }
        }
    }
    class QuizBinary : Quizelement
    {
        bool truthAnswer;
        public QuizBinary(string question, bool truth) => (Question, truthAnswer) = (question, truth);
        public static void AnswerQuizBinary()
        {
            List<QuizBinary> listofQuizelements = new List<QuizBinary>();
            listofQuizelements.AddRange(new List<QuizBinary>{
            new QuizBinary("War Deutschland schonmal Weltmeister? Please enter 'Y' or 'N'", true)
        });
            foreach (var questionitem in listofQuizelements)
            {
                Console.WriteLine(questionitem.Question);
            }
            string answer = Console.ReadLine();
            foreach (var questionitem in listofQuizelements)
            {
                bool rightAnswer = questionitem.truthAnswer;
                if (answer == "Y" && rightAnswer == true)
                {
                    userscore = userscore + 10;
                    Console.WriteLine("Correct");
                }
                else if (answer == "N" && rightAnswer == false)
                {   
                    userscore = userscore + 10;
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            }

        }
    }
    class QuizGuess : Quizelement
    {
        double RightNumber;
        double Tolerance;
        public QuizGuess(string question, double number, double tolerance) => (Question, RightNumber, Tolerance) = (question, number, tolerance);
        public static void AnswerQuizGuess()
        {
            List<QuizGuess> listofQuizelements = new List<QuizGuess>();
            listofQuizelements.AddRange(new List<QuizGuess>{
            new QuizGuess("Wie viele Einwohner hat Deutschland?", 83000000, 3000000)
        });
            foreach (var questionitem in listofQuizelements)
            {
                Console.WriteLine(questionitem.Question);
            }
            double answer = Convert.ToDouble(Console.ReadLine());
            foreach (var questionitem in listofQuizelements)
            {
                double rightAnswer = questionitem.RightNumber;
                double tolerance = questionitem.Tolerance;
                if (answer > (rightAnswer - tolerance) && answer < (rightAnswer + tolerance))
                {   
                    userscore = userscore + 10;
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            }
        }
    }

    class QuizFree : Quizelement
    {
        string Rightword;

        public QuizFree(string question, string answer) => (Question, Rightword) = (question, answer);
        public static void AnswerQuizFree()
        {
            List<QuizFree> listofQuizelements = new List<QuizFree>();
            listofQuizelements.AddRange(new List<QuizFree>{
            new QuizFree("Wer ist Bundeskanzler?", "Merkel")
        });
            foreach (var questionitem in listofQuizelements)
            {
                Console.WriteLine(questionitem.Question);
            }
            string answer = Console.ReadLine();
            foreach (var questionitem in listofQuizelements)
            {
                if (answer == questionitem.Rightword)
                {   
                    userscore = userscore + 10;
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            }
        }
    }
}
