namespace bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT clients ON");
            Sql("insert into clients (ClientId,ClientName,DateOfBirth,type) values (1,'Mostafa khraizat','8/3/1999','Engineer')");
            Sql("insert into clients (ClientId,ClientName,DateOfBirth,type) values (2,'Ali Youssef','1/1/2003','Bro')");

        }

        public override void Down()
        {
        }
    }
}
