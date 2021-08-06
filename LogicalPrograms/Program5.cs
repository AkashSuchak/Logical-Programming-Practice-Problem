using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Program5
    {
        public static void CouponNumbers()
        {
            //Welcome Message
            Console.WriteLine("Welcome To Coupon Numbers");
                        
            //User Input
            Console.WriteLine("How Many Coupon Number want to generate ? : ");
            int lengthCouponNumber = int.Parse(Console.ReadLine());

            //Arrays
            int[] CouponNumbers = new int[lengthCouponNumber];

            //User Multiple Input for UserCoupon
            for (int i = 0; i < lengthCouponNumber; i++)
            {
                Console.WriteLine("Enter Coupon Number {0} : ", i+1);
                CouponNumbers[i] = int.Parse(Console.ReadLine());                  
            }

            //Coupon Generator
            for (int i = 0; i < lengthCouponNumber; i++)
            {
                // Variable
                int counter = 0;

                while (true)
                {
                    Random rand = new Random();
                    int generatedCoupon = rand.Next(1, (CouponNumbers[i]+1));                    
                    counter++;

                    if (generatedCoupon == CouponNumbers[i])
                    {
                        //Display Output
                        Console.WriteLine("Coupon Number : " + generatedCoupon);
                        Console.WriteLine("Coupon Number generated on {0} number of times ", counter);
                        Console.WriteLine("--------------------------------------------------");
                        break;
                    }
                }
            }            
        }
    }
}
