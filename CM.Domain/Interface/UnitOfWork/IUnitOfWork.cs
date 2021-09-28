using System;
using System.Collections.Generic;
using System.Text;
using CM.Domain.Interface.Repository;

namespace CM.Domain.Interface.UnitOfWork
{
	public interface IUnitOfWork : IDisposable
	{
		ICandidatoRepository Candidatos { get; set; }

		IHabilidadeRepository Habilidades { get; set; }

		IContatoRepository Contatos { get; set; }

		ICandidatoHabilidadeRepository CandidatoHabilidades { get; set; }

		void Commit();
	}
}
