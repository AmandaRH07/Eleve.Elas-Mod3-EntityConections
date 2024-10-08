﻿using Conexao.Data.Map;
using Conexao.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Conexao.Data
{
	public class Contexto : DbContext
	{
		public DbSet<Aluno> Aluno { get; set; }
		public DbSet<Professor> Professor { get; set; }
		public DbSet<Turma> Turma { get; set; }
		public DbSet<TurmaAluno> TurmaAluno { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //	optionsBuilder.UseSqlServer("Server=localhost;Database=AmbevConexao;Trusted_Connection=True;TrustServerCertificate=True")
        //		.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        //	base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AlunoMap());
			modelBuilder.ApplyConfiguration(new ProfessorMap());
			modelBuilder.ApplyConfiguration(new TurmaMap());
			modelBuilder.ApplyConfiguration(new TurmaAlunoMap());

			base.OnModelCreating(modelBuilder);
		}
	}
}
