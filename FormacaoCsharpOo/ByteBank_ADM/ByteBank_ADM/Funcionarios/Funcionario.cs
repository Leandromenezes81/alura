﻿namespace ByteBank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }
        private int _tipo;

        public double getBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
