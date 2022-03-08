// See https://aka.ms/new-console-template for more information
Console.WriteLine("Executando Projeto 07 - Condicionais.");

int idadeJoao = 16;

int quantidadePessoas = 1;

if (idadeJoao >= 18)
{
    Console.WriteLine("João possui mais que 18 anos. Pode entrar...");
}
else
{
    if (quantidadePessoas >= 2)
    {
        Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado. Pode entrar...");
    }
    else
    {
        Console.WriteLine("João não possui mais de 18 anos. Não pode entrar...");
    }
}

Console.WriteLine("Execução finalizada. Tecle 'Enter' para sair...");
Console.ReadLine();
