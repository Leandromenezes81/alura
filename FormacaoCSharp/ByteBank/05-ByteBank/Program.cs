// See https://aka.ms/new-console-template for more information

using _05_ByteBank;

//Cliente gabriela = new Cliente();

//gabriela.nome = "Gabriela";
//gabriela.profissao = "Desenvolvedora C#";
//gabriela.cpf = "043.562.878-20";

ContaCorrente conta = new ContaCorrente();
// conta.titular = gabriela;

conta.titular = new Cliente();
conta.titular.nome = "Gabriela Costa";
conta.titular.cpf = "235.547.963-36";
conta.titular.profissao = "Desenvolvedora C#";

conta.saldo = 500;
conta.agencia = 563;
conta.numero = 654656;

conta.titular.nome = "Gabriela Costa";

// Console.WriteLine(gabriela.nome);
Console.WriteLine(conta.titular.nome);
Console.WriteLine(conta.titular.cpf);
Console.WriteLine(conta.titular.profissao);