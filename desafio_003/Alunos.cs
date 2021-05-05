using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_003
{
	public class Alunos
	{
		String Nome;
		double Nota;

		private static int Quantidade { get; set; }
		private static readonly List<Alunos> ListaDeAlunos = new List<Alunos>();

		public override string ToString()
		{
			return String.Format("{0} - {1}", Nome, Nota);
		}

		public static void TotalDeAlunos(int quantidade)
		{
			Quantidade = quantidade;
		}

		public static int TotalDeAlunos()
		{
			return Quantidade;
		}

		public static void AdicionaAluno(String nome, double nota)
		{
			ListaDeAlunos.Add(new Alunos
			{
				Nome = nome,
				Nota = nota
			});
		}

		public static String MaiorNota()
		{
			Alunos maiorNota = ListaDeAlunos[0];

			if (ListaDeAlunos.Count > 1)
			{
				for (int aluno = 1; aluno < ListaDeAlunos.Count; aluno++)
				{
					if (ListaDeAlunos[aluno].Nota > maiorNota.Nota)
					{
						maiorNota = ListaDeAlunos[aluno];
					}
				}
			}

			return maiorNota.ToString();
		}
	}
}
