using System;
using System.Collections.Generic;
using System.Text;
using CM.Domain.Entity;
using CM.Domain.Interface.Repository;
using CM.Infrastructure.Data;

namespace CM.Infrastructure.Repository
{
	public class CandidatoRepository : BaseRepository<Candidato>, ICandidatoRepository
	{
		public CandidatoRepository(CMContext context) : base(context)
		{

		}
	}
}
