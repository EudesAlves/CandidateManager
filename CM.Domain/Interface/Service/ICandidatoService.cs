using System;
using System.Collections.Generic;
using System.Text;
using CM.Domain.Entity;

namespace CM.Domain.Interface.Service
{
	public interface ICandidatoService
	{
		void Add(Candidato entity);

		Candidato GetById(int id);

		IEnumerable<Candidato> GetAll();

		void Update(Candidato entity);

		void Remove(Candidato entity);
	}
}
