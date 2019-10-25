using System;

namespace Op2_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2); // Adiciona
            TimeSpan dif = t1.Subtract(t2); // Subtrai
            TimeSpan mult = t2.Multiply(2.0); // Multiplay recebe um double como parâmetro
            TimeSpan div = t2.Divide(2.0); // Recebe um double como parâmetro

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
