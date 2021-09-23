using CM.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CM.Infrastructure.EntityConfig
{
	public class ContatoConfiguration : IEntityTypeConfiguration<Contato>
	{
		public void Configure(EntityTypeBuilder<Contato> builder)
		{
			builder.ToTable("Contato");
			builder.HasKey(e => e.ContatoId);

			builder.Property(e => e.Telefone)
				.HasColumnType("varchar(30)");
			builder.Property(e => e.Email)
				.HasColumnType("varchar(60)");
			builder.Property(e => e.Endereco)
				.HasColumnType("varchar(400)");
			builder.Property(e => e.LinkedinLink)
				.HasColumnType("varchar(400)");
			builder.Property(e => e.RedeSocial)
				.HasColumnType("varchar(400)");
		}
	}
}
