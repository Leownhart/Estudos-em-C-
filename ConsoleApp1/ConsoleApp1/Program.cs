using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 100 * Math.Pow(1 + 0.01, 5);
            Console.WriteLine(n.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
