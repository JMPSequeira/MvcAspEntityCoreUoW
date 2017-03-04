using Autofac;
using Core.Interfaces;
using Core.Interfaces.Repo;
using Core.Models.Abstracts;
using Persistence;
using Persistence.Interfaces;
using System;
using System.Linq;

namespace MvcAspTester
{
    internal static class Program
    {
        private static IContainer Container { get; set; }

        private static void Main()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DefaulContext>().As<IContext>();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            Container = builder.Build();

            using (var scope = Container.BeginLifetimeScope())
            {
                var unit = scope.Resolve<IUnitOfWork>();
                var salesAgent = unit.SalesAgents.GetSalesAgentsWithCustomers(1);

                Console.WriteLine("Sales Agent Id: {0}\nName: {1}", salesAgent.Id, salesAgent.Name);
                Console.WriteLine("\n\tCustomers:");
                foreach (var customer in salesAgent.Customers)
                {
                    Console.WriteLine("\t\tId: {0}\n\t\tName: {1}", customer.Id, customer.Name);
                }
            }
        }
    }
}
