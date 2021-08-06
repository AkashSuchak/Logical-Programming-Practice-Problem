using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Program4
    {
        public static void ReverseNumber()
        {
            //Welcome Message
            Console.WriteLine("Welcome To Reverse Number");

            //Constant variable
            int MIN_NUMBER = 0;
            int DIVIDER = 10;
            int COMPARISON = 1;

            // Variables
            int remainder;
            int reverseNumber = 0;

            //User Input
            Console.WriteLine("Enter Number to Reverse Number : ");
            int userNumber = int.Parse(Console.ReadLine());

            // Length of userNumber
            double lengthUserNumber = Math.Floor(Math.Log10(userNumber) + 1);

            while(userNumber != MIN_NUMBER)
            {
                remainder = userNumber % DIVIDER;
                reverseNumber = reverseNumber * DIVIDER + remainder;
                userNumber /= DIVIDER;
            }
            Console.WriteLine("Reverse Number : " + reverseNumber);
        }
    }
}
