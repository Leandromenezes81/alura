// See https://aka.ms/new-console-template for more information
using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitarios;

Console.WriteLine("Boas vindas ao ByteBank ADM.");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro";
pedro.Cpf = "123456789-00";
pedro.Salario = 2000;

//Console.WriteLine($"Nome: {pedro.Nome}");
//Console.WriteLine($"CPF: {pedro.Cpf}");
//Console.WriteLine($"Salário: R$ {String.Format("{0:0.00}", pedro.Salario)}");
Console.WriteLine($"Bonificação: R$ {String.Format("{0:0.00}", pedro.getBonificacao())}");

Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "098765432-11";
paula.Salario = 5000;

//Console.WriteLine($"Nome: {paula.Nome}");
//Console.WriteLine($"CPF: {paula.Cpf}");
//Console.WriteLine($"Salário: R$ {String.Format("{0:0.00}", paula.Salario)}");
Console.WriteLine($"Bonificação: R$ {String.Format("{0:0.00}", paula.getBonificacao())}");

gerenciador.Registrar(pedro);
gerenciador.Registrar(paula);

Console.WriteLine($"Bonificação: R$ {String.Format("{0:0.00}", gerenciador.getBonificacao())}");

Console.ReadKey();
