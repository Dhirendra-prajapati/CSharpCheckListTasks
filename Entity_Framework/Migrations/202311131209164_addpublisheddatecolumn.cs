namespace Entity_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpublisheddatecolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "DatePunlished", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "DatePunlished");
        }
    }
}
