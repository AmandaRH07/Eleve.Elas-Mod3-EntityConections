using Conexao.Data.Repository;
using Conexao.Domain.Models;
using Conexao.Domain.Models.Enum;
using System.Runtime.CompilerServices;

class Program
{
	static void Main(string[] args)
	{
		//IncluirAluno();

		//var alunos = ConsultarTodosAlunos();
		//if(alunos?.Count > 0)
		//{
		//	AlterarNomeAluno(alunos[0]);
		//	ExcluirAluno(alunos[1].Id);
		//}

		//IncluirProfessor();

		//var professores = ConsultarTodosProfessores();
		//if (professores?.Count > 0)
		//{
		//	AlterarNomeProfessor(professores[0]);
		//	ExcluirProfessor(professores[1].Id);
		//}

		SelecionarTurmaAluno();
	}

	private static void IncluirAluno()
	{
		var repository = new AlunoRepository();
		repository.Incluir(Aluno.NovoAluno("Ana"));
		repository.Incluir(Aluno.NovoAluno("José"));
	}

	private static void AlterarNomeAluno(Aluno aluno)
	{
		var repository = new AlunoRepository();
		repository.Alterar(aluno.AlterarNome("Ana Silva"));
	}

	private static List<Aluno> ConsultarTodosAlunos()
	{
		var repository = new AlunoRepository();
		return repository.SelecionarTudo();
	}

	private static void ExcluirAluno(int id)
	{
		var repository = new AlunoRepository();
		repository.Excluir(id);
	}

	private static void IncluirProfessor()
	{
		var repository = new ProfessorRepository();
		repository.Incluir(Professor.NovoProfessor("João", "joao@mail.com", Turno.Manha, "caixa", "123", "456"));
		repository.Incluir(Professor.NovoProfessor("Maria", "maria@mail.com", Turno.Tarde, "caixa", "189", "012"));
	}

	private static void AlterarNomeProfessor(Professor professor)
	{
		var repository = new ProfessorRepository();
		repository.Alterar(professor.AlterarNome("João Souza"));
	}

	private static List<Professor> ConsultarTodosProfessores()
	{
		var repository = new ProfessorRepository();
		return repository.SelecionarTudo();
	}

	private static void ExcluirProfessor(int id)
	{
		var repository = new ProfessorRepository();
		repository.Excluir(id);
	}

	private static void SelecionarTurmaAluno()
	{
		TurmaAlunoRepository repository = new TurmaAlunoRepository();
		var dados = repository.SelecionarTudo();
		var dadosCompletos = repository.SelecionarTudoCompleto();
	}
}