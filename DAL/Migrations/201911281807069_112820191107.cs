namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _112820191107 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Medicines", "MedicineName", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Medicines", "MedicineName", c => c.Int(nullable: false));
        }
    }
}
