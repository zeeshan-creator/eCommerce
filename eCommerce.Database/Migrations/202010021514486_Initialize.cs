namespace eCommerce.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        password = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        invoiceNumber = c.Long(nullable: false),
                        orderStatus = c.String(),
                        paymentID_ID = c.Int(),
                        productID_ID = c.Int(),
                        userID_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Payments", t => t.paymentID_ID)
                .ForeignKey("dbo.Products", t => t.productID_ID)
                .ForeignKey("dbo.signUps", t => t.userID_ID)
                .Index(t => t.paymentID_ID)
                .Index(t => t.productID_ID)
                .Index(t => t.userID_ID);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        creditCard = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        zipCode = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Image = c.String(),
                        Description = c.String(),
                        Name = c.String(),
                        subCategory_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.subCategories", t => t.subCategory_ID)
                .Index(t => t.subCategory_ID);
            
            CreateTable(
                "dbo.subCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.category_ID)
                .Index(t => t.category_ID);
            
            CreateTable(
                "dbo.signUps",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        lastName = c.String(),
                        emailAddress = c.String(),
                        Password = c.String(),
                        repeatPassword = c.String(),
                        phoneNumber = c.Long(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "userID_ID", "dbo.signUps");
            DropForeignKey("dbo.Orders", "productID_ID", "dbo.Products");
            DropForeignKey("dbo.Products", "subCategory_ID", "dbo.subCategories");
            DropForeignKey("dbo.subCategories", "category_ID", "dbo.Categories");
            DropForeignKey("dbo.Orders", "paymentID_ID", "dbo.Payments");
            DropIndex("dbo.subCategories", new[] { "category_ID" });
            DropIndex("dbo.Products", new[] { "subCategory_ID" });
            DropIndex("dbo.Orders", new[] { "userID_ID" });
            DropIndex("dbo.Orders", new[] { "productID_ID" });
            DropIndex("dbo.Orders", new[] { "paymentID_ID" });
            DropTable("dbo.signUps");
            DropTable("dbo.subCategories");
            DropTable("dbo.Products");
            DropTable("dbo.Payments");
            DropTable("dbo.Orders");
            DropTable("dbo.Categories");
            DropTable("dbo.admins");
        }
    }
}
