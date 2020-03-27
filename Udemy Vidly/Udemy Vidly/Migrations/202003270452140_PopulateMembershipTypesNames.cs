namespace Udemy_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypesNames : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set Name = 'Pay As You Go' where id= 1");
            Sql("update MembershipTypes set Name = 'Monthly' where id= 2");
            Sql("update MembershipTypes set Name = 'Quarterly' where id= 3");
            Sql("update MembershipTypes set Name = 'Annual' where id= 4");
        }

        public override void Down()
        {
        }
    }
}
