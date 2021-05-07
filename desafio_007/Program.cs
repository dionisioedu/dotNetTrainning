using desafio_007.DAO;
using System;
using System.Collections.Generic;

namespace desafio_007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio 007\n");

            //Desafio 007
            //Entidades: Aluno Curso Status
            //Criar Interface IDaoBase Criar DAO para cada Entidade Criar Função que Pede Nome Alunos(ReadLine) Criar Função que Pede Notas de cada Aluno Salva Tudo no MYSQL]

            Console.WriteLine("Digite o nome de cada aluno e confirme com a tecla Enter. Quando finalizar, digite Enter.");
            Console.WriteLine("Em seguida, digite a nota de cada aluno pelo nome.\n");

            List<Aluno> alunos = new();

            while (true)
			{
                string nome = Console.ReadLine();

                if (nome.Length < 1)
                    break;

                Aluno aluno = new();
                aluno.Nome = nome;
                alunos.Add(aluno);
			}

            if (alunos.Count > 1)
			{
                for (int i = 0; i < alunos.Count; i++)
				{
                    Console.WriteLine("Digite a nota do aluno {0}:", alunos[i].Nome);
                    var str_nota = Console.ReadLine();

                    _ = double.TryParse(str_nota, out double nota);
                    alunos[i].UltimaNota = nota;
				}
			}

            IDaoBase daoBase = new DaoBaseImpl();

            daoBase.Alunos().SalvarLista(alunos);
        }
    }
}
