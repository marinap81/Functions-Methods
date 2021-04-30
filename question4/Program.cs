using System;

namespace question4
{
    class Program
    {
        static void Main(string[] args)
        /*create a function to input a string and count number of spaces are in the string*/
        {
          
            Console.WriteLine("Please enter text:");
            string word1 = Console.ReadLine();
            int spacesFound = Spacer(word1); /*word1 is being sent to function it is 2 way communication*/

            Console.WriteLine("\"" + word1 + "\" contains " + spacesFound + " spaces");
       }

        static int Spacer(string myStr)
        {            
            
            string[] substrings = myStr.Split(" "); /* can split on other variables not just split spaces */
            int cntFound = substrings.Length-1; /*nature of array will draw out to understand */       

            return cntFound;


        }

    }    
}

