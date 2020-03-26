namespace Udemy_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreId", c => c.String());
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "InStockCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "InStockCount");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "ReleaseDate");
            DropColumn("dbo.Movies", "GenreId");
        }
    }
}
