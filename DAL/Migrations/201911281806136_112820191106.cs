namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _112820191106 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medicines", "MedicineName", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Medicines", "MedicineName");
        }
    }
}
