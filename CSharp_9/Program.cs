using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;


namespace CSharp_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Quizelement quizelement = new Quizelement();
            BinaryQuiz binaryquizelement = new BinaryQuiz();
            GuessQuiz guessquizelement = new GuessQuiz();
            MultiQuiz multiquizelement = new MultiQuiz();
            FreeQuiz freequizelement = new FreeQuiz();


            Student student = new Student()
            {
                Id = 1,
                Name = "Deniz",
                Degree = "MCA",
                Hobbies = new List<string>(){
                        "Uni",
                        "C#"
                }

            };
            //Student Test
            string strResultJSON = JsonConvert.SerializeObject(student);
            File.WriteAllText(@"student.json", strResultJSON);
            Console.WriteLine("Stored!");

            strResultJSON = String.Empty;
            strResultJSON = File.ReadAllText(@"student.json");
            Student resultStudent = JsonConvert.DeserializeObject<Student>(strResultJSON);
            Console.WriteLine(resultStudent.ToString());

            //Quiz Test
            string strResultJsonBinaryQuiz = JsonConvert.SerializeObject(binaryquizelement, Formatting.Indented);
            File.WriteAllText(@"quizelement.json", strResultJsonBinaryQuiz);
            Console.WriteLine("Stored!");

            strResultJsonBinaryQuiz = String.Empty;
            var filePath = @"quizelement.json";
            var jsonData = System.IO.File.ReadAllText(filePath);
            var quizlist = JsonConvert.DeserializeObject<List<Quizelement>>(strResultJsonBinaryQuiz)
                                  ?? new List<Quizelement>();
            quizlist.Add(new Quizelement()
            {
                Type = "Single",
                Question = "Wer ist Kanzler?",
                Answers = new List<string>(){
                        "Merkel",
                        "Obama",
                        "Trump",
                        "Putin"}
            });
            quizlist.Add(new BinaryQuiz()
            {
                Type = "Binary",
                Question = "War Deutschland schon einmal Weltmeister ?",
                Answers = new List<string>(){
                        "Ja"}
            });
            quizlist.Add(new MultiQuiz()
            {
                Type = "Multi",
                Question = "Wer war schonmal Weltmeister?",
                Answers = new List<string>(){
                        "Deutschland","Sibirien","England","Norwegen"}
            });
            quizlist.Add(new FreeQuiz()
            {
                Type = "Free",
                Question = "Wer ist Bundeskanzler?",
                Answers = new List<string>(){
                        "Merkel"}
            });
            quizlist.Add(new GuessQuiz()
            {
                Type = "Guess",
                Question = "Wie viele Einwohner hat Deutschland?",
                Answers = new List<string>(){
                        "83000000"}
            });

            jsonData = JsonConvert.SerializeObject(quizlist, Formatting.Indented);
            System.IO.File.WriteAllText(filePath, jsonData);

        }
    }
}
