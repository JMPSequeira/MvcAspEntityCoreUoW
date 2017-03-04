using Core.Models.Abstracts;
using System.Collections.Generic;

namespace Core.Models
{
    public class SalesAgent : AbstractPerson
    {
        public bool IsOperational { get; set; }
        public ICollection<Customer> Customers { get; set; }

        public SalesAgent() => Customers = new HashSet<Customer>();
    }
}