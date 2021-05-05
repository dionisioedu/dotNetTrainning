using System;

namespace desafio_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a quantidade de alunos?");
            String quantidade = Console.ReadLine();

            Alunos.TotalDeAlunos(Int32.Parse(quantidade));

            for (int aluno = 0; aluno < Alunos.TotalDeAlunos(); aluno++)
			{
                Console.WriteLine("Qual o nome do aluno de numero {0} ?", aluno + 1);
                String nome = Console.ReadLine();
                Console.WriteLine("Qual a nota do aluno de numero {0} ?", aluno + 1);
                String nota = Console.ReadLine();

				_ = double.TryParse(nota, out double double_nota);

				Alunos.AdicionaAluno(nome, double_nota);
			}

            Console.WriteLine("O aluno com a maior nota e {0}", Alunos.MaiorNota());
        }
    }
}
