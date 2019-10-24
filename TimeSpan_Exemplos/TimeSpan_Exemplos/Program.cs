using System;
using System.Globalization;

namespace TimeSpan_Exemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Um objeto TimeSpan internamente armazena uma duração na forma de ticks(100 nanosegundos)*/

            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine();

            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L); // Recebendo parâmetro em ticks
            TimeSpan t4 = new TimeSpan(4, 11, 45);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);

            // Não exibe nada, pois não foi passado nada como parâmetro na estanciação da váriavel.
            Console.WriteLine(t2);
            // ebibirá um TimeSpan de 00:01:30.
            Console.WriteLine(t3);
            // exibe o tempo passado como parâmetro na váriavel t4 e sucessivamente.
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine();

            TimeSpan z1 = TimeSpan.FromDays(1.5); // permite você conversar na unidade que você quiser.
            TimeSpan z2 = TimeSpan.FromHours(1.5);
            TimeSpan z3 = TimeSpan.FromMinutes(1.5);
            TimeSpan z4 = TimeSpan.FromSeconds(1.5);
            TimeSpan z5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan z6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(z1);
            Console.WriteLine(z2);
            Console.WriteLine(z3);
            Console.WriteLine(z4);
            Console.WriteLine(z5);
            Console.WriteLine(z6);

        }
    }
}
