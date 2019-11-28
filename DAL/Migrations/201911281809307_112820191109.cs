namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _112820191109 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Medicines", "MedicineName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Medicines", "MedicineName", c => c.String());
        }
    }
}
