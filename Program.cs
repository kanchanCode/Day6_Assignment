using System;

namespace Day6_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("1. Calculate Fibonacci series till the number entered");
            Console.WriteLine("2. Check whether given number is Perfect number or not ");
            Console.WriteLine("3. Check whether given number is Prime number or not ");
            Console.WriteLine("4. To print reverse of the given number");
            Console.WriteLine("5. To generate distinct random numbers");
            Console.WriteLine("6. To run stopWatch");
            Console.WriteLine("Enter your choice from above menu");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                
                        FibonacciSeries obj1 = new FibonacciSeries();
                        obj1.fibonacci();
                   
                    break;
                case 2:
                     PerfectNumber obj2 = new PerfectNumber();
                    obj2.perfectNo();

                    break;
                case 3:
                    PrimeNumber obj3 = new PrimeNumber();
                    obj3.prime();
                    break;
                case 4:
                     ReverseNumber obj4 = new ReverseNumber();
                    obj4.reverse();
                    break;
                case 5:
                    CouponCode obj5 = new CouponCode();
                    obj5.coupon();

                    break;
                case 6:
                    /*watch obj6 = new watch();
                    obj6.choice();
                    break;*/

                    watch obj6 = new watch();
                    obj6.stopwatch();
                    break;

                default:
                    break;
            }

        }
    }
}
