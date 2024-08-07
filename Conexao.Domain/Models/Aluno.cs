namespace Conexao.Domain.Models
{
	public class Aluno : IEntity
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public bool Ativo { get; set; }
        public List<TurmaAluno> TurmaAluno { get; set; }

		public static Aluno NovoAluno(string nome)
		{
			var aluno = new Aluno();
			aluno.Nome = nome;
			aluno.Ativo = true;
			return aluno;
		}

		public Aluno AlterarNome(string novoNome)
		{
			Nome = novoNome;
			return this;
		}
	}
}
