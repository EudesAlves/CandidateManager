using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions;
using CM.Domain.Entity;

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
			
		}
		
	}
}
