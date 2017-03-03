using Core.Models;
using System;
using System.Data.Entity;

namespace Persistence.Interfaces
{
    public interface IContext : IDisposable
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<SalesAgent> SalesAgents { get; set; }
        DbSet<MembershipType> MembershipTypes { get; set; }

        int SaveChanges();
    }
}