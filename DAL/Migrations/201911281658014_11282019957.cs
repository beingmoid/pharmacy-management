namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11282019957 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsRead = c.Boolean(nullable: false),
                        IsAdd = c.Boolean(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        IsEdit = c.Boolean(nullable: false),
                        UserID = c.Int(nullable: false),
                        PageID = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pages", t => t.PageID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.PageID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "UserID", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "PageID", "dbo.Pages");
            DropIndex("dbo.UserRoles", new[] { "PageID" });
            DropIndex("dbo.UserRoles", new[] { "UserID" });
            DropTable("dbo.UserRoles");
        }
    }
}
