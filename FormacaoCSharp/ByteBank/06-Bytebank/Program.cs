// See https://aka.ms/new-console-template for more information

using _06_ByteBank;

ContaCorrente conta = new ContaCorrente();
Cliente cliente = new Cliente();

cliente.Nome = "Guilherme";
cliente.CPF = "434.564.879-20";
cliente.Profissao = "Desenvolvedor";

conta.Saldo = -10;
conta.Titular = cliente;

Console.WriteLine(conta.Titular.Nome);
Console.WriteLine(conta.Saldo);

Console.ReadLine();
