namespace DeliveryService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Secondmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductOrders",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Order_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Order_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Order_Id);
            
            AddColumn("dbo.Orders", "Adress", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Orders", "Mobile", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Orders", "DelivTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "Email", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Orders", "Address");
            DropColumn("dbo.Orders", "Phone");
            DropColumn("dbo.Orders", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "DateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "Phone", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Orders", "Address", c => c.String(nullable: false, maxLength: 100));
            DropForeignKey("dbo.ProductOrders", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.ProductOrders", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductOrders", new[] { "Order_Id" });
            DropIndex("dbo.ProductOrders", new[] { "Product_Id" });
            AlterColumn("dbo.Orders", "Email", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Orders", "DelivTime");
            DropColumn("dbo.Orders", "Mobile");
            DropColumn("dbo.Orders", "Adress");
            DropTable("dbo.ProductOrders");
            DropTable("dbo.Products");
        }
    }
}
