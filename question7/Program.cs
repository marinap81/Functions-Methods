using System;
using System.Collections.Generic;

namespace question7
{
    class Program
    {
        static void Main(string[] args)
        /*create a function to calculate the result of raising an integer number to another*/
        {
            int b = getInput("Base");
            int p = getInput("Power");

            Console.WriteLine("Änswer: " + CalcPower(b,p));
        }

        static int getInput(string name)
        {
            Console.WriteLine("Enter "+name);
            string myStr = Console.ReadLine();

            return int.Parse(myStr);
        }

        static double CalcPower(int b, int p)
        {
            double tot = Math.Pow(b,p);

            return tot;
        }
    }
}
