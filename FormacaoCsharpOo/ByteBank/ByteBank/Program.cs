// See https://aka.ms/new-console-template for more information

using ByteBank;

Console.WriteLine("Bem vindo ao ByteBank");

ContaCorrente conta1 = new ContaCorrente();

conta1.titular = "Leandro Menezes";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 93.50;

//Console.WriteLine($"Titular: {conta1.titular}");
//Console.WriteLine($"Conta: {conta1.conta}");
//Console.WriteLine($"Número da Agência: {conta1.numero_agencia}");
//Console.WriteLine($"Nome da Agência: {conta1.nome_agencia}");
//Console.WriteLine($"Saldo: {String.Format("{0:0.00}", conta1.saldo)}");

ContaCorrente conta2 = new ContaCorrente();

conta2.titular = "Danielle do Vale";
conta2.conta = "10124-x";
conta2.numero_agencia = 23;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 10000093.50;

//Console.WriteLine($"Titular: {conta2.titular}");
//Console.WriteLine($"Conta: {conta2.conta}");
//Console.WriteLine($"Número da Agência: {conta2.numero_agencia}");
//Console.WriteLine($"Nome da Agência: {conta2.nome_agencia}");
//Console.WriteLine($"Saldo: {String.Format("{0:0.00}", conta2.saldo)}");

ContaCorrente conta3 = new ContaCorrente();

//Console.WriteLine($"Titular: {conta3.titular}");
//Console.WriteLine($"Conta: {conta3.conta}");
//Console.WriteLine($"Número da Agência: {conta3.numero_agencia}");
//Console.WriteLine($"Nome da Agência: {conta3.nome_agencia}");
//Console.WriteLine($"Saldo: {String.Format("{0:0.00}", conta3.saldo)}");

double saldo1 = 100;
double saldo2 = 100;

saldo2 = conta1.saldo;
conta1.saldo = 200;
Console.WriteLine(saldo1 == conta1.saldo);
Console.WriteLine(saldo1 == saldo2);

Console.ReadKey();
