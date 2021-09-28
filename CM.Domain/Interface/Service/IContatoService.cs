using System;
using System.Collections.Generic;
using System.Text;
using CM.Domain.Entity;

namespace CM.Domain.Interface.Service
{
	public interface IContatoService
	{
		void Add(Contato entity);

		Contato GetById(int id);

		IEnumerable<Contato> GetAll();

		void Update(Contato entity);

		void Remove(Contato entity);
	}
}
