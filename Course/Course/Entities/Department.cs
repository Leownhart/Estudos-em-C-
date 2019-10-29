namespace Course.Entities
{
    class Department // Classe Department
    {
        public string Name { get; set; }
        public Department()
        {
            // Construtor Padrão.
        }
        public Department (string Name)
        {
            this.Name = Name; // Contrutor Recebendo  Name.
        }
    }
}
