// See https://aka.ms/new-console-template for more information
using _01_ByteBank;

ContaCorrente contaDaGrabriela = new ContaCorrente();

contaDaGrabriela.titular = "Gabriela";
contaDaGrabriela.agencia = 864;
contaDaGrabriela.numero = 524178;
contaDaGrabriela.saldo = 100.00;

contaDaGrabriela.saldo += 200.00;

Console.WriteLine($"Cliente: {contaDaGrabriela.titular}");
Console.WriteLine($"Agência: {contaDaGrabriela.agencia}");
Console.WriteLine($"Número: {contaDaGrabriela.numero}");
Console.WriteLine($"Saldo: {contaDaGrabriela.saldo}");

Console.ReadLine();
