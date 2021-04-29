namespace bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTabeClients : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        type = c.String(),
                    })
                .PrimaryKey(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.clients");
        }
    }
}
