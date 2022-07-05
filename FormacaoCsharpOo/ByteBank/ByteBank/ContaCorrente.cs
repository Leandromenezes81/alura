using ByteBank.Titular;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        private int _numero_agencia;
        public int Numero_Agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }
        public string Nome_Agencia { get; set; }
        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }
        private double saldo;
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                saldo = value;
            }

        }
        // Propriedade estática
        public static int TotalDeContasCriadas { get; set; }

        // Passando campos obrigatórios no construtor
        public ContaCorrente(Cliente titular, string nome_agencia, int numero_agencia, string conta)
        {
            Titular = titular;
            Nome_Agencia = nome_agencia;
            Numero_Agencia = numero_agencia;
            Conta = conta;
            TotalDeContasCriadas += 1;
        }

        public bool Sacar(double valor)
        {
            if (saldo <= valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        // Método sem retorno (void)
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }

        public void DefinirSaldo(double valor)
        {
            if (valor < 0)
                return;
            saldo += valor;
        }

        public double ObterSaldo()
        {
            return saldo;
        }
    }
}
