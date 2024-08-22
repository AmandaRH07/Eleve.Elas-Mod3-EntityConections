using Conexao.Domain.Models;
using Conexao.Domain.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace Conexao.Data.Repository
{
	public class TurmaAlunoRepository : BaseRepository<TurmaAluno>, ITurmaAlunoRepository
	{
		public TurmaAlunoRepository(Contexto contexto) : base(contexto)
		{
		}

		public List<TurmaAluno> SelecionarTudoCompleto()
		{
			return _contexto.TurmaAluno
				.Include(x => x.Aluno)
				.Include(x => x.Turma)
				.ToList();
		}
	}
}
