using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Domain.Entity
{
	public class CandidatoHabilidade
	{
		public int CandidadoHabilidadeId { get; set; }

		public int CandidatoId { get; set; }

		public Candidato Candidato { get; set; }

		public int HabilidadeId { get; set; }

		public Habilidade Habilidade { get; set; }
	}
}
