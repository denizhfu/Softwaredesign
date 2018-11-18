using System;
using System.Text;

namespace Aufgabe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib einen Satz ein:");
            string mysentence = Console.ReadLine();
            Console.WriteLine(ReverseMyWords(mysentence));

        }
        public static string ReverseMySentence(string mysentence)
        {
            string[] words = mysentence.Split(' ');
            Array.Reverse(words);
            mysentence = String.Join(" ", words);
            return mysentence;
        }
        public static string ReverseMyCharacters(string mysentence)
        {
            char[] charArray = mysentence.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string ReverseMyWords(string mysentence)
        {
            string[] words = mysentence.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(ReverseMyCharacters(words[i]));
                sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}