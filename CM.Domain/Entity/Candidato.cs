using System;
using System.Collections.Generic;

namespace CM.Domain.Entity
{
	public class Candidato
	{
		public int CandidatoId { get; set; }

		public string Nome { get; set; }

		public string Sobrenome { get; set; }

		public string Rg { get; set; }

		public string Cpf { get; set; }

		public DateTime Nascimento { get; set; }

		public string CarteiraTrabalho { get; set; }

		public string CarteiraTrabalhoSerie { get; set; }

		public string CarteiraTrabalhoUf { get; set; }

		public IEnumerable<CandidatoHabilidade> CandidatoHabilidades { get; set; }

		public DateTime DataCriacao { get; set; }
	}
}
