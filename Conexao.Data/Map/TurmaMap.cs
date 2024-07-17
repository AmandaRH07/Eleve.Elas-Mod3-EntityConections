using Conexao.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conexao.Data.Map
{
	public class TurmaMap : IEntityTypeConfiguration<Turma>
	{
		public void Configure(EntityTypeBuilder<Turma> builder)
		{
			builder.ToTable("Turma");

			builder.HasKey(x => x.Id);

			builder.Property(x => x.Nome)
				.HasColumnType("nvarchar(100)")
				.IsRequired();

			builder.Property(x => x.Descricao)
				.HasColumnType("nvarchar(500)")
				.IsRequired();

			builder.HasOne(x => x.Professor)
				.WithMany(tp => tp.Turmas)
				.HasForeignKey(p => p.IdProfessor);
		}
	}
}
