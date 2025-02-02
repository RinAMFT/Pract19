using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = -200;
            double d = 0.2;
            int n = 150;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a + i * d;
            }
            Console.WriteLine($"Сумма первых {n} членов арифметической прогрессии: {sum}");
            Console.Read();
        }
    }
}
