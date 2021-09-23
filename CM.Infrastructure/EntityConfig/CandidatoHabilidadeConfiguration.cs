using System;
using System.Collections.Generic;
using System.Text;
using CM.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CM.Infrastructure.EntityConfig
{
	public class CandidatoHabilidadeConfiguration : IEntityTypeConfiguration<CandidatoHabilidade>
	{
		public void Configure(EntityTypeBuilder<CandidatoHabilidade> builder)
		{
			builder.ToTable("CandidatoHabilidade");
			builder.HasKey(e => e.CandidadoHabilidadeId);

			builder
				.HasOne(e => e.Candidato)
				.WithMany(c => c.CandidatoHabilidades)
				.HasForeignKey(e => e.CandidatoId);
			builder
				.HasOne(e => e.Habilidade)
				.WithMany(h => h.CandidatoHabilidades)
				.HasForeignKey(e => e.HabilidadeId);
		}
	}
}
