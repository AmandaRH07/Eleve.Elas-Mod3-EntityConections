using Conexao.API.Dto;
using Conexao.Domain.Models;
using Conexao.Domain.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Conexao.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProfessorController : ControllerBase
	{
		private readonly IProfessorRepository _repository;
		public ProfessorController(IProfessorRepository repository)
		{
			_repository = repository;
		}

		[HttpGet]
		public IEnumerable<Professor> Get()
		{
			return _repository.SelecionarTudo();
		}

		[HttpGet("{id}")]
		public Professor Get(int id)
		{
			return _repository.Selecionar(id);
		}

		[HttpPost]
		public IEnumerable<Professor> Post([FromBody] ProfessorDto professorDto)
		{
			var entity = Professor.NovoProfessor(professorDto.Nome, professorDto.Email, professorDto.Turno);

			_repository.Incluir(entity);
			return _repository.SelecionarTudo();
		}

		[HttpPut("{id}")]
		public Professor Put(int id, [FromBody] ProfessorDto professorDto)
		{
			var entity = _repository.Selecionar(id);

			entity.AlterarNome(professorDto.Nome);
			_repository.Alterar(entity);

			return entity;
		}

		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_repository.Excluir(id);
		}
	}
}
