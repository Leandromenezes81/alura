// See https://aka.ms/new-console-template for more information

using ByteBank;
using ByteBank.Titular;

Console.WriteLine("Bem vindo ao ByteBank");

// Criação de uma nova Conta Corrente
// ContaCorrente conta1 = new ContaCorrente();

//conta1.titular = "Leandro Menezes";
//conta1.conta = "10123-x";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agência Central";
//conta1.saldo = 93.50;

// Console.WriteLine($"Titular: {conta1.titular}");
// Console.WriteLine($"Conta: {conta1.conta}");
// Console.WriteLine($"Número da Agência: {conta1.numero_agencia}");
// Console.WriteLine($"Nome da Agência: {conta1.nome_agencia}");
// Console.WriteLine($"Saldo: {String.Format("{0:0.00}", conta1.saldo)}");

//ContaCorrente conta2 = new ContaCorrente();

//conta2.titular = "Danielle do Vale";
//conta2.conta = "10124-x";
//conta2.numero_agencia = 23;
//conta2.nome_agencia = "Agência Central";
//conta2.saldo = 100;

// Console.WriteLine($"Titular: {conta2.titular}");
// Console.WriteLine($"Conta: {conta2.conta}");
// Console.WriteLine($"Número da Agência: {conta2.numero_agencia}");
// Console.WriteLine($"Nome da Agência: {conta2.nome_agencia}");
// Console.WriteLine($"Saldo: {String.Format("{0:0.00}", conta2.saldo)}");

// ContaCorrente conta3 = new ContaCorrente();
// Console.WriteLine($"Conta: {conta3.conta}");
// Console.WriteLine($"Número da Agência: {conta3.numero_agencia}");
// Console.WriteLine($"Nome da Agência: {conta3.nome_agencia}");
// Console.WriteLine($"Saldo: {String.Format("{0:0.00}", conta3.saldo)}");

// double saldo1 = 100;
// double saldo2 = 100;

// Console.WriteLine($"Titular: {conta3.titular}");

// Tipo Valor - Tipo Referência
// saldo2 = conta1.saldo;
// conta1.saldo = 200;
// Console.WriteLine(saldo1 == conta1.saldo);
// Console.WriteLine(saldo1 == saldo2);

// Aplicação do método Sacar()
// Console.WriteLine($"Saldo de {conta2.titular} pré-saque: R$ {conta2.saldo}");
// bool sacar = conta2.Sacar(50);
// Console.WriteLine($"Saque realizado? {sacar}");
// Console.WriteLine($"Saldo de {conta2.titular} pós-saque: R$ {conta2.saldo}");

// Aplicação do método Depositar()
// Console.WriteLine($"Saldo de {conta2.titular} pré-depósito: R$ {conta2.saldo}");
// conta2.Depositar(60);
// Console.WriteLine($"Saldo de {conta2.titular} pós-depósito: R$ {conta2.saldo}");

// Aplicação do método Transferir()
// Console.WriteLine($"Saldo de {conta2.titular} pré-transferência: R$ {conta2.saldo}");
// Console.WriteLine($"Saldo de {conta1.titular} pré-transferência: R$ {conta1.saldo}");

// bool transferencia = conta1.Transferir(50, conta2);
// Console.WriteLine($"Transferência reaçizada com sucesso? {transferencia}");

// Console.WriteLine($"Saldo de {conta2.titular} pós-transferência: R$ {conta2.saldo}");
// Console.WriteLine($"Saldo de {conta1.titular} pós-transferência: R$ {conta1.saldo}");

// Aplicação do método ExibirDadosConta()
// conta1.ExibirDadosConta();
// conta2.ExibirDadosConta();

// Criação de um novo cliente
// Cliente cliente = new Cliente();
// cliente.nome = "Leandro Menezes";
// cliente.cpf = "1234567890-99";
// cliente.profissao = "Desenvolvedor .NET Senior";

// Criação de novo cliente com alteração de namespace
// Cliente danielle = new Cliente();

// Passando a referência de cliente para a conta1
//conta1.titular = new Cliente();
//conta1.titular.nome = "Leandro Menezes";
//conta1.titular.cpf = "1234567890-99";
//conta1.titular.profissao = "Desenvolvedor .NET Senior";
//conta1.conta = "10123-x";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agência Central";
//conta1.saldo = 93.50;

// Console.WriteLine(cliente.nome);
// Console.WriteLine(conta1.titular.nome);

// Validando a existência do campo titular.
// if (conta1.titular == null)
// {
//     Console.WriteLine("O campo 'titular' está nulo.");
// }

// Modificadores de acesso
// ContaCorrente conta4 = new ContaCorrente();

// conta4.DefinirSaldo(150);

// Get e Set
// conta4.Saldo = 150;

// Console.WriteLine($"Saldo: R$ {String.Format("{0:0.00}", conta4.Saldo)}");

Cliente danielle = new Cliente();
danielle.Nome = "Danielle do Vale";

ContaCorrente conta4 = new ContaCorrente(235, "123456-X");
conta4.Saldo = 100;
conta4.Titular = danielle;
Console.WriteLine(conta4.Titular.Nome);
Console.WriteLine(conta4.Saldo);
Console.WriteLine(conta4.Numero_Agencia);
Console.WriteLine(conta4.Conta);

Console.ReadKey();
