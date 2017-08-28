namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Workers", "NewsLetter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Workers", "NewsLetter", c => c.Boolean(nullable: false));
        }
    }
}
