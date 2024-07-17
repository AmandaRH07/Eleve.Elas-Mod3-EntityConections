using Conexao.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conexao.Data.Map
{
	public class AlunoMap : IEntityTypeConfiguration<Aluno>
	{
		public void Configure(EntityTypeBuilder<Aluno> builder)
		{
			builder.ToTable("Aluno");

			builder.HasKey(x => x.Id);

			builder.Property(x => x.Nome)
				.HasColumnType("nvarchar(150)")
				.IsRequired();

			builder.Property(x => x.Ativo)
				.IsRequired();
		}
	}
}
