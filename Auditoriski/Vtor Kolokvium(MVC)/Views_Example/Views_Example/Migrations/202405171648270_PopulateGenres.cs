namespace Views_Example.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (GenreName) VALUES ('Jazz')"); //da insertiram vo tabelata Genre-ovi za kolona Name i vrednosti Jazz.. 
            Sql("INSERT INTO Genres (GenreName) VALUES ('Rock')");
            Sql("Insert into Genres (GenreName) VALUES ('Hip-Hop')");
        }
        
        public override void Down()
        {
        }
    }
}
