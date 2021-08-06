using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace LogicalPrograms
{
    class Program6
    {
        public static void StopWatch()
        {
            //Welcome Message Function
            WelcomeMsg();

            //Variables
            int startTime;
            int endTime;

            //Display Message To Enter
            Console.WriteLine("Press Any Key to Start StopWatch");
            Console.WriteLine("00:00:00.0000000");
            Console.WriteLine("-------------------------------");
            Console.ReadKey();

            // Creating new instance of the stopwatch
            Stopwatch timer = new Stopwatch(); 
            timer.Start(); 

            //Display Message            
            Console.WriteLine("\n Press Any Key to End StopWatch");
            Console.ReadKey();

            // to stop the timer in code
            timer.Stop();            
            Console.WriteLine("\n Stop At : {0} ", timer.Elapsed);
            Console.WriteLine("-------------------------------");
        }
        public static void StopWatch1()
        {
            //Welcome Message Function
            WelcomeMsg();
            
            //Variables
            string startTime;
            string endTime;

            //Display Message To Enter
            Console.WriteLine("Press Any Key to Start ");                        
            Console.ReadKey();

            startTime = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine("\n Start time : {0}", startTime);

            //Display Message To Enter            
            Console.WriteLine("---------------------");
            Console.WriteLine("Press Any Key to Stop");
            Console.ReadKey();

            endTime = DateTime.Now.ToString("\n h:mm:ss tt");
            Console.WriteLine("\n End time : {0}", endTime);

            //Display Message To Enter            
            Console.WriteLine("---------------------");
            Console.WriteLine("\n Press Any Key to see Elapsed Time :");
            Console.ReadKey();

            TimeSpan elapsedTime = DateTime.Parse(endTime).Subtract(DateTime.Parse(startTime));
            Console.WriteLine("Elapsed Time is : " + elapsedTime);            
        }
        public static void WelcomeMsg()
        {
            //welcome Message
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Welcome To StopWatch : ");
            Console.WriteLine("-------------------------------");
        }
    }
}
