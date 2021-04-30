using System;

namespace question8
{
    class Program
    {
        static void Main(string[] args)
        {
            int fb = getInput("Input number of Fibonacci Series");

            Fibonacci(fb);
        }

        static int getInput(string name)
        /*create a function to check whether a number is prime or not*/
        {
            Console.WriteLine(name);
            string myStr = Console.ReadLine();

            return int.Parse(myStr);
        }

        public static void Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                if ( i == 0 )
                {
                    Console.Write(a);
                }
                else if ( i == 1 )
                {
                    Console.Write(a+b);
                }
                else
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                      
                    Console.Write(b);
                }

                Console.Write(" ");
            }
        }
    }
}
