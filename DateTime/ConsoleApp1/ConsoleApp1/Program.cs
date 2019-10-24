using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* DateTime */
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine();

            /* DateTime - Sobrecargas */
            DateTime b1 = new DateTime(2019, 11, 25); // Exemplos de Sobrecargas
            DateTime b2 = new DateTime(2019, 11, 25, 20, 45, 03);
            DateTime b3 = new DateTime(2019, 11, 25, 20, 45, 03, 500);

            /* DateTime - Retorno atual */
            DateTime c1 = DateTime.Now; // Hórario Atual
            DateTime c2 = DateTime.Today; // Data Atual no Hórario 0h
            DateTime c3 = DateTime.UtcNow; // Data e Hórario atual no GMT.

            /* DateTime - Conversão */
            DateTime z1 = DateTime.Parse("2000-08-15"); // Converte String em DateTime
            DateTime z2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime z3 = DateTime.Parse("15/08/2000");
            DateTime z4 = DateTime.Parse("15/08/2000 15:09:34");

            /* DateTime - Criação de Formatos */
            DateTime y1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture); // Criação de Formatos
            DateTime y2 = DateTime.ParseExact("15/08/2000 13/08/2000", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            /* DateTime - Exibição das váriaveis */
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine();
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine();
            Console.WriteLine(z1);
            Console.WriteLine(z2);
            Console.WriteLine(z3);
            Console.WriteLine(z4);
            Console.WriteLine();
            Console.WriteLine(y1);
            Console.WriteLine(y2);
            
        }
    }
}
