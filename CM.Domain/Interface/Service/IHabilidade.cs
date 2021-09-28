using System;
using System.Collections.Generic;
using System.Text;
using CM.Domain.Entity;

namespace CM.Domain.Interface.Service
{
	public interface IHabilidadeService
	{
		void Add(Habilidade entity);

		Habilidade GetById(int id);

		IEnumerable<Habilidade> GetAll();

		void Update(Habilidade entity);

		void Remove(Habilidade entity);
	}
}
