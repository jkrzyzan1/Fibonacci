using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp67
{
    internal class Fibonacci
    {
        //wrzucić parametry min,max
        public static void Sequence(int max)
        {
            var timer = new Stopwatch();
            int counter = 0;
            int x = 0;
            int y = 1;
            int z;
            for (int i = 2; i <= max; i++)
            {
                if (i == 30)
                    timer.Start();
                if (i>= 30 && i<47)
                {
                    z = x + y;
                    counter++;
                    x = y;
                    counter++;
                    y = z;
                    counter++;
                }

                else if (i == 47)
                {
                    z = x + y;
                    counter++;
                    timer.Stop();
                }
                else
                {
                    z = x + y;
                    x = y;
                    y = z;
                }
            }
            Console.WriteLine($"Number of operations: {counter}");
            Console.WriteLine($"Time: {timer.Elapsed}");
        }
    }
}
