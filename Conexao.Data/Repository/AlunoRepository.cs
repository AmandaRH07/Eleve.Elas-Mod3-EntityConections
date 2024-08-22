using Conexao.Domain.Models;
using Conexao.Domain.Repositorios;

namespace Conexao.Data.Repository
{
	public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
	{
        public AlunoRepository(Contexto contexto) : base(contexto)
        {
            
        }
    }
}
