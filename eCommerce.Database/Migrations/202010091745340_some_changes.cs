namespace eCommerce.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class some_changes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "subCategory_ID", "dbo.subCategories");
            DropIndex("dbo.Products", new[] { "subCategory_ID" });
            RenameColumn(table: "dbo.Products", name: "subCategory_ID", newName: "subCategoryID");
            AlterColumn("dbo.Products", "subCategoryID", c => c.Int(nullable: true));
            CreateIndex("dbo.Products", "subCategoryID");
            AddForeignKey("dbo.Products", "subCategoryID", "dbo.subCategories", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "subCategoryID", "dbo.subCategories");
            DropIndex("dbo.Products", new[] { "subCategoryID" });
            AlterColumn("dbo.Products", "subCategoryID", c => c.Int());
            RenameColumn(table: "dbo.Products", name: "subCategoryID", newName: "subCategory_ID");
            CreateIndex("dbo.Products", "subCategory_ID");
            AddForeignKey("dbo.Products", "subCategory_ID", "dbo.subCategories", "ID");
        }
    }
}
