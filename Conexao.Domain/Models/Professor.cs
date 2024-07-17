using Conexao.Domain.Models.Enum;

namespace Conexao.Domain.Models
{
	internal class Professor
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public Turno Turno { get; set; }
		public string Banco { get; set; }
		public string Agencia { get; set; }
		public string Conta { get; set; }
	}
}
