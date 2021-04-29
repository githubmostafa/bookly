namespace bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Resevationseeding : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Reservations ON");
            Sql("insert into Reservations (ReservationId,ClientId,BookId,StartDate,EndDate) values (1,2,1, '8/4/2021' , '9/4/2021' )");
            Sql("insert into Reservations (ReservationId,ClientId,BookId,StartDate,EndDate) values (2,1,2, '1/4/2021' ,'5/4/2021' )");
        }
        
        public override void Down()
        {
        }
    }
}
