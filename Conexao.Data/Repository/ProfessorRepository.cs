using Conexao.Domain.Models;
using System.Net.NetworkInformation;

namespace Conexao.Data.Repository
{
	public class ProfessorRepository
	{
		protected readonly Contexto contexto;

		public ProfessorRepository()
		{
			contexto = new Contexto();
		}


		public List<Professor> SelecionarTudo()
		{
			return contexto.Professor.ToList(); 
		}

		public void Incluir(Professor professor)
		{
			contexto.Professor.Add(professor);
			contexto.SaveChanges();
		}

		public void Alterar(Professor professor)
		{
			contexto.Professor.Update(professor);
			contexto.SaveChanges();
		}

		public Professor SelecionarPorId(int id)
		{
			return contexto.Professor.Find(id);
		}

		public void Excluir(int id)
		{
			var professor = SelecionarPorId(id);
			contexto.Professor.Remove(professor);
			contexto.SaveChanges();
		}

		public void Dispose()
		{
			contexto.Dispose();
		}

		//selecionar por id
		//exlcuir
	}
}
