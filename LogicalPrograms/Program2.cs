using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Program2
    {
        public static void PerfectNumber()
        {
            //Welcome Message
            Console.WriteLine("Welcome To Perfect Number");

            //Constant variable
            int MIN_NUMBER = 0;
            int DIVIDER = 10;

            // Variables
            int reminder;
            int sum = 0;

            //User Input
            Console.WriteLine("Enter Number to Check Perfect Number : ");
            int userNumber = int.Parse(Console.ReadLine());

            //Sum of Divisor
            for (int i = 1; i <= userNumber/2; i++)                    
            {
                if((userNumber%i) == MIN_NUMBER)                    
                    sum += i;                    
            }
            Console.WriteLine("Sum : {0} ", sum);

            //Check Perfect Number
            if (userNumber == sum)
                Console.WriteLine(userNumber + " is Perfect Number");      
            else
                Console.WriteLine(userNumber + " is Not Perfect Number");
        }
    }
}
