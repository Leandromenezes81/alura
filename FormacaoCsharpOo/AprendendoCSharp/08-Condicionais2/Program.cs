class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 8 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        // bool grupo = false;

        // || - Operadoe correspondente a 'OU'
        // && - Operador correspondente a 'E'
        // == - Operador corresponte a 'IGUAL'

        // if (idadeJoao >= 18 && quantidadePessoas > 1)
        // if (idadeJoao >= 18 || quantidadePessoas > 1)
        // if (idadeJoao >= 18 || grupo)
        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}