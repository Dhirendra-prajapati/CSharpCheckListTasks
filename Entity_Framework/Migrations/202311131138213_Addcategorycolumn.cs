namespace Entity_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addcategorycolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "category_Id", c => c.Int());
            CreateIndex("dbo.Students", "category_Id");
            AddForeignKey("dbo.Students", "category_Id", "dbo.categories", "Id");
            Sql("UPDATE Students  set category_Id=1");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "category_Id", "dbo.categories");
            DropIndex("dbo.Students", new[] { "category_Id" });
            DropColumn("dbo.Students", "category_Id");
        }
    }
}
