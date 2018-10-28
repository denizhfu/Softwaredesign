using System;

namespace C_Sharp2
{
   class Program
    {

        public static void TODO(){ 
            //To-Do-1
            var a = int.MinValue;
            var a1 = int.MaxValue;
            var b= short.MinValue;
            var b1= short.MaxValue;
            var c= float.MinValue;
            var c1= float.MaxValue;
            var d= double.MinValue;
            var d1= double.MaxValue;
            Console.WriteLine("TO-DO #1"+Environment.NewLine+a + " ~ " +a1+ " / "+b + " ~ " +b1+ " / "+c + " ~ " +c1+ " / "+d + " ~ " +d1);
        }
         public static void TODO2(){   
            //To-Do-2
            var i = 42;
            var pi   = 3.1415;
            var salute = "Hello, World";
            Console.WriteLine("TO-DO #2"+Environment.NewLine+salute + "." + pi +"."+i);
         }
         public static void TODO3(){  
            //TO-DO-3
            int[] ia = new int[10];
            char[] ca = new char[30];
            double[] da = new double[12];
            int[] ia2 = {1, 0, 2, 9, 3, 8, 4, 7, 5, 6};
            int ergebnis = ia2[2] * ia2[8] + ia2[4];
            Console.WriteLine(ergebnis);
                //Ergebnis = 13
         }
            //TO-DO-4
        public static void TODO4(){  
            double [] db = {Math.PI,2.718, 2.97};
            Console.WriteLine(db.Length + " & " +db[0] + " & " +db[1]+" & "+db[2]);
            }
            
            //TO-DO-5
        public static void TODO5(){  
            string meinString = "Dies ist ein String";
            string aa = "eins";
            string bb = "zwei";
            string cc = "eins";
            bool aa_eq_bb = (aa == bb);
            bool aa_eq_cc = (aa == cc);
            Console.WriteLine(meinString + " & " +aa + " & " +bb+" & "+cc+ " & " +aa_eq_bb+ " & " +aa_eq_cc);
}

            //TO-DO-7
        public static void TODO7(){  
             Console.WriteLine("Gib eine Zahl für a ein:");
             int aif = int.Parse(Console.ReadLine());
             Console.WriteLine("Gib eine Zahl für b ein:");
             int bif = int.Parse(Console.ReadLine());
             if (aif < bif){
                Console.WriteLine("a ist kleiner b");
            }
            else{
                Console.WriteLine("a ist größer b");
            }

            if (aif > 3 && bif == 6){
                Console.WriteLine("Du hast gewonnen!");
            }
            else{
                Console.WriteLine("Leider verloren!");
            }
        }
            //TO-DO-8
        public static void TODO8(){ 
            string i = Console.ReadLine();
                switch (i)
                {
                case "a":
                    Console.WriteLine("Du hast a eingegeben");
                    break;
                case "b":
                    Console.WriteLine("Du hast b eingegeben");
                    break;
                case "fussball":
                    Console.WriteLine("Ein Name: Gerd Müller");
                    break;
                default:
                    Console.WriteLine("Bitte gib a,b oder fussball ein");
                    break;
                }
                //In Java würde gelten ohne break zwei Werte. In C# wird ein Fehler ausgegeben.
            }

            //TO-DO-9
        public static void TODO9(){ 
            int x=0;
            while(x<=10){
                    x=++x;
                    Console.WriteLine(x);
                }
            }
        public static void TODO10(){ 
            string[] someStrings = 
                {
                        "Hier",
                        "sehen",
                        "wir",
                        "einen",
                        "Array",
                        "von",
                        "Strings"
                };
            int i=0;
            while(i<someStrings.Length)
                {
                    Console.WriteLine(someStrings[i]+"");
                    i++;
                }
             }
        public static void TODO11(){ 
            string[] someStrings = 
                    {
                        "Hier",
                        "sehen",
                        "wir",
                        "einen",
                        "Array",
                        "von",
                        "Strings"
                    };
            int i=0;
            do{
                Console.Write(someStrings[i] + " ");
                i++;
                }
            while(i<someStrings.Length);

            Console.WriteLine("");

            int i2 = 0;
            while(true){
                Console.Write(someStrings[i2] + " ");
                if(i2>=someStrings.Length-1)
                    break;
                i2++;
                }       
            }
             static void Main(string[] args)
        {
            TODO();
            TODO2();
            TODO3();
            TODO4();
            TODO5();
            TODO7();
            TODO8();
            TODO9();
            TODO10();
            TODO11();
        }


}

public class Person
  {
      public string Name;
      public int Personalnummer;  
      static void Second(string[] args)
        { 
             Person jemand = new Person {Name="Horst", Personalnummer=42};
        }
  }
}
