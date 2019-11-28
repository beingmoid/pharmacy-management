namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11292019139 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvoivceId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Invoices", t => t.InvoivceId, cascadeDelete: true)
                .Index(t => t.InvoivceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "InvoivceId", "dbo.Invoices");
            DropIndex("dbo.Sales", new[] { "InvoivceId" });
            DropTable("dbo.Sales");
        }
    }
}
