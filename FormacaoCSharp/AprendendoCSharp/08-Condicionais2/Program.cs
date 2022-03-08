// See https://aka.ms/new-console-template for more information
Console.WriteLine("Executando Projeto 08 - Condicionais 02.");

int idadeJoao = 16;
//int quantidadePessoas = 2;

//bool acompanhado = quantidadePessoas >= 2;
bool acompanhado = true;

// if (idadeJoao >= 18 || quantidadePessoas >= 2)
if (idadeJoao >= 18 && acompanhado == true)
{
    Console.WriteLine("Pode entrar...");
}
else
{
    Console.WriteLine("Não pode entrar");
}

Console.WriteLine("Execução finalizada. Tecle 'Enter' para sair...");
Console.ReadLine();
