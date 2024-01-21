namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcorr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Likes", "Is_LikeU", c => c.Boolean(nullable: false));
            DropColumn("dbo.Likes", "CommentU");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Likes", "CommentU", c => c.String());
            DropColumn("dbo.Likes", "Is_LikeU");
        }
    }
}
