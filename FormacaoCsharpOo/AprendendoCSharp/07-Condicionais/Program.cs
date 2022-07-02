// See https://aka.ms/new-console-template for more information
Console.WriteLine("Executando o projeto 7 - Condicionais");

int idadeJoao = 16;
int quantidadePessoas = 2;

if (idadeJoao >= 18)
{
    Console.WriteLine("Entrada autorizada.");
}
else
{
    if (quantidadePessoas > 0)
    {
        Console.WriteLine("Ele está acompanhado. Entrada autorizada.");
    }
    else
    {
        Console.WriteLine("Entrada não autorizada.");
    }
}

Console.WriteLine("Tecle para sair...");
Console.ReadLine();