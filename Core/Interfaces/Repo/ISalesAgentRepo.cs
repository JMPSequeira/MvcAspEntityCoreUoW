using Core.Models;
using System.Collections.Generic;

namespace Core.Interfaces.Repo
{
    public interface ISalesAgentRepo : IRepo<SalesAgent>
    {
        SalesAgent GetSalesAgentsWithCustomers(int id);
    }
}