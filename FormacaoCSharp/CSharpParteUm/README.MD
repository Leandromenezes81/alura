#Formação C# e Orientação a Objetos

##Curso C# - Parte 1

###1. História e ecossistema da linguagem

Aula 2 - Qual é o grande benefício de uma Maquina Virtual .NET (CLR - common language runtime)?

No mundo .NET você terá sempre o mesmo MSIL que será executado pela Maquina Virtual CLR, independente do sistema operacional. Assim não é preciso rescrever ou adaptar o código para rodar em um outro sistema operacional ou integrar em um projeto escrito com outra linguagem .NET.

seja web ou puramente server-side, aplicativo móveis ou um jogos, o C# atende todas essas áreas! No entanto, os sistemas web e desktop são os que mais fizeram sucesso no mundo C# e mais empregam desenvolvedores.

Qualquer aplicação escrita em uma linguagem .NET (aquelas que são compiladas para MSIL) podem usar o .NET Framework.

- Toda aplicação .NET é escrita em uma linguagem compilada para o código intermediário MSIL (Microsoft intermediate language);
- O .NET Framework é uma biblioteca utilizada pelas aplicações .NET;
- Uma aplicação .NET é compilada para o MSIL;
- O código MSIL é executado pela máquina virtual do .NET, a CLR (common language runtime);
- O just-in-time compiler é uma parte da CLR que transforma MSIL em código de máquina, apenas em tempo de execução.

Sobre a compilação e execução de código C#:

1 - Durante a compilação acontece uma verificação sintática do código fonte.

2 - Na compilação e execução podem aparecer erros.

3 - Quando executamos o programa compilado, a CLR lê e executa o código MSIL gerado.

4 - O compilador gera o MSIL caso não tenha nenhum erro sintático no código fonte.

###2. Nosso primeiro programa e o Visual Studio (A)
