using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class PrimeNumber
    {
        public int number;
        public void prime()
        { 
            Console.WriteLine("Enter a number to check");
            number = Convert.ToInt32(Console.ReadLine());
            int i;
            int flag = 0;
           
            for (i = 2; i <= number; i++)
            {
                if (number == 2)
                {
                    Console.WriteLine("It is an even prime number ");
                    break;
                }
                else if (number % i == 0)
                {
                    Console.WriteLine("Not a prime number");
                    flag = 1;
                    break;
                }
                else if (flag == 0)
                {
                    Console.WriteLine("It is a Prime number");
                    break;
                }
            }
            
                
            
        }

    }
    
}
