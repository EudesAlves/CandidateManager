using CM.Domain.Entity;
using CM.Domain.Interface.Repository;
using CM.Infrastructure.Data;

namespace CM.Infrastructure.Repository
{
	public class ContatoRepository : BaseRepository<Contato>, IContatoRepository
	{
		public ContatoRepository(CMContext context) : base(context)
		{

		}
	}
}
