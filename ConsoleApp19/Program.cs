using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int d = 4;
            int count = 1;
            int sum = 0;
            while (count <= 5)
            {
                Console.WriteLine(a);
                sum += a;
                a += d;
                count++;
            }
            Console.WriteLine($"sum={sum}");
            Console.Read();
        }
    }
}
