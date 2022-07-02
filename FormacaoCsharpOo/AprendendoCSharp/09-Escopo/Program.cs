class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 9 - Escopo");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        // A variável 'textoAdicional', declarada fora de blocos
        // com chaves pertence ao escopo principal.
        string textoAdicional;

        if (acompanhado == true)
        {
            // A variável 'textoAdicional', declarada dentro de blocos
            // com chaves pertence ao escopo dentro delas.
            textoAdicional = "João está acompanhado. ;D";
        }
        // Quando if/else executarem apenas uma tarefa, o uso de chave é
        // dispensável.
        else
            textoAdicional = "João não está acompanhado. :C";


        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não pode entrar!");
        }

        // Outra implementação...

        int idades = 20;
        int quantidadePessoa = 3;

        bool acompanhados;

        if (quantidadePessoa >= 2)
        {
            acompanhados = true;
        }
        else
        {
            acompanhados = false;
        }

        if (idades >= 18 || acompanhados)
        {
            Console.WriteLine("Seja bem vindo");
        }
        else
        {
            Console.WriteLine("infelizmente voce nao pode entrar");
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}