using System;

namespace desafio_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            String nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");
            String idade = Console.ReadLine();

            Console.WriteLine("Qual a sua oritentacao sexual?");
            String sexo = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome, Int32.Parse(idade), sexo);
            Pessoa.PrintPessoa(pessoa);
        }
    }
}
