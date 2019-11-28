namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _112820191133 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MedicineId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        StockName = c.String(),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medicines", t => t.MedicineId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.MedicineId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        Telephone = c.String(),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Stocks", "MedicineId", "dbo.Medicines");
            DropIndex("dbo.Stocks", new[] { "SupplierId" });
            DropIndex("dbo.Stocks", new[] { "MedicineId" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Stocks");
        }
    }
}
