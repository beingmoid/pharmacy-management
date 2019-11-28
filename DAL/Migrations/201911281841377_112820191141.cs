namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _112820191141 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medicines", "ExpiryDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Medicines", "ExpiryDate");
        }
    }
}
