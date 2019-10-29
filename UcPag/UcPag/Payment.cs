using System;
using UcPag;
using System.Collections.Generic;
using System.Text;

namespace UcPag
{
    class Payment
    {
        public double CaptalInicial { get; set; }
        public int Periodo { get; set; }

        public Payment (double CaptalInicial, int Periodo)
        {
            this.CaptalInicial = CaptalInicial;
            this.Periodo = Periodo;
        }
        public Payment()
        {

        }
        public double GerarTaxaJuro()
        {
            return 0.01;
        }
        public void CalcularJuros(double capitalinicial, int periodo)
        {
            double CaptalFinal = capitalinicial * ((1 + 0.01) * 5);
        }
    }
}
