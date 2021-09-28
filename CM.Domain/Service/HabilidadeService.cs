using System;
using System.Collections.Generic;
using System.Text;
using CM.Domain.Entity;
using CM.Domain.Interface.Service;
using CM.Domain.Interface.UnitOfWork;

namespace CM.Domain.Service
{
	public class HabilidadeService : IHabilidadeService
	{
		IUnitOfWork _unit;

		public HabilidadeService(IUnitOfWork unit)
		{
			_unit = unit;
		}

		public void Add(Habilidade entity)
		{
			_unit.Habilidades.Add(entity);
			_unit.Commit();
		}

		public IEnumerable<Habilidade> GetAll()
		{
			return _unit.Habilidades.GetAll();
		}

		public Habilidade GetById(int id)
		{
			return _unit.Habilidades.GetById(id);
		}

		public void Remove(Habilidade entity)
		{
			_unit.Habilidades.Remove(entity);
			_unit.Commit();
		}

		public void Update(Habilidade entity)
		{
			_unit.Habilidades.Update(entity);
			_unit.Commit();
		}
	}
}
