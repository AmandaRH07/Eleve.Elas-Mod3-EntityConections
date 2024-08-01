using Conexao.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Conexao.Data.Repository
{
	public class TurmaAlunoRepository : BaseRepository<TurmaAluno>
	{
		public List<TurmaAluno> SelecionarTudoCompleto()
		{
			return contexto.TurmaAluno
				.Include(x => x.Aluno)
				.Include(x => x.Turma)
				.ToList();
		}
	}
}
