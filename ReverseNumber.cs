using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class ReverseNumber
    {
        public int num, digit;
        public int count;
        // int rev = 0;
       // public int rem;
        public int[] rev;
        public void reverse()
        {
            /*int n;
            int rev = 0;
            int rem;
            Console.Write("Enter a number :");
            n = Convert.ToInt32(Console.ReadLine());
            while(n!=0)
            {
                rem = n % 10;
              
                rev = rev * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Reversed Number "+rev);
             }*/

           

            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of digits");
            digit = Convert.ToInt32(Console.ReadLine());
            rev = new int[digit];

            
            for(int i=0;i<digit;++i)
            {
                rev[i] = 0;
            }

            int count = digit - 1;
            //int rev[] = 0;
            int rem;
            while (num != 0)
            {
                rem = num % 10;
                //rev = rev * 10 + rem;
                rev[count] = rem;
               // Console.Write(rev[count]);
                num = num / 10;
                --count;

            }


           
            /*for (int i=digit-1;i>=0;--i)
            {
                Console.WriteLine("reverse ");
                Console.Write(rev[i]);
            }*/

        }
    }
}
