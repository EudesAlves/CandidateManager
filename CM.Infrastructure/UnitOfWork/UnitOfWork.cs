using CM.Domain.Interface.Repository;
using CM.Domain.Interface.UnitOfWork;
using CM.Infrastructure.Data;
using CM.Infrastructure.Repository;

namespace CM.Infrastructure.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		public ICandidatoRepository Candidatos { get; set; }
		public IHabilidadeRepository Habilidades { get; set; }
		public IContatoRepository Contatos { get; set; }
		public ICandidatoHabilidadeRepository CandidatoHabilidades { get; set; }
		CMContext _context;

		public UnitOfWork(CMContext context)
		{
			_context = context;
			Candidatos = new CandidatoRepository(_context);
			Habilidades = new HabilidadeRepository(_context);
			Contatos = new ContatoRepository(_context);
			CandidatoHabilidades = new CandidatoHabilidadeRepository(_context);
		}

		public void Commit()
		{
			_context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
