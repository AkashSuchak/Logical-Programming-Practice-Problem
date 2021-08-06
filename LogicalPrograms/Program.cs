using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome To Fibonacci Series : ");

            //Variables
            int number1 = 0, number2 = 1;
            int sumOfFibonacciSeries = 0;

            //Take User Input
            Console.WriteLine("Enter Number to get Fibonacci Series : ");
            int userNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Series :: ");
            Console.WriteLine("1 : {0} ", number1);
            Console.WriteLine("2 : {0} ", number2);

            //Fibonacci Series
            for (int i = 0; i < (userNumber-2); i++)
            {
                //Operation
                sumOfFibonacciSeries = number1 + number2;
                number1 = number2;
                number2 = sumOfFibonacciSeries;
                
                //Display
                Console.WriteLine((i+3) + " : " + sumOfFibonacciSeries);                
            }

            //Call Other Class
            //Program2.PerfectNumber();
            //Program3.PrimeNumber();
            //Program4.ReverseNumber();
            //Program5.CouponNumbers();
            Program6.StopWatch();
            Program6.StopWatch1();
        }
    }
}
