using System;
using System.Collections.Generic;
using System.Text;

namespace UcPag
{
    class Payment
    {
        public decimal CaptalInicial { get; set; }
        public int Periodo { get; set; }

        public Payment (decimal CaptalInicial, int Periodo)
        {
            this.CaptalInicial = CaptalInicial;
            this.Periodo = Periodo;
        }
        public Payment()
        {

        }
        public double GerarTaxaJuro(double taxa)
        {
            return 0.01;
        }
        public double CalcularJuros(decimal capitalinicial, int periodo)
        {
            return  capitalinicial * Math.Pow((1 + ), periodo);
        }
    }
}
