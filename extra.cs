
/*using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Day6_Assignment
{

     class extra
     {
         public int counter;

         // create stopwatch for seconds and at last we can convert seconds to hour:min:sec
         public double second(int counter)
         {
             double seconds = (float)(0.5f + ((100f * counter) / 60));
             double secondsTime = Math.Round(seconds, 2);
             if (secondsTime <= 60)
             {
                 Console.Write("seconds :"+secondsTime);
             }
             else
             {
               double left = secondsTime - 60;

             }
             return secondsTime;
         }
         public double minute(int counter)
         {
             double minutesTime=0;
             double minutes;
             int hour;
             minutes = counter / 60;
             if (minutes < 59)
             {
                 minutesTime = minutes;

             }
             else if(minutes>=60)
             {
                double leftMin= (float)(0.5f + ((100f * minutes) / 60));
               double min=Math.Round(leftMin, 2);

                 minutesTime = min;

             }
             return minutesTime;
         }
         public int hour(int counter)
         {
             int hours = counter / 60;
             int hoursTime = 0;
             if (hours < 24)
             {
                 Console.WriteLine("hours :"+hours);
                 hoursTime = hours;
             }
             else
             {
                 Console.WriteLine("Its is " + (hours / 24) + " days");

             }
             return hoursTime;
         }
         public long start()
         {

             long startTime = 0; ;
             counter = (int)startTime;
             Console.WriteLine("Starting time is 00:00:00 ");
             Thread.Sleep(1000);
             counter++;

             return startTime;

         }
     public long stop(keyEventArgs e)
     {
         long stopTime=0;
         while (e.KeyValue=="q")
         {
             stopTime = start();
             hour(counter);
             minute(counter);
             second(counter);
             Console.WriteLine("Stopping time : " + hour(counter) + ":" + minute(counter) + ":" + second(counter));
         }
         return stopTime;

     }
     public void elapsed()
         {
             long elapsedTime = stop() - start();
             hour(counter);
             minute(counter);
             second(counter);
             Console.WriteLine("Elapsed Time is " + hour(counter) + " : " + minute(counter) + ": " + second(counter));
         }

     private long stop()
     {
         throw new NotImplementedException();
     }

     public void choice() 
         {
             Console.WriteLine("Enter your choice");
             Console.WriteLine("S to start");
             Console.WriteLine("Q to stop");
             var input = Console.ReadLine();
             switch (input)
             {
                 case "s":
                     start();
                     second(counter);
                     minute(counter);
                     hour(counter);
                     break;
                 case "q" :
                     stop();
                     elapsed();
                     break;

                 default:
                     Console.WriteLine("Invalid Choice");
                     break;
             }

         }



     }

}



*/
