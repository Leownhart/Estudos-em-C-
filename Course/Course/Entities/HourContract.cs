using System;

namespace Course.Entities
{
    class HourContract // Classe HourContract.
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
            // Construtor Padrão.
        }
        public HourContract(DateTime Date, double ValuePerHour, int Hours)
        {
            this.Date = Date; // Contrutor de Três Argumentos.
            this.ValuePerHour = ValuePerHour;
            this.Hours = Hours;
        }
        public double TotalValue() // Método para cálcular o valor das horas trabalhadas
        {
            return Hours * ValuePerHour;
        }
    }
}
