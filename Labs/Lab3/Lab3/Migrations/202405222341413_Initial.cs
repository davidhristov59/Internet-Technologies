namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hospitals", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hospitals", "Address");
        }
    }
}
