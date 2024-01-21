namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewtableslike : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "SubscribeId", "dbo.Subscribes");
            DropIndex("dbo.Comments", new[] { "SubscribeId" });
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        commentId = c.Int(nullable: false, identity: true),
                        CommentU = c.String(),
                        EventId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.commentId)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.EventId)
                .Index(t => t.UserId);
            
            AddColumn("dbo.Comments", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Comments", "EventId", c => c.Int(nullable: false));
            AddColumn("dbo.Subscribes", "Is_Subscribe", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Comments", "UserId");
            CreateIndex("dbo.Comments", "EventId");
            AddForeignKey("dbo.Comments", "EventId", "dbo.Events", "EventId", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
            DropColumn("dbo.Comments", "SubscribeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "SubscribeId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Likes", "UserId", "dbo.Users");
            DropForeignKey("dbo.Likes", "EventId", "dbo.Events");
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "EventId", "dbo.Events");
            DropIndex("dbo.Likes", new[] { "UserId" });
            DropIndex("dbo.Likes", new[] { "EventId" });
            DropIndex("dbo.Comments", new[] { "EventId" });
            DropIndex("dbo.Comments", new[] { "UserId" });
            DropColumn("dbo.Subscribes", "Is_Subscribe");
            DropColumn("dbo.Comments", "EventId");
            DropColumn("dbo.Comments", "UserId");
            DropTable("dbo.Likes");
            CreateIndex("dbo.Comments", "SubscribeId");
            AddForeignKey("dbo.Comments", "SubscribeId", "dbo.Subscribes", "subscribeId", cascadeDelete: true);
        }
    }
}
