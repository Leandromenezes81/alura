Console.WriteLine("Executando o projeto 13 - Encadeando FOR.");

for (int contadorDeLinhas = 0; contadorDeLinhas < 10; contadorDeLinhas++)
{
    for (int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
    {
        Console.Write("*");
        if (contadorColunas >= contadorDeLinhas)
            break;
    }
    Console.WriteLine();
}

for (int contadorDeLinhas = 0; contadorDeLinhas < 10; contadorDeLinhas++)
{
    for (int contadorColunas = 0; contadorColunas <= contadorDeLinhas; contadorColunas++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

// Multiplos de 3
for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}

// Fatorial de 10
int fatorial = 1;

for (int i = 1; i < 11; i++)
{
    fatorial *= i;
    Console.WriteLine("Fatorial de " + i + " = " + fatorial);
}


Console.WriteLine("Tecle enter para fechar ...");
Console.ReadLine();