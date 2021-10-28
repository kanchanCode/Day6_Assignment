using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class CouponCode
    {
        public void coupon()
        {
            Console.WriteLine("Enter no of coupons");
            int coupons = Convert.ToInt32(Console.ReadLine());

            int[] storeAll = new int[coupons];
            int i;
            for (i=0;i<coupons;i++)
            {
                Random ran = new Random();
                //for 3 digit 
                int randomNum = ran.Next(99,1000);

                if (i == 0)
                {
                    storeAll[i] = randomNum;
                }
                else
                {
                    int position = 0;
                    int flag = 0;
                    while (position < i)
                    {
                        if (storeAll[position] == randomNum)
                            flag = 1;
                        position++;
                    }
                    if (flag == 0)
                    {
                        storeAll[i] = randomNum;

                    }
                    else
                    {
                        i--;
                    }
                }
            }

            Console.WriteLine("coupon numbers are : ");
            for (int j = 0; j < coupons; j++)
            {
                Console.WriteLine(storeAll[j]);
            }
        }
    }
}
