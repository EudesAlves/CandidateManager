using CM.Domain.Entity;
using CM.Domain.Interface.Repository;
using CM.Infrastructure.Data;

namespace CM.Infrastructure.Repository
{
	public class CandidatoHabilidadeRepository : BaseRepository<CandidatoHabilidade>, ICandidatoHabilidadeRepository
	{
		public CandidatoHabilidadeRepository(CMContext context) : base(context)
		{

		}
	}
}
