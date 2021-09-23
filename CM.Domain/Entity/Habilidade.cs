using System;
using System.Collections.Generic;

namespace CM.Domain.Entity
{
	public class Habilidade
	{
		public int HabilidadeId { get; set; }

		public string Tag { get; set; }

		public virtual IEnumerable<CandidatoHabilidade> CandidatoHabilidades { get; set; }

		public DateTime DataCriacao { get; set; }
	}
}
