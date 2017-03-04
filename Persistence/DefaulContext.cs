using Core.Models;
using Persistence.Interfaces;
using System.Data.Entity;

namespace Persistence
{
    public class DefaulContext : DbContext, IContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SalesAgent> SalesAgents { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }

        public DefaulContext() : base("name=DefaultContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    }
}