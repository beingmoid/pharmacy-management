namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _112820191102 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MedicineTypeId = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MedicineTypes", t => t.MedicineTypeId, cascadeDelete: true)
                .Index(t => t.MedicineTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medicines", "MedicineTypeId", "dbo.MedicineTypes");
            DropIndex("dbo.Medicines", new[] { "MedicineTypeId" });
            DropTable("dbo.Medicines");
        }
    }
}
