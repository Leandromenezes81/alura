// See https://aka.ms/new-console-template for more information
Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

// Um elemento do tipo char é inserido entre aspas simples.
char letra = 'a';
Console.WriteLine(letra);

// Casting
letra = (char)65;
Console.WriteLine(letra);

letra = (char)(65 + 1);
Console.WriteLine(letra);

letra = (char)(86 + 1);
Console.WriteLine(letra);

// O espaço no final da frase é reconhecido como um caractere
string primeiraFrase = "Alura - Cursos de Tecnologia ";
Console.WriteLine(primeiraFrase + 2022);

// O exemplo abaixo representa uma string vazia
string vazia = "";
Console.WriteLine(vazia);

// @ antes das "" permite que os elementos da lista sejam reconhecidos dentro de uma string
string cursos = @"Cursos disponíveis:
- Go
- C#
- Python
- Java";
Console.WriteLine(cursos);

Console.WriteLine("Tecle para sair...");
Console.ReadLine();