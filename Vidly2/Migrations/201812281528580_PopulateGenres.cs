namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO genres(Id, Name) VALUES (1, 'Comedy') ");
            Sql("INSERT INTO genres(Id, Name) VALUES (2, 'Thriller') ");
            Sql("INSERT INTO genres(Id, Name) VALUES (3, 'Dramatic') ");
            Sql("INSERT INTO genres(Id, Name) VALUES (4, 'Comic') ");
        }
        
        public override void Down()
        {
        }
    }
}
