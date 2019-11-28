namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _112820191050 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MedicineTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MedicineTypeName = c.String(),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MedicineTypes");
        }
    }
}
