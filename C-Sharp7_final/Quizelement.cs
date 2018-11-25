using System;

namespace C_Sharp7_final
{
    public class Quizelement
    {
        public string question;
        public string[] answers;
        public int correct;
        static int userscore = 0;
        public static Quizelement quizelement1 = new Quizelement { question = "WO?", answers = new string[] { "Köln", "Bonn", "Stuttgart", "Berlin" }, correct = 3 };
        public static Quizelement quizelement2 = new Quizelement { question = "WIE?", answers = new string[] { "SO", "ODER", "Anders", "Irgendwie" }, correct = 1 };

        public static void showQuiz()

        {
            string useranswer;
            int count = 0;
            Console.WriteLine("Question:" + quizelement1.question);
            foreach (var item in quizelement1.answers)
            {
                count++;
                Console.WriteLine($"Answer {count}:  " + item.ToString());
            }
            Console.WriteLine("Think you found the right answer? Let's see, type in it's number!");
            useranswer = Console.ReadLine();
            int x = 0;
            Int32.TryParse(useranswer, out x);
            if (x == quizelement1.correct)
            {
                userscore = userscore + 10;
                Console.WriteLine($"Perfect! New score: {userscore}");
            }
            else
            {
                userscore = userscore - 5;
                Console.WriteLine($"Wrong, try again! New score: {userscore}");
            }
        }
        public static void NewUserQuestion()
        {

            Console.WriteLine("Pose a question:");
            string userquestion = Console.ReadLine();
            Console.WriteLine("Give possible answers, separate them by a comma:");
            string useranswers = Console.ReadLine();
            string[] useranswersseperated = useranswers.Split(",");
            Console.Write(useranswers);
            Console.WriteLine("Type in the number of the RIGHT answer:");
            int usercorrect = Convert.ToInt32(Console.ReadLine());
            Quizelement quizelement3 = new Quizelement { question = userquestion, answers = useranswersseperated, correct = usercorrect };
            foreach (var item in quizelement3.answers)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(quizelement3.question + Environment.NewLine + useranswers + Environment.NewLine + quizelement3.correct);
        }


    }
}