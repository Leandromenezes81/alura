// See https://aka.ms/new-console-template for more information

Console.WriteLine("Executando Projeto 15 - Laço de Repeticão FOR");
Console.WriteLine("");

for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine(contador);
}

Console.WriteLine("");
Console.WriteLine("Gerando Tabuada com FOR");
Console.WriteLine("");

for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
{
    for (int contador = 0; contador <= 10; contador++)
    {
        Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("");
Console.WriteLine("Gerando Matriz com FOR");
Console.WriteLine("");

for (int linha = 0; linha < 10; linha++)
{
    for (int coluna = 0; coluna <= linha; coluna++)
    {
        //for (int coluna = 0; coluna < 10; coluna++)
        //{
        //    if (coluna > linha)
        //    {
        //        break;
        //    }
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.ReadLine();