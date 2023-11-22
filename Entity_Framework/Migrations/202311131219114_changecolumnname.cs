namespace Entity_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changecolumnname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "DatePublished", c => c.DateTime(nullable:false));
            Sql("UPDATE Students SET DatePunlished=DatePublished");
            DropColumn("dbo.Students", "DatePunlished");

        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "DatePunlished", c => c.DateTime(nullable:false));
            Sql("UPDATE Students DatePublished=Published");
            DropColumn("dbo.Students", "DatePublished");
        }
    }
}
