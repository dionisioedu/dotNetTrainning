using System;

namespace desafio_002
{
    public class Pessoa
    {
        public String Nome { get; }
        public int Idade { get; }
        public String Sexo { get; }

        public Pessoa(String nome, int idade, String sexo) {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
        }

		public override string ToString()
		{
            return String.Format("{0} - {1} - {2}", Nome, Idade, Sexo);
		}

		public static void PrintPessoa(Pessoa pessoa) {
            Console.WriteLine(pessoa.ToString());
        }
    }
}