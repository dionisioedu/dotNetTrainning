using System;

namespace desafio_004
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ALUNOS_QTD = 3;

            Console.WriteLine("Soma Notas\n==========\n\n");
            Aluno[] alunos = new Aluno[ALUNOS_QTD];

            for (int i = 0; i < ALUNOS_QTD; i++)
			{
                Console.WriteLine("Digite o nome do aluno numero {0}:", i + 1);
                String nome = Console.ReadLine();
                Console.WriteLine("Digite a idade do aluno numero {0}:", i + 1);
                String idade = Console.ReadLine();
                Console.WriteLine("Digite a nota do aluno numero {0}:", i + 1);
                String nota = Console.ReadLine();

                alunos[i] = new Aluno();
                alunos[i].Nome = nome;
                Int32.TryParse(idade, out int out_idade);
                alunos[i].Idade = out_idade;
                Double.TryParse(nota, out double out_nota);
                alunos[i].Nota = out_nota;
			}

            double soma = 0;

            foreach (var aluno in alunos)
			{
                soma += aluno.Nota;
			}

            Console.WriteLine("Soma das notas: {0}\n", soma);
        }
    }
}
