// See https://aka.ms/new-console-template for more information
Console.WriteLine("Executando Projeto 04 - Conversões e outros Tipos Numéricos.");

double salario;
salario = 1200.50;

// Casting
// O 'int' é um tipo de variável de 32 bits.
int salarioEmInteiro = (int)salario;
Console.WriteLine(salarioEmInteiro);

// O 'long' é um tipo de variável de 64 bits.
long idade = 1300000000000;
Console.WriteLine(idade);

short quantidadeProdutos = 12;
Console.WriteLine(quantidadeProdutos);

float altura = 1.80f;
Console.WriteLine(altura);

Console.WriteLine("Execução finalizada. Tecle 'Enter' para sair...");
Console.ReadLine();