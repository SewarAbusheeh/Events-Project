namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        commentId = c.Int(nullable: false, identity: true),
                        CommentU = c.String(),
                        SubscribeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.commentId)
                .ForeignKey("dbo.Subscribes", t => t.SubscribeId, cascadeDelete: true)
                .Index(t => t.SubscribeId);
            
            CreateTable(
                "dbo.Subscribes",
                c => new
                    {
                        subscribeId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        EventId = c.Int(nullable: false),
                        Is_Like = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.subscribeId)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.EventId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        creationDate = c.DateTime(nullable: false),
                        ProviderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EventId)
                .ForeignKey("dbo.Providers", t => t.ProviderId, cascadeDelete: true)
                .Index(t => t.ProviderId);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        ProviderId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ProviderId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        UserType = c.String(),
                        RoleId = c.Int(nullable: false),
                        ProviderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Providers", t => t.ProviderId, cascadeDelete: false)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.ProviderId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "SubscribeId", "dbo.Subscribes");
            DropForeignKey("dbo.Subscribes", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Users", "ProviderId", "dbo.Providers");
            DropForeignKey("dbo.Subscribes", "EventId", "dbo.Events");
            DropForeignKey("dbo.Events", "ProviderId", "dbo.Providers");
            DropIndex("dbo.Users", new[] { "ProviderId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Events", new[] { "ProviderId" });
            DropIndex("dbo.Subscribes", new[] { "EventId" });
            DropIndex("dbo.Subscribes", new[] { "UserId" });
            DropIndex("dbo.Comments", new[] { "SubscribeId" });
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Providers");
            DropTable("dbo.Events");
            DropTable("dbo.Subscribes");
            DropTable("dbo.Comments");
        }
    }
}
