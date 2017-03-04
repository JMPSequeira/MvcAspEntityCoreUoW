using Core.Interfaces;
using Core.Interfaces.Repo;
using Core.Models;
using Persistence.Interfaces;
using Persistence.Repo;

namespace Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IContext _context;

        public IRepo<Customer> Customers { get; set; }
        public ISalesAgentRepo SalesAgents { get; set; }
        public IRepo<MembershipType> MembershipsTypes { get; set; }

        public UnitOfWork(IContext context)
        {
            _context = context;
            Customers = new Repo<Customer>(context);
            SalesAgents = new SalesAgentRepo(context);
            MembershipsTypes = new Repo<MembershipType>(context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}