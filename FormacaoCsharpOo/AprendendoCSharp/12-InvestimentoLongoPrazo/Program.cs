Console.WriteLine("Executando o projeto 12 - Investindo a longo prazo.");

double fatorRendimento = 1.005;
double investimento = 1000;
int anos;

for (anos = 1; anos <= 5; anos++)
{
    for (int mes = 1; mes <= 12; mes++)
    {
        investimento *= fatorRendimento;
    }

    fatorRendimento += 0.001;
}
anos -= 1;

Console.WriteLine($"Depois de {anos} anos você terá R$ {investimento}");

Console.WriteLine("Tecle enter para fechar ...");
Console.ReadLine();