﻿namespace Entity_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        StandardId = c.Int(nullable: false, identity: true),
                        StandardName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.StandardId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                        Standard_StandardId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Standards", t => t.Standard_StandardId)
                .Index(t => t.Standard_StandardId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Standard_StandardId", "dbo.Standards");
            DropIndex("dbo.Students", new[] { "Standard_StandardId" });
            DropTable("dbo.Students");
            DropTable("dbo.Standards");
        }
    }
}
