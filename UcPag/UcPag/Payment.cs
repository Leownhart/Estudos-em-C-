using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace UcPag
{
    public class Payment
    {
        public double CapitalFinal { get; set; }
        public Payment()
        {

        }
        public Payment(double capitalFinal)
        {
            CapitalFinal = capitalFinal;
        }
        public double GerarTaxaJuro()
        {
            return 0.01;
        }
        public void CalcularJuros(double capitalinicial, int periodo)
        {
            CapitalFinal = capitalinicial * Math.Pow(1 + GerarTaxaJuro(), periodo);
        }
        public override string ToString()
        {
            return "Resultado Esperado: " + CapitalFinal.
                ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}

