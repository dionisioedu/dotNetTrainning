using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_007.DAO
{
	public interface IAlunosDao
	{
		bool NovoAluno(Aluno aluno);
		bool AlteraAluno(Aluno aluno);
		bool DeletaAluno(Aluno aluno);
		Aluno CarregaAluno(int id);
		List<Aluno> CarregaAlunos();
		bool SalvarLista(List<Aluno> alunos);
	}
}
