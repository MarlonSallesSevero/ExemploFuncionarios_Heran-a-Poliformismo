namespace ExResolvido001.Entities
{
    internal class FuncionarioTerceiro : Funcionario
    {
        public double AdditionalCharge { get; set; }

        public FuncionarioTerceiro(){
        }
        public FuncionarioTerceiro(string name, int hours, double valuePerHour, double additionalCharge)
            :base(name, hours,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * AdditionalCharge;
        }
    }
}
