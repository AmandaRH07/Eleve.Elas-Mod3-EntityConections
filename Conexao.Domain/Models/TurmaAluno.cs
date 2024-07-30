namespace Conexao.Domain.Models
{
	public class TurmaAluno
	{
        public int Id { get; set; }
        public int IdAluno { get; set; }
        public int IdTurma { get; set; }
        public Turma Turma { get; set; }
        public Aluno Aluno { get; set; }
    }
}
