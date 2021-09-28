using System;
using System.Collections.Generic;
using System.Text;
using CM.Domain.Entity;
using CM.Domain.Interface.Service;
using CM.Domain.Interface.UnitOfWork;

namespace CM.Domain.Service
{
	public class CandidatoService : ICandidatoService
	{
		IUnitOfWork _unit;

		public CandidatoService(IUnitOfWork unit)
		{
			_unit = unit;
		}

		public void Add(Candidato entity)
		{
			_unit.Candidatos.Add(entity);
			_unit.Commit();
		}

		public IEnumerable<Candidato> GetAll()
		{
			return _unit.Candidatos.GetAll();
		}

		public Candidato GetById(int id)
		{
			return _unit.Candidatos.GetById(id);
		}

		public void Remove(Candidato entity)
		{
			_unit.Candidatos.Remove(entity);
			_unit.Commit();
		}

		public void Update(Candidato entity)
		{
			_unit.Candidatos.Update(entity);
			_unit.Commit();
		}
	}
}
