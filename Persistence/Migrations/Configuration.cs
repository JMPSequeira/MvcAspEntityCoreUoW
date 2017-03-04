namespace Persistence.Migrations
{
    using Core.Interfaces;
    using Core.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Persistence.DefaulContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DefaulContext context)
        {
            context.MembershipTypes.AddOrUpdate(new MembershipType { Id = 1, Name = "Pay As You Go" });
            context.MembershipTypes.AddOrUpdate(new MembershipType { Id = 2, Name = "Monthly" });
            context.MembershipTypes.AddOrUpdate(new MembershipType { Id = 3, Name = "Quarterly" });
            context.MembershipTypes.AddOrUpdate(new MembershipType { Id = 4, Name = "Annually" });

            context.SalesAgents.AddOrUpdate(new SalesAgent { Id = 1, Name = "Michael Jordan", IsOperational = true });
            context.SalesAgents.AddOrUpdate(new SalesAgent { Id = 2, Name = "Michael Jackson", IsOperational = false });
            context.SalesAgents.AddOrUpdate(new SalesAgent { Id = 3, Name = "Maddona", IsOperational = true});

            context.Customers.AddOrUpdate(new Customer { Id = 1, Name = "Michael Flynn", MembershipTypeId = 2, IsSubscribedToNewsletter = false, SalesAgentId = 1 });
            context.Customers.AddOrUpdate(new Customer { Id = 2, Name = "George Michael", MembershipTypeId = 1, IsSubscribedToNewsletter = false, SalesAgentId = 1});
            context.Customers.AddOrUpdate(new Customer { Id = 3, Name = "George Michael", MembershipTypeId = 4, IsSubscribedToNewsletter = false, SalesAgentId = 1 });
            
        }
    }
}
