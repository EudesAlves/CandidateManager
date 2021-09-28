using System;
using System.Collections.Generic;
using System.Text;
using CM.Domain.Entity;
using CM.Domain.Interface.Service;
using CM.Domain.Interface.UnitOfWork;

namespace CM.Domain.Service
{
	public class CandidatoHabilidadeService : ICandidatoHabilidadeService
	{
		IUnitOfWork _unit;

		public CandidatoHabilidadeService(IUnitOfWork unit)
		{
			_unit = unit;
		}

		public void Add(CandidatoHabilidade entity)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<CandidatoHabilidade> GetAll()
		{
			throw new NotImplementedException();
		}

		public CandidatoHabilidade GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Remove(CandidatoHabilidade entity)
		{
			throw new NotImplementedException();
		}

		public void Update(CandidatoHabilidade entity)
		{
			throw new NotImplementedException();
		}
	}
}
