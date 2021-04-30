using System;

namespace question5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*calculate the sum of elements in an array*/

            int[] Values = {5, 7, 3, 2, 9}; 

            int sum = ArayCalc(Values); /*two way this is sent to function in order to output sum*/
            Console.WriteLine(sum);
        }
        

        static int ArayCalc(int[] myList) /* static int is what data type is going to be returned from function and int inside bracket is
        what it expects to receive*/
        {       
            int total = 0;
            for (int i = 0; i <myList.Length; i++) /*0 is an index position.. Length is an array property which is how it know to loop */
            {
                total += myList[i]; /*+= this shorthand for 0+5 (5), then 5+7 (12)then loop, 12 +3 etcx*/
               /* total = total + myList[i]; <<< this is the longversion of above entry */
            }

            return total;
        }

                

    }

}
