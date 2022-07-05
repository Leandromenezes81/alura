// See https://aka.ms/new-console-template for more information
using ByteBank_ADM.Funcionarios;

Console.WriteLine("Boas vindas ao ByteBank ADM.");

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro";
pedro.Cpf = "123456789-00";
pedro.Salario = 2000;

Console.WriteLine($"Bonificação: R$ {pedro.GetBonificacao()}");

