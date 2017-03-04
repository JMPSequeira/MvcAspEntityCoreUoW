using Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfig
{
    public class SalesAgentConfig : EntityTypeConfiguration<SalesAgent>
    {
        //When needed
        public SalesAgentConfig()
        {
            HasMany(s => s.Customers)
                .WithRequired(c => c.SalesAgent);
        }
    }
}
