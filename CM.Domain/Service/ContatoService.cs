using System;
using System.Collections.Generic;
using System.Text;
using CM.Domain.Entity;
using CM.Domain.Interface.Service;
using CM.Domain.Interface.UnitOfWork;

namespace CM.Domain.Service
{
	public class ContatoService : IContatoService
	{
		IUnitOfWork _unit;

		public ContatoService(IUnitOfWork unit)
		{
			_unit = unit;
		}

		public void Add(Contato entity)
		{
			_unit.Contatos.Add(entity);
			_unit.Commit();
		}

		public IEnumerable<Contato> GetAll()
		{
			return _unit.Contatos.GetAll();
		}

		public Contato GetById(int id)
		{
			return _unit.Contatos.GetById(id);
		}

		public void Remove(Contato entity)
		{
			_unit.Contatos.Remove(entity);
			_unit.Commit();
		}

		public void Update(Contato entity)
		{
			_unit.Contatos.Update(entity);
			_unit.Commit();
		}
	}
}
