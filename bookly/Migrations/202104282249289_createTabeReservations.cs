namespace bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTabeReservations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "ClientId", "dbo.clients");
            DropForeignKey("dbo.Reservations", "BookId", "dbo.books");
            DropIndex("dbo.Reservations", new[] { "BookId" });
            DropIndex("dbo.Reservations", new[] { "ClientId" });
            DropTable("dbo.Reservations");
        }
    }
}
