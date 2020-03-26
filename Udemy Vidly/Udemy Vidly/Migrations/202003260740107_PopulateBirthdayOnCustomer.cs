namespace Udemy_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdayOnCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("update Customers set Birthday='1996/09/30 05:30' where Name = 'Karan'");
        }
        
        public override void Down()
        {
        }
    }
}
