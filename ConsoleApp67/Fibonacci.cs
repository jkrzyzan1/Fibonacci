using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Zadanie
{
    internal class Fibonacci
    {
        //wrzucić parametry min,max
        public static void Sequence(int min, int max)
        {
            var timer = new Stopwatch();
            int counter = 0;
            int x = 0;
            int y = 1;
            int z;
            for (int i = 2; i <= max; i++)
            {
                if (i == min)
                    timer.Start();
                if (i>= min && i<max)
                {
                    z = x + y;
                    counter++;
                    x = y;
                    counter++;
                    y = z;
                    counter++;
                }

                else if (i == max)
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
            Console.WriteLine($"Liczba operacji: {counter}");
            Console.WriteLine($"Czas działania: {timer.Elapsed}");
        }
        
    }
}
