using System;


namespace C_Sharp4
{
    class TestClass
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                RondomName();
            }
        }
        public static Random rand = new Random(DateTime.Now.Second);
        public static void RondomName()
        {
            string[] firstNames = new string[] { "Anna", "Ben", "Chris", "Dani", "Emi" };
            string[] lastNames = new string[] { "Failenschmid", "Google", "Haus", "Igel", "Jeder" };
            string userName;
            int age = rand.Next(17, 25);


            var FirstName = firstNames[rand.Next(0, firstNames.Length)];
            var LastName = lastNames[rand.Next(0, lastNames.Length)];
            if (age >= 20)
            {
                userName = $"{FirstName} {LastName} {age}";
                Console.WriteLine(userName);
            }
            else
            {
                Console.WriteLine(age + " ist zu jung!");
            }
        }
    }
}

