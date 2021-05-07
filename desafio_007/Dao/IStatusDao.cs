using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_007.DAO
{
	public interface IStatusDao
	{
		bool NovoStatus(Status status);
		Status CarregaStatus(int id);
		bool AtualizaStatus(Status status);
		bool DeletaStatus(Status status);
		List<Status> CarregaStatus();
	}
}
