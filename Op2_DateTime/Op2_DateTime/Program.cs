using System;

namespace Op2_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
            DateTime d2 = d.AddHours(2); // Adicionando duas horas a d.
            DateTime d3 = d.AddMinutes(4);

            Console.WriteLine(d); // Util para cálulo de data de vencimento
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine();

            DateTime z1= new DateTime(2019, 10, 24);
            DateTime z2 = new DateTime(1993, 11, 12);

            TimeSpan t = z1.Subtract(z2);

            Console.WriteLine(t);

        }
    }
}
