namespace DatabaseExample2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientMovieRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieClients",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false),
                        Client_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_Id, t.Client_ID })
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_ID, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Client_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieClients", "Client_ID", "dbo.Clients");
            DropForeignKey("dbo.MovieClients", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.MovieClients", new[] { "Client_ID" });
            DropIndex("dbo.MovieClients", new[] { "Movie_Id" });
            DropTable("dbo.MovieClients");
        }
    }
}
