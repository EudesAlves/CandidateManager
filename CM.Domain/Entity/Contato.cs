using System;

namespace CM.Domain.Entity
{
	public class Contato
	{
		public int ContatoId { get; set; }

		public string Telefone { get; set; }

		public string Email { get; set; }

		public string  Endereco { get; set; }

		public string LinkedinLink { get; set; }

		public string RedeSocial { get; set; }

		public int CandidatoId { get; set; }

		public virtual Candidato Candidato { get; set; }

		public DateTime DataCriacao { get; set; }
	}
}
