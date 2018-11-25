using System;

namespace C_Sharp7_final
{
    class Program
    {

        static void Main(string[] args)
        {
            bool continuequiz = false;
            while (!continuequiz)
            {
                Quizelement.showQuiz();
                Console.Write("Do you want to continue the quiz? Yes/No. || To add your own Questions type add" + Environment.NewLine );

                if (Console.ReadLine() == "add")
                {
                    Quizelement.NewUserQuestion();
                    continuequiz = true;
                }
                else if (Console.ReadLine() == "Yes")
                {
                    continuequiz = true;
                }
                else{ continuequiz=false;}
            }
        }

      static void showAllQuestions(){
            
                }
    }
}
