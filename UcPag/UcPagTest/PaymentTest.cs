using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System;
using UcPag;

namespace UcPagTest
{
    [TestClass]
    public class PaymentTest
    {
        // [Metodo]_[Condicao]_[ResultadoEsperado]
        [TestMethod]
        public void CalcularJuros_ObterCapitalInicial_DeveRetornaMotante()
        {
            //Arrange
            Payment Cal = new Payment();

            double capitalinicial = 100;
            int periodo = 5;

            Cal.CapitalFinal = 105.10;
            double resultadoesperado = Cal.CapitalFinal;
            

            //Act

            Cal.CalcularJuros(capitalinicial, periodo);
            Cal.CapitalFinal.ToString("F2", CultureInfo.InvariantCulture);
            double resultadoatual = Cal.CapitalFinal;

            //Assert
            Assert.AreEqual(resultadoesperado.ToString("F2"), resultadoatual.ToString("F2"));


        }
        
    }

}


