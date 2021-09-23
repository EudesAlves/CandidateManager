using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions;
using CM.Domain.Entity;
using CM.Infrastructure.EntityConfig;

namespace CM.Infrastructure.Data
{
	public class CMContext : DbContext
	{
		public DbSet<Candidato> Candidatos { get; set; }
		public DbSet<Contato> Contatos { get; set; }
		public DbSet<Habilidade> Habilidades { get; set; }
		public DbSet<CandidatoHabilidade> CandidatoHabilidades { get; set; }

		public CMContext(DbContextOptions<CMContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			modelBuilder.ApplyConfiguration(new CandidatoConfiguration());
			modelBuilder.ApplyConfiguration(new HabilidadeConfiguration());
			modelBuilder.ApplyConfiguration(new CandidatoHabilidadeConfiguration());
			modelBuilder.ApplyConfiguration(new ContatoConfiguration());
			base.OnModelCreating(modelBuilder);
		}
		
	}
}
