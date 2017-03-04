using Core.Interfaces.Repo;
using System.Linq;
using System.Data.Entity;
using Persistence.Interfaces;
using Core.Models;

namespace Persistence.Repo
{
    public class SalesAgentRepo : Repo<SalesAgent>, ISalesAgentRepo
    {
        public SalesAgentRepo(IContext context) : base(context)
        {
        }

        public SalesAgent GetSalesAgentsWithCustomers(int id)
        {
            return _entities.Include(s => s.Customers).SingleOrDefault(s => s.Id == id);
        }
    }
}
