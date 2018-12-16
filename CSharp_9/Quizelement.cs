using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CSharp_9
{
    public class Quizelement
    {
        public string Question { get; set; }
        public List<string> Answers { get; set; }

         public override string ToString(){
            return string.Format("Student Info:\n\tQuestion: {0}"+ "\n\tAswers: {1}", Question, string.Join(",",Answers.ToArray()));
         }
    }
}