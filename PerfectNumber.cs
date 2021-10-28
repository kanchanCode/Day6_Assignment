using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class PerfectNumber
    {
        public void perfectNo()
        {
            int n;
            int sum = 0;
            int i;

            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Factor of the given number is " + i);
                    sum += i;
                }
               
            }
            Console.WriteLine("sum of all the factors is :" + sum);
            if (sum == n)
            {
                Console.WriteLine(n+" is a Perfect Number");
            }
            else
            {
                Console.WriteLine(n+" is not a Perfect Number");
            }
        }
    }
}
