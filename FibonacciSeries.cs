using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class FibonacciSeries
    {
        public int n1 = 0;
        public int n2 = 1;
        public int n3 = 0;
        public int n;
        public void fibonacci()
        {
           
            Console.WriteLine("Enter a number till you want to print fibonacci series");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n1);
            Console.WriteLine(n2);
        
            while (n3 < n)  
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                if (n3 < n)
                {
                    Console.WriteLine(n3);
                }
        
            }

            Console.WriteLine("Next number will be greater than the number you've added so stopping here");

        }
    }
}
