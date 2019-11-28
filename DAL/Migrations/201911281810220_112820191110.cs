namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _112820191110 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medicines", "MedicienceName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Medicines", "MedicienceName");
        }
    }
}
