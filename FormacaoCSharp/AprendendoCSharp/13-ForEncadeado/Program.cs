// See https://aka.ms/new-console-template for more information

Console.WriteLine("Executando Projeto 13 - For Encadeado");

// *
// **
// ***
// ****
// *****
// ******
// *******
// ********
// *********
// **********

// Escrevendo asterisco com o BREAK
for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
    for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
    {
        Console.Write("*");
        if (contadorColuna >= contadorLinha)
            break;
    }
    Console.WriteLine();
}

// Uma forma diferente de fazer o desenho de asteríscos
for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
    for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.ReadLine();