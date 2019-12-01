namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1212019440 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Invoices", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.Invoices", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Invoices", "EditedBy", c => c.Int());
            AlterColumn("dbo.Sales", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.Sales", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Sales", "EditedBy", c => c.Int());
            AlterColumn("dbo.Medicines", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.Medicines", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Medicines", "EditedBy", c => c.Int());
            AlterColumn("dbo.MedicineTypes", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.MedicineTypes", "CreatedBy", c => c.Int());
            AlterColumn("dbo.MedicineTypes", "EditedBy", c => c.Int());
            AlterColumn("dbo.Stocks", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.Stocks", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Stocks", "EditedBy", c => c.Int());
            AlterColumn("dbo.Suppliers", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.Suppliers", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Suppliers", "EditedBy", c => c.Int());
            AlterColumn("dbo.Pages", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.Pages", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Pages", "EditedBy", c => c.Int());
            AlterColumn("dbo.UserRoles", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.UserRoles", "CreatedBy", c => c.Int());
            AlterColumn("dbo.UserRoles", "EditedBy", c => c.Int());
            AlterColumn("dbo.Users", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.Users", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Users", "EditedBy", c => c.Int());
            AlterColumn("dbo.Sessions", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.Sessions", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Sessions", "EditedBy", c => c.Int());
            AlterColumn("dbo.UserSelectedTypes", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.UserSelectedTypes", "CreatedBy", c => c.Int());
            AlterColumn("dbo.UserSelectedTypes", "EditedBy", c => c.Int());
            AlterColumn("dbo.UserTypes", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.UserTypes", "CreatedBy", c => c.Int());
            AlterColumn("dbo.UserTypes", "EditedBy", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserTypes", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.UserTypes", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.UserTypes", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserSelectedTypes", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.UserSelectedTypes", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.UserSelectedTypes", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sessions", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Sessions", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Sessions", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserRoles", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.UserRoles", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.UserRoles", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Pages", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Pages", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Pages", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Suppliers", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Suppliers", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Suppliers", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Stocks", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Stocks", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Stocks", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MedicineTypes", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.MedicineTypes", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.MedicineTypes", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Medicines", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Medicines", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Medicines", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sales", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Sales", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Sales", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Invoices", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Invoices", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Invoices", "EditedTime", c => c.DateTime(nullable: false));
        }
    }
}
