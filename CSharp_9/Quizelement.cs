using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CSharp_9
{
    public class Quizelement
    {
        public string Type { get; set; }
        public string Question { get; set; }
        public List<string> Answers { get; set; }

        public override string ToString()
        {
            return string.Format("Student Info: \n\tType: {0} \n\tQuestion: {1}" + "\n\tAswers: {2}", Question, Type, string.Join(",", Answers.ToArray()));
        }
    }
}