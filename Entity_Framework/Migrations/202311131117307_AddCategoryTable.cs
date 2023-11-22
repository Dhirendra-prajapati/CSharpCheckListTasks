namespace Entity_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity:false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO categories VALUES (1,'Web Development')");
            Sql("INSERT INTO categories VALUES (2,'Programming Language')");

            
        }
        
        public override void Down()
        {
            DropTable("dbo.categories");
        }
    }
}
