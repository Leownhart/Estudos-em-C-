using System;
using UcPag;

namespace UcPag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Calcular Juros------");
            Payment CalJuros = new Payment();

            Console.Write("Informe o valor Inicial: ");
            CalJuros.CaptalInicial = decimal.Parse(Console.ReadLine());

            Console.Write("Informe o periodo em meses: ");
            CalJuros.Periodo = int.Parse(Console.ReadLine());

            double juros = double.Parse(Console.ReadLine());
            CalJuros.GerarTaxaJuro(juros);

        }
    }
}
