using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Program3
    {
        public static void PrimeNumber()
        {
            //Welcome Message
            Console.WriteLine("Welcome To Prime Number");

            //Constant variable
            int MIN_NUMBER = 0;
            int COMPARISON = 1;

            // Variables
            int counter=0;            

            //User Input
            Console.WriteLine("Enter Number to Check Prime Number : ");
            int userNumber = int.Parse(Console.ReadLine());

            //Sum of Divisor
            for (int i = 2; i <= userNumber/2; i++)
            {
                if ((userNumber % i) == MIN_NUMBER)
                {
                    Console.WriteLine(i);
                    counter++;
                    break;
                }


            }
            if (counter < COMPARISON )
                Console.WriteLine(userNumber + " is a Prime Number");
            else
                Console.WriteLine(userNumber + " is Not a Prime Number");
        }
    }
}
