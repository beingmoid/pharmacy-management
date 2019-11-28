namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11292019142 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "MedicineId", c => c.Int(nullable: false));
            CreateIndex("dbo.Sales", "MedicineId");
            AddForeignKey("dbo.Sales", "MedicineId", "dbo.Medicines", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "MedicineId", "dbo.Medicines");
            DropIndex("dbo.Sales", new[] { "MedicineId" });
            DropColumn("dbo.Sales", "MedicineId");
        }
    }
}
