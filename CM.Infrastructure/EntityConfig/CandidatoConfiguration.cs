using CM.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CM.Infrastructure.EntityConfig
{
	public class CandidatoConfiguration : IEntityTypeConfiguration<Candidato>
	{
		public void Configure(EntityTypeBuilder<Candidato> builder)
		{
			builder.ToTable("Candidato");
			builder.HasKey(e => e.CandidatoId);

			builder.Property(e => e.Nome)
				.HasColumnType("varchar(100)");
			builder.Property(e => e.Sobrenome)
				.HasColumnType("varchar(100)");
			builder.Property(e => e.Rg)
				.HasColumnType("varchar(15)");
			builder.Property(e => e.Cpf)
				.HasColumnType("varchar(15)");
			builder.Property(e => e.CarteiraTrabalho)
				.HasColumnType("varchar(15)");
			builder.Property(e => e.CarteiraTrabalhoSerie)
				.HasColumnType("varchar(15)");
			builder.Property(e => e.CarteiraTrabalhoUf)
				.HasColumnType("varchar(2)");
		}
	}
}
