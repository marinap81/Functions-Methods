using System;

namespace question10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*create a function to calculate the sum of the individual digits of a given number.*/
            int n = getInput("Enter Nmber");
            int tot = CalcSum(n);

            Console.Write("The sum of the digits of the number "+ n + " is : "+ tot);
        }

        static int CalcSum(int n)
        {
            int sum = 0;
            string word = n.ToString();

            for (int i=0; i < word.Length; i++)
            {
                char temp = word[i];
                sum += int.Parse(temp.ToString());
            }

            return sum;
        }

        static int getInput(string name)
        {
            Console.WriteLine(name);
            string myStr = Console.ReadLine();

            return int.Parse(myStr);
        }
    }
}
