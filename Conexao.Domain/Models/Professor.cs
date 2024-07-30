using Conexao.Domain.Models.Enum;

namespace Conexao.Domain.Models
{
	public class Professor
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public Turno Turno { get; set; }
		public string Banco { get; set; }
		public string Agencia { get; set; }
		public string Conta { get; set; }

		public List<Turma> Turmas { get; set; }

		public static Professor NovoProfessor(string nome, string email, Turno turno, string banco, string agencia, string conta)
		{
			var professor = new Professor();
			professor.Nome = nome;
			professor.Email = email;
			professor.Turno = turno;
			professor.Banco = banco;
			professor.Agencia = agencia;
			professor.Conta = conta;

			return professor;
		}

		public Professor AlterarNome(string novoNome)
		{
			Nome = novoNome;
			return this;
		}

	}
}
