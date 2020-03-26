namespace Udemy_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTypes : DbMigration
    {
        public override void Up()
        {
            Sql("insert into GenreTypes (Name) Values('Action')");
            Sql("insert into GenreTypes (Name) Values('Adventure')");
            Sql("insert into GenreTypes (Name) Values('Comedy')");
            Sql("insert into GenreTypes (Name) Values('Crime')");
            Sql("insert into GenreTypes (Name) Values('Drama')");
            Sql("insert into GenreTypes (Name) Values('Fantacy')");
            Sql("insert into GenreTypes (Name) Values('Historical')");
            Sql("insert into GenreTypes (Name) Values('Historical Fiction')");
            Sql("insert into GenreTypes (Name) Values('Horror')");
            Sql("insert into GenreTypes (Name) Values('Political')");
            Sql("insert into GenreTypes (Name) Values('Romance')");
            Sql("insert into GenreTypes (Name) Values('Thriller')");
            Sql("insert into GenreTypes (Name) Values('Science Fiction')");
            Sql("insert into GenreTypes (Name) Values('Romantic Comedy')");
        }
        public override void Down()
        {
        }
    }
}
