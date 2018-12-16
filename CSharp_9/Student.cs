using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CSharp_9
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public List<string> Hobbies { get; set; }

         public override string ToString(){
            return string.Format("Student Info:\n\tId:{0},\n\tName:{1},\n\tDegree:{2}"+ "\n\tHobbies{3}", Id, Name,Degree,string.Join(",",Hobbies.ToArray()));
         }
    }
}