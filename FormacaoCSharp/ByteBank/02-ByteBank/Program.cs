using _02_ByteBank;

ContaCorrente conta = new ContaCorrente();

conta.titular = "Gabriela";

Console.WriteLine($"Cliente: {conta.titular}");
Console.WriteLine($"Agência: {conta.agencia}");
Console.WriteLine($"Saldo: {conta.saldo}");

Console.ReadLine();