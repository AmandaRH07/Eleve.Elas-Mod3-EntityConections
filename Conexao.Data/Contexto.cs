using Conexao.Data.Map;
using Conexao.Domain.Models;
using Microsoft.EntityFrameworkCore;
namespace Conexao.Data
{
	public class Contexto : DbContext
	{
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Turma> Turma { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost;Database=AmbevConexao;Trusted_Connection=True;TrustServerCertificate=True");
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AlunoMap());
			modelBuilder.ApplyConfiguration(new ProfessorMap());
			modelBuilder.ApplyConfiguration(new TurmaMap());

			base.OnModelCreating(modelBuilder);
		}
	}
}
