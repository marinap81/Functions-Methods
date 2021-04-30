using System;

namespace question1
{
    class Program
    {
        static void Main(string[] args)
        {
         string theWelcome = Welcome();
         Console.WriteLine(theWelcome);
        }

        static string Welcome()
        {
            Console.WriteLine("Welcome Friends, have a nice day!");
            string theWelcome =Console.ReadLine();
            return theWelcome;
        }
    }
}
