using Conexao.API.Dto;
using Conexao.Data.Repository;
using Conexao.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Conexao.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AlunoController : ControllerBase
	{
		private readonly AlunoRepository _repository;
        public AlunoController()
        {
			_repository = new AlunoRepository();
        }

		[HttpGet]
		public IEnumerable<Aluno> Get()
		{
			return _repository.SelecionarTudo();
		}

		[HttpGet("{id}")]
		public Aluno Get(int id)
		{
			return _repository.Selecionar(id);
		}

		[HttpPost]
		public IEnumerable<Aluno> Post([FromBody] AlunoDto alunoDto)
		{
			var entity = Aluno.NovoAluno(alunoDto.Nome);

			_repository.Incluir(entity);
			return _repository.SelecionarTudo();
		}

		[HttpPut("{id}")]
		public Aluno Put(int id, [FromBody] AlunoDto alunoDto)
		{
			var entity = _repository.Selecionar(id);

			entity.AlterarNome(alunoDto.Nome);
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
