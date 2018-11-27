using System;

namespace C_Sharp7_final
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Quizelement.showQuiz();
                Console.WriteLine("Do you want to continue the quiz? Yes/No. || To add your own Questions type add");
                string input = Console.ReadLine();
                
                switch (input) {
                    case "add":
                        Quizelement.NewUserQuestion();
                        break;
                    case "No":
                        return; // option 1
                        Environment.Exit(0); // option 2
                        // option 3 : doch eine Laufbedingung und diese hier auf false setzen
                }
            }
        }

      static void showAllQuestions(){
    
      }
    }
}
