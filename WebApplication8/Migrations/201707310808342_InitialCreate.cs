namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        country_id = c.Int(nullable: false, identity: true),
                        country_name = c.String(),
                    })
                .PrimaryKey(t => t.country_id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        empid = c.Int(nullable: false, identity: true),
                        empname = c.String(),
                        empfathername = c.String(),
                        empsalary = c.Int(nullable: false),
                        country_name = c.String(),
                        state_name = c.String(),
                        email = c.String(),
                        accountactivated = c.Boolean(),
                    })
                .PrimaryKey(t => t.empid);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        state_id = c.Int(nullable: false, identity: true),
                        country_id = c.Int(nullable: false),
                        state_name = c.String(),
                    })
                .PrimaryKey(t => t.state_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.States");
            DropTable("dbo.Workers");
            DropTable("dbo.Countries");
        }
    }
}
