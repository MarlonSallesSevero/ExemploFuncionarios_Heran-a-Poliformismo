namespace ExResolvido001.Entities
{
    internal class Funcionario
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Funcionario()
        {

        }
        public Funcionario(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }
        public virtual double Pagamento()
        {
            return Hours * ValuePerHour;
        }
    }
}
