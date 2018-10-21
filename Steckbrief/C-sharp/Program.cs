using System;

namespace Code_Umgebung
{
    class Program
    {
        static char[] output = new char[10];
        static int i = 0;
        static int remaining;

        static void Main(string[] args)
        {
            try{
            int input = Int32.Parse(args[0]);

            if (0<= input && input<=999)
            {
                GetRomanNumber(input);
            }
            else Console.WriteLine("ERROR-01: Ihre Eingabe war ungültig. Wählen Sie bitte einen Integer-Wert zwischen 0 und 999.");
        }
        
        catch{
                 Console.WriteLine("Bitte einen Zahlenwert eingeben");

        }
    }
        static void GetRomanNumber(int input)
        {
                Hunderter(input);
                Zehner(ref remaining);
                Einer(remaining);
                Console.Write(new string(output));  
        }
      
        static void Hunderter(int input) 
        {
            if (900 <= input)
            {
                output[i] = 'C';
                output[++i] = 'M';
                
            }
            else if (500<=input && input < 900)
            {
                output[i] = 'D';
                int quotient = (input - 500) / 100;

                for(int j = 0;j<quotient;j++)
                {
                    output[++i] = 'C';
                }
            }
            else if(400< input && input <500)
            {
                output[i] = 'C';
                output[++i] = 'D';
            }
            else if(100<input&&input< 400)
            {
                int quotient = input / 100;
                for (int j = 0; j < quotient; j++)
                {
                    output[i] = 'C';
                    i++;
                }
            }

            remaining = input % 100;
        }

        static void Zehner(ref int remaining)
        {
           if (i != 0) { i++; }

           if(90 <= remaining)
           {
                output[i] = 'X';
                output[++i] = 'C';
           }
           else if(50<= remaining && remaining <90)
           {
                output[i] = 'L';
                int quotient = (remaining - 50) / 10;

                for (int j = 0; j < quotient; j++)
                {
                    output[++i] = 'X';
                }
           }
            else if (40 <= remaining && remaining < 50)
            {
                output[i] = 'X';
                output[++i] = 'L';
            }
            else if (10 <= remaining && remaining < 40)
            {
                int quotient = remaining / 10;
                for (int j = 0; j < quotient; j++)
                {
                    output[i] = 'X';
                    i++;
                }
            }
           
            remaining = remaining % 10;
        }

        static void Einer( int remaining)
        {
            if (i != 0) { i++; }

            if (remaining ==9)
            {
                output[i] = 'I';
                output[++i] = 'X';
            }
            else if (5 <= remaining && remaining < 9)
            {
                output[i] = 'X';
                int quotient = (remaining - 5) / 1;

                for (int j = 0; j < quotient; j++)
                {
                    output[++i] = 'I';
                }
            }
            else if (remaining == 4)
            {
                output[i] = 'I';
                output[++i] = 'V';
            }
            else if (1 <= remaining && remaining < 4)
            {
                int quotient = remaining / 1;
                for (int j = 0; j < quotient; j++)
                {
                    output[i] = 'I';
                    i++;
                }
            }         
        }
        
    }
}
/*
I=1
V=5
X=10
L=50
C=100
D=500
M=1000 
949  CMXLIX
426  CDXXVI
312  CCCXII
141     CXLI
Jeder Buchstabe darf maximal 3mal vorkommen ansonsten ->
R1 I steht nur vor V und X
R2 X steht nur vor L und C
R3 C steht nur vor D und M
*/