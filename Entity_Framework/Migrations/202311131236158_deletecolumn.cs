namespace Entity_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletecolumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "Weight");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Weight", c => c.Single(nullable: false));
        }
    }
}
