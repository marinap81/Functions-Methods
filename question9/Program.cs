using System;

namespace question9
{
    class Program
    {
        static void Main(string[] args)
        /*create a function to check whether a number is prime or not*/
        {
            int myInput = getInput("Ïnput a number");

            if ( isPrime(myInput) == true )
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not Prime Number");
            }
        }

        static Boolean isPrime(int n)
        {
            Boolean isPrime = true;

            for ( int i = 2  ; i< n ; ++i  )
            {
                if ( ( n % i ) == 0 )
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }

        static int getInput(string name)
        {
            Console.WriteLine(name);
            string myStr = Console.ReadLine();

            return int.Parse(myStr);
        }
    }
}
