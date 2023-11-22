namespace EntityFrameworkOperation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class availability : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Availability", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Availability");
        }
    }
}
