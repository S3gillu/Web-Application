namespace WebApplication6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Custom : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewCustomers", "NewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewCustomers", "NewsLetter");
        }
    }
}
