using System;

namespace question3
{
    class Program
    {
        static void Main(string[] args)
        /*create a function for the sum of two numbers*/
        {
        Console.WriteLine("Please enter a number");
        string numb1 = Console.ReadLine();
        Console.WriteLine("Please enter another number");
        string numb2 = Console.ReadLine();
        Console.WriteLine("Please enter a number");
        string numb3 = Console.ReadLine();

       // int total = Calculator(numb1,numb2,numb3);    
       // Console.WriteLine(total);

        Console.WriteLine(   Calculator(numb1,numb2,numb3)   );
        
               
        }

    
    static int Calculator(string a,string b,string c) /*cam also same string name as above ie numb1 
                                                        but to avoid mistake or confusion can use a and b instead*/
            {
      
             int number1=int.Parse(a);
             int number2=int.Parse(b);
             int number3=int.Parse(c);

            int sum = number1 + number2 + number3;
            return sum;
            }


    }
}
