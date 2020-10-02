namespace eCommerce.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialized : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Orders", name: "paymentID_ID", newName: "payment_ID");
            RenameColumn(table: "dbo.Orders", name: "productID_ID", newName: "product_ID");
            RenameColumn(table: "dbo.Orders", name: "userID_ID", newName: "user_ID");
            RenameIndex(table: "dbo.Orders", name: "IX_paymentID_ID", newName: "IX_payment_ID");
            RenameIndex(table: "dbo.Orders", name: "IX_productID_ID", newName: "IX_product_ID");
            RenameIndex(table: "dbo.Orders", name: "IX_userID_ID", newName: "IX_user_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Orders", name: "IX_user_ID", newName: "IX_userID_ID");
            RenameIndex(table: "dbo.Orders", name: "IX_product_ID", newName: "IX_productID_ID");
            RenameIndex(table: "dbo.Orders", name: "IX_payment_ID", newName: "IX_paymentID_ID");
            RenameColumn(table: "dbo.Orders", name: "user_ID", newName: "userID_ID");
            RenameColumn(table: "dbo.Orders", name: "product_ID", newName: "productID_ID");
            RenameColumn(table: "dbo.Orders", name: "payment_ID", newName: "paymentID_ID");
        }
    }
}
