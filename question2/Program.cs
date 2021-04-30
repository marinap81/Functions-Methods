using System;

namespace question2
{
    class Program
    {
        static void Main(string[] args)
        /*create a user define function with parameters*/
        {
            string theWelcome = GetName();
            Console.WriteLine(theWelcome);
        }

         static string GetName()
        {
            Console.WriteLine("Please input a name");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome Friend" + " " + name);
            string theWelcome =Console.ReadLine();
            return theWelcome;
        }
    }
}
