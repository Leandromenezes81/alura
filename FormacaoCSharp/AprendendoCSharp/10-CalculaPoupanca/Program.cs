// See https://aka.ms/new-console-template for more information

Console.WriteLine("Executando Projeto 10 - Calcula Poupança");

double valorInvestido = 1000.00;
double taxaDeJuros = 0.0036;
int contadorMes = 1;
string pluralMes;

while (contadorMes <= 12)
{
    if (contadorMes > 1)
    {
        pluralMes = "meses";
    }
    else
    {
        pluralMes = "mês";
    }
    valorInvestido = valorInvestido + valorInvestido * taxaDeJuros;

    Console.WriteLine($"Após {contadorMes} {pluralMes}, você terá R$ {valorInvestido}");

    // contadorMes = contadorMes + 1;
    // contadorMes += 1;
    contadorMes++;
}

Console.ReadLine();
