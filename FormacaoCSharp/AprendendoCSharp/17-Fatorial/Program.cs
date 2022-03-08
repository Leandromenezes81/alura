// See https://aka.ms/new-console-template for more information
Console.WriteLine("Executando Projeto 17 - Fatorial");
Console.WriteLine("");

int fatorial = 1;

for (int i = 1; i < 11; i++)
{
    fatorial *= i;
    Console.WriteLine($"Fatorial de {i} = {fatorial}");
}
