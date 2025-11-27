# 🧍‍♂️🧍‍♀️ Busca Linear de Pessoa por CPF --- C

Este é um projeto simples em **C#** que demonstra como realizar uma
**busca linear** em uma lista de objetos do tipo `Pessoa`, procurando
uma pessoa específica pelo CPF informado pelo usuário.

------------------------------------------------------------------------

## 📌 Objetivo

O objetivo do programa é:

-   Criar uma lista de pessoas;
-   Pedir ao usuário um CPF;
-   Percorrer a lista usando **busca linear**;
-   Exibir o nome correspondente ao CPF encontrado;
-   Caso não encontre, mostrar uma mensagem informando que o CPF não
    está cadastrado.

------------------------------------------------------------------------

## 🧠 O que é Busca Linear?

A **busca linear** é um algoritmo simples que percorre todos os
elementos de uma lista **um por um**, até encontrar o item desejado (ou
até terminar a lista).

Ela é fácil de entender e implementar, mas não é a mais rápida para
listas grandes.

------------------------------------------------------------------------

## 📂 Estrutura do Código

### Classe `Pessoa`

Representa uma pessoa com dois atributos:

``` csharp
class Pessoa
{
    public string Nome { get; set; }
    public string CPF { get; set; }
}
```

### Método `Main`

-   Cria uma lista de pessoas (`List<Pessoa>`).
-   Adiciona alguns registros manualmente.
-   Solicita um CPF ao usuário.
-   Percorre a lista e compara o CPF informado.
-   Mostra o resultado.

------------------------------------------------------------------------

## 📜 Código Completo

``` csharp
using System;
using System.Collections.Generic;

namespace buscaLinear1
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa { Nome = "Andrey", CPF = "222" });
            pessoas.Add(new Pessoa { Nome = "Pedro", CPF = "333" });
            pessoas.Add(new Pessoa { Nome = "Joao", CPF = "444" });
            pessoas.Add(new Pessoa { Nome = "Carlos", CPF = "444" });

            Console.Write("Digite o CPF: ");
            string bsCPF = Console.ReadLine();

            Pessoa pessoaEncontrada = null;
            foreach (var pessoa in pessoas)
            {
                if (pessoa.CPF == bsCPF)
                {
                    pessoaEncontrada = pessoa;
                    break;
                }
            }

            if (pessoaEncontrada != null)
            {
                Console.WriteLine($"Nome Encontrado: {pessoaEncontrada.Nome}");
            }
            else
            {
                Console.WriteLine("Pessoa nao encontrada");
            }
        }
    }
}
```

------------------------------------------------------------------------

## ▶️ Como executar

1.  Abra o projeto em um ambiente como:

    -   Visual Studio\
    -   Visual Studio Code com extensão C#
    -   Rider

2.  Compile e execute:

        dotnet run

3.  Digite um CPF cadastrado (ex.: `222`).

------------------------------------------------------------------------

## ✔️ Exemplos de uso

Entrada:

    Digite o CPF: 333

Saída:

    Nome Encontrado: Pedro

Entrada:

    Digite o CPF: 999

Saída:

    Pessoa nao encontrada
