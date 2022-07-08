using ByteBank_ADM.Funcionarios;

namespace ByteBank_ADM.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }

        public void Registrar(Diretor funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }

        public double getBonificacao()
        {
            return this.totalBonificacao;
        }
    }
}
