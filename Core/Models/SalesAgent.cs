using Core.Models.Abstracts;
using System.Collections.Generic;

namespace Core.Models
{
    public class SalesAgent : AbstractPerson
    {
        public bool IsOperational { get; set; }
        public IEnumerable<Customer> Customer { get; set; }
    }
}