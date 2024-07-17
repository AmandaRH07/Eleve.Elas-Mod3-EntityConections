using Conexao.Data.Map;
using Conexao.Domain.Models;
using Microsoft.EntityFrameworkCore;
namespace Conexao.Data
{
	public class Contexto : DbContext
	{
        public DbSet<Aluno> Aluno { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost;Database=AmbevConexao;Trusted_Connection=True;TrustServerCertificate=True");
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AlunoMap());

			base.OnModelCreating(modelBuilder);
		}
	}
}
