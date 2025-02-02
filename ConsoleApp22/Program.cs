using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 10;
            double sum= 0;
            int day = 0;
            int day20km = 0, day100km = 0;
            while (sum<=100)
            {
                day++;
                sum+= distance;
                if (sum > 20 && day20km == 0)
                {
                    day20km = day;
                }
                if (day100km == 0 && sum > 100)
                {
                    day100km = day;
                }
                distance *= 1.1;
            }

            Console.WriteLine($"Лыжник пробежит более 20 км на {day20km}-й день.");
            Console.WriteLine($"Суммарный пробег превысит 100 км на {day100km}-й день.");
            Console.ReadKey();
        }
    }
}
