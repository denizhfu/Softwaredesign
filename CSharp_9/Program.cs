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
            Console.WriteLine("Hello World!");
            Quizelement quizelement = new Quizelement()
            {
                Question = "Wer ist Kanzler?",
                Answers = new List<string>(){
                        "Merkel",
                        "Obama",
                        "Trump",
                        "Putin"
                }

            };
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
            
            //Student Test
            string strResultJsonQuiz = JsonConvert.SerializeObject(quizelement);
            File.WriteAllText(@"quizelement.json", strResultJsonQuiz);
            Console.WriteLine("Stored!");

            strResultJsonQuiz = String.Empty;
            strResultJsonQuiz = File.ReadAllText(@"quizelement.json");
            Quizelement resultQuizelement = JsonConvert.DeserializeObject<Quizelement>(strResultJsonQuiz);
            Console.WriteLine(resultQuizelement.ToString());
            

        }
    }
}
