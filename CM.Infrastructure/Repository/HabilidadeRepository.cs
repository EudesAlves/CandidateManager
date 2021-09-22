using CM.Domain.Entity;
using CM.Domain.Interface.Repository;
using CM.Infrastructure.Data;

namespace CM.Infrastructure.Repository
{
	public class HabilidadeRepository : BaseRepository<Habilidade>, IHabilidadeRepository
	{
		public HabilidadeRepository(CMContext context) : base(context)
		{

		}
	}
}
