namespace Experiment.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BookId)
                .Index(t => t.BookId, unique: true);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        PageId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        Book_BookId = c.Int(),
                    })
                .PrimaryKey(t => t.PageId)
                .ForeignKey("dbo.Books", t => t.Book_BookId)
                .Index(t => t.Book_BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pages", "Book_BookId", "dbo.Books");
            DropIndex("dbo.Pages", new[] { "Book_BookId" });
            DropIndex("dbo.Books", new[] { "BookId" });
            DropTable("dbo.Pages");
            DropTable("dbo.Books");
        }
    }
}
