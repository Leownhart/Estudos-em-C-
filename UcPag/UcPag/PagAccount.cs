using System.Globalization;
using System;

namespace UcPag
{
    class PagAccount
    {
        static void Main(string[] args)
        {
            Payment Cal = new Payment();

            Console.WriteLine("-----Calcular Juros------");
            
            Console.Write("Informe o valor Inicial: ");
            double capitalinicial = double.Parse(Console.ReadLine());

            Console.Write("Informe o periodo em meses: ");
            int periodo = int.Parse(Console.ReadLine());

            Cal.CalcularJuros(capitalinicial, periodo);

            Console.Write($"{Cal}");
        }
    }
}
