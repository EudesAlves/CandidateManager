using CM.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CM.Infrastructure.EntityConfig
{
	public class HabilidadeConfiguration : IEntityTypeConfiguration<Habilidade>
	{
		public void Configure(EntityTypeBuilder<Habilidade> builder)
		{
			builder.ToTable("Habilidade");
			builder.HasKey(e => e.HabilidadeId);

			builder.Property(e => e.Tag)
				.HasColumnType("varchar(100)");
		}
	}
}
