using Core.Interfaces.Repo;
using Core.Models;
using System;

namespace Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepo<Customer> Customers { get; set; }
        ISalesAgentRepo SalesAgents { get; set; }
        IRepo<MembershipType> MembershipsTypes { get; set; }

        int Complete();
    }
}