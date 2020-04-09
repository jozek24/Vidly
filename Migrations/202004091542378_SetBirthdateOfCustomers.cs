using System.Data.Entity.Migrations.Model;

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthdateOfCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1997-05-25' AS DATETIME) WHERE id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
