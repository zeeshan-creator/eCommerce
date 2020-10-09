namespace eCommerce.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class some_changes_2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.subCategories", "category_ID", "dbo.Categories");
            DropIndex("dbo.subCategories", new[] { "category_ID" });
            RenameColumn(table: "dbo.subCategories", name: "category_ID", newName: "categoryID");
            AlterColumn("dbo.subCategories", "categoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.subCategories", "categoryID");
            AddForeignKey("dbo.subCategories", "categoryID", "dbo.Categories", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.subCategories", "categoryID", "dbo.Categories");
            DropIndex("dbo.subCategories", new[] { "categoryID" });
            AlterColumn("dbo.subCategories", "categoryID", c => c.Int());
            RenameColumn(table: "dbo.subCategories", name: "categoryID", newName: "category_ID");
            CreateIndex("dbo.subCategories", "category_ID");
            AddForeignKey("dbo.subCategories", "category_ID", "dbo.Categories", "ID");
        }
    }
}
