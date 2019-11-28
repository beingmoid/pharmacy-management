namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _112820191140 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stocks", "ExpiryDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stocks", "ExpiryDate");
        }
    }
}
