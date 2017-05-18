namespace ThinkTech.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TechnologyDevice = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConsumerRatingNumber = c.String(nullable: false),
                        FunctionalityImprovements = c.String(),
                        ConsumerReport = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Reviews", new[] { "CategoryId" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Categories");
        }
    }
}
