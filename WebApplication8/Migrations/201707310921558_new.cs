namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Workers", "accountactivated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Workers", "accountactivated", c => c.Boolean());
        }
    }
}
