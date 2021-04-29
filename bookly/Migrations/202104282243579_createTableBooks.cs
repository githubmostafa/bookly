namespace bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTableBooks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        genre = c.String(),
                        NumberInStock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.books");
        }
    }
}
