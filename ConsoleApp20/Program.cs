using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int d = 50;  
            int n = 10;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a + i * d;
            }
            Console.WriteLine($"Сумма накоплений через {n} месяцев: {sum} рублей");
            Console.ReadKey();
        }
    }
}
