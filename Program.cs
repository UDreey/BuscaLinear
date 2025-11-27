using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine($"Nome Encontrado: {pessoaEncontrada.Nome} ");
            }
            else {

                Console.WriteLine("Pessoa nao encontrada");
            }
            
        }
    }
}
