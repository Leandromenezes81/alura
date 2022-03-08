// See https://aka.ms/new-console-template for more information
Console.WriteLine("Executando Projeto 11 - Calcula Poupança Dois");

double valorInvestido = 1000.00;
double taxaDeJuros = 1.0036;
string pluralMes;

for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
{
    if (contadorMes > 1)
    {
        pluralMes = "meses";
    }
    else
    {
        pluralMes = "mês";
    }
    // valorInvestido += valorInvestido * taxaDeJuros;
    valorInvestido *= taxaDeJuros;
    Console.WriteLine($"Após {contadorMes} {pluralMes}, você terá R$ {valorInvestido}");
}

Console.ReadLine();
