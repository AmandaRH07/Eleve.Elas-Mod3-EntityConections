using Conexao.Domain.Models;

namespace Conexao.Data.Repository
{
	public class AlunoRepository
	{
        protected readonly Contexto contexto;

        public AlunoRepository()
        {
            contexto = new Contexto();
        }

        public List<Aluno> SelecionarTudo()
        {
            return contexto.Aluno.ToList();
        }


        public void Incluir(Aluno aluno)
        {
            contexto.Aluno.Add(aluno);
            contexto.SaveChanges();
        }

        public void Alterar(Aluno aluno)
        {
            contexto.Aluno.Update(aluno);
            contexto.SaveChanges();
        }

        public Aluno SelecionarPorId(int id)
        {
            return contexto.Aluno.Find(id);
        }

        public void Excluir(int id)
        {
            var aluno = SelecionarPorId(id);
            contexto.Aluno.Remove(aluno);
            contexto.SaveChanges();
        }

		public void Dispose()
		{
            contexto.Dispose();
	    }
	}
}
