using System;
using System.Collections.Generic;
using System.Text;
using CM.Domain.Entity;

namespace CM.Domain.Interface.Service
{
	public interface ICandidatoHabilidadeService
	{
		void Add(CandidatoHabilidade entity);

		CandidatoHabilidade GetById(int id);

		IEnumerable<CandidatoHabilidade> GetAll();

		void Update(CandidatoHabilidade entity);

		void Remove(CandidatoHabilidade entity);
	}
}
 