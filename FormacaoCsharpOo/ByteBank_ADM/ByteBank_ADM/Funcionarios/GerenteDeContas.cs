namespace ByteBank_ADM.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string cpf) : base(4000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }
    }
}
