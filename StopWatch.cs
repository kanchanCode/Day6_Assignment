using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class watch
    {
        public void stopwatch()
        {

            Console.WriteLine("The stopwatch, press S to begin and Q to stop");
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();

            var done = false;

            while (!done)
            {
                var UserInput = Console.ReadLine();

                switch (UserInput)
                {
                    case "s":
                        stopWatch.Start();
                        break;
                    case "q":
                        stopWatch.Stop();
                        done = true;
                        break;
                    default:
                        Console.WriteLine("You did something wrong");
                        break;
                }
            }

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value. 
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 2);
            Console.WriteLine("RunTime " + elapsedTime);

            Console.ReadLine();

        }
    }
}


