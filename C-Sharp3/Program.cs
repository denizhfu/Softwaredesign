using System;

namespace C_Sharp3
{
    class Program
    {
        static int oldBase;
        static int newBase;
        static int input;


        static void getNumber()
        {
            try
            {
                Console.WriteLine("Starting Number Converter");
                Console.WriteLine("Input base to convert from");
                oldBase = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Imput base to convert to");
                newBase = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Inpurt number to convert");
                input = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Your number: " + ConvertNumberFromSystemToSystem(input, oldBase, newBase));
            }
            catch (FormatException e)
            {
                Console.WriteLine(Environment.NewLine + e.Message);
                Console.WriteLine("ERROR. Use integer numbers only" + Environment.NewLine);
                getNumber();
            }
        }
        static int DecimalToHexal(int dec)
        {
            int result = 0;
            int factor = 1;
            while (dec != 0)                    //eingabe (10)
            {
                int digit = dec % 6;            //digit = eingabe/6, Rest   (10/6=1, Rest 4) (4/6=0 Rest 1)
                dec /= 6;                       // dec = dec/6              (10/6=1)(4/6=0)
                result += factor * digit;       // result =result + 1*Rest(0+1*4= 4)
                factor *= 10;               // factor = factor *10       (10)(100)
            }
            return result;
        }

        static int ConvertNumberFromSystemToSystem(int number, int fromSystem, int toSystem)
        {
            int result = 0;
            result = OtherToDecimal(number, fromSystem);
            result = DecimalToOther(result, toSystem);
            return result;
        }

        static int DecimalToOther(int dec, int system)
        {
            int result = 0;
            int factor = 1;
            while (dec != 0)
            {
                int digit = dec % system;
                dec /= system;
                result += factor * digit;
                factor *= 10;
            }
            return result;
        }

        static int OtherToDecimal(int other, int system)
        {
            int result = 0;
            int factor = 1;
            while (other != 0)
            {
                int digit = other % 10;
                other /= 10;
                result += factor * digit;
                factor *= system;
            }
            return result;
        }

        static void Main(string[] args)
        {
            /* int iwas=32;
            int ersterTeil = DecimalToHexal(iwas);
            int zweiterTeil = ConvertNumberFromSystemToSystem(iwas,10,6);
             Console.WriteLine(zweiterTeil);*/
            getNumber();
        }
    }

}
