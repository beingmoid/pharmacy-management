namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _112820191002 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserTypeName = c.String(),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserTypes");
        }
    }
}