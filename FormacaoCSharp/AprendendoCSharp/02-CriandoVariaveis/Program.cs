// See https://aka.ms/new-console-template for more information
Console.WriteLine("Executando Projeto 02 - Criando Variáveis.");

int idade;

idade = 32;

Console.WriteLine($"Sua idade é: {idade}.");

idade = 10;
Console.WriteLine("Sua idade é: " + idade);

idade = idade + 5;
Console.WriteLine($"Sua idade é: {idade}.");

idade = 10 + 5 * 2;
Console.WriteLine($"Sua idade é: {idade}.");

idade = (10 + 5) * 2;
Console.WriteLine("Sua idade é: " + idade);

Console.WriteLine("Execução finalizada. Tecle 'Enter' para sair...");
Console.ReadLine();
