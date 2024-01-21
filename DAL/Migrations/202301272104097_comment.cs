namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class comment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subscribes", "Comment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subscribes", "Comment");
        }
    }
}
