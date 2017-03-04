namespace Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsSubscribedToNewsletter = c.Boolean(nullable: false),
                        MembershipTypeId = c.Int(nullable: false),
                        SalesAgentId = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MembershipTypes", t => t.MembershipTypeId, cascadeDelete: true)
                .ForeignKey("dbo.SalesAgents", t => t.SalesAgentId, cascadeDelete: true)
                .Index(t => t.MembershipTypeId)
                .Index(t => t.SalesAgentId);
            
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SalesAgents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsOperational = c.Boolean(nullable: false),
                        DateOfBirth = c.DateTime(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "SalesAgentId", "dbo.SalesAgents");
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "SalesAgentId" });
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            DropTable("dbo.SalesAgents");
            DropTable("dbo.MembershipTypes");
            DropTable("dbo.Customers");
        }
    }
}
