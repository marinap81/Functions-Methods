using System;
using System.Collections.Generic;

namespace question6
{
    class Program
    {
        static void Main(string[] args)
        /*create a function to swap the values of two integer numbers*/
        {
            List<int> numbers = new List<int>();
            numbers.Add(GetNumber());
            numbers.Add(GetNumber());
            
            numbers.Reverse();
            Console.WriteLine("First Position: " + numbers[0] + ", second: " + numbers[1]);

        }

        static int GetNumber()
        {
            Console.WriteLine("Enter a number: ");
            return int.Parse(Console.ReadLine());
            
        }
        
      
    }
}

                 