namespace bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingBooks : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT books ON");
            Sql("insert into books (BookId,name,genre,NumberInStock) values (1,'The Great Gatsby','Novel',55)");
            Sql("insert into books (BookId,name,genre,NumberInStock) values (2,'One Hundred Years of Solitude','Epic Fiction',102)");
        }
        
        public override void Down()
        {
        }
    }
}
