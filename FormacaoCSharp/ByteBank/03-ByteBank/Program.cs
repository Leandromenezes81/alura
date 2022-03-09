// See https://aka.ms/new-console-template for more information
using _03_ByteBank;

ContaCorrente contaDaGrabriela = new ContaCorrente();
contaDaGrabriela.titular = "Gabriela";
contaDaGrabriela.agencia = 863;
contaDaGrabriela.numero = 3546569;

ContaCorrente contaDaGrabrielaCosta = new ContaCorrente();
contaDaGrabrielaCosta.titular = "Gabriela";
contaDaGrabrielaCosta.agencia = 863;
contaDaGrabrielaCosta.numero = 3546569;

Console.WriteLine($"Igualdade de Tipo de Referência: {contaDaGrabriela == contaDaGrabrielaCosta}");

int idade = 27;
int idadeMaisUmaVez = 27;

Console.WriteLine($"Igualdade de Tipo de Valor: {idade == idadeMaisUmaVez}");

contaDaGrabriela = contaDaGrabrielaCosta;

contaDaGrabriela.saldo = 300;

Console.WriteLine(contaDaGrabriela.saldo);
Console.WriteLine(contaDaGrabrielaCosta.saldo);