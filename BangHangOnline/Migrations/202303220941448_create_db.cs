﻿namespace BangHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_Adv",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Image = c.String(),
                        Link = c.String(),
                        Type = c.Int(nullable: false),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_Category",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        SeoName = c.String(),
                        SeoDescription = c.String(),
                        SeoKeywords = c.String(),
                        Position = c.Int(nullable: false),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Detail = c.String(),
                        Description = c.String(),
                        Image = c.String(),
                        CategoryId = c.Int(nullable: false),
                        SeoTitle = c.String(),
                        SeoKeywords = c.String(),
                        SeoDescription = c.String(),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.tb_Post",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Detail = c.String(),
                        Description = c.String(),
                        Image = c.String(),
                        CategoryId = c.Int(nullable: false),
                        SeoTitle = c.String(),
                        SeoKeywords = c.String(),
                        SeoDescription = c.String(),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.tb_Contact",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        Email = c.String(nullable: false, maxLength: 150),
                        Website = c.String(),
                        Message = c.String(),
                        IsRead = c.Boolean(nullable: false),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_OrderDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Order", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.tb_Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.tb_Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        CustomerName = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductCode = c.String(),
                        Detail = c.String(),
                        Description = c.String(),
                        Image = c.String(),
                        ProductCategoryId = c.Int(nullable: false),
                        SeoTitle = c.String(),
                        SeoKeywords = c.String(),
                        SeoDescription = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceSale = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsSale = c.Boolean(nullable: false),
                        IsHome = c.Boolean(nullable: false),
                        IsHot = c.Boolean(nullable: false),
                        IsFeture = c.Boolean(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_ProductCategory", t => t.ProductCategoryId, cascadeDelete: true)
                .Index(t => t.ProductCategoryId);
            
            CreateTable(
                "dbo.tb_ProductCategory",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        SeoName = c.String(),
                        Icon = c.String(),
                        SeoDescription = c.String(),
                        SeoKeywords = c.String(),
                        Position = c.Int(nullable: false),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_ProductImage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Image = c.String(),
                        IsDefault = c.Boolean(nullable: false),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_Subscriber",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_SystemSetting",
                c => new
                    {
                        SetKey = c.String(nullable: false, maxLength: 25),
                        Value = c.String(maxLength: 4000),
                        Description = c.String(),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                    })
                .PrimaryKey(t => t.SetKey);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_OrderDetail", "ProductId", "dbo.tb_Product");
            DropForeignKey("dbo.tb_Product", "ProductCategoryId", "dbo.tb_ProductCategory");
            DropForeignKey("dbo.tb_OrderDetail", "OrderId", "dbo.tb_Order");
            DropForeignKey("dbo.tb_Post", "CategoryId", "dbo.tb_Category");
            DropForeignKey("dbo.tb_News", "CategoryId", "dbo.tb_Category");
            DropIndex("dbo.tb_Product", new[] { "ProductCategoryId" });
            DropIndex("dbo.tb_OrderDetail", new[] { "ProductId" });
            DropIndex("dbo.tb_OrderDetail", new[] { "OrderId" });
            DropIndex("dbo.tb_Post", new[] { "CategoryId" });
            DropIndex("dbo.tb_News", new[] { "CategoryId" });
            DropTable("dbo.tb_SystemSetting");
            DropTable("dbo.tb_Subscriber");
            DropTable("dbo.tb_ProductImage");
            DropTable("dbo.tb_ProductCategory");
            DropTable("dbo.tb_Product");
            DropTable("dbo.tb_Order");
            DropTable("dbo.tb_OrderDetail");
            DropTable("dbo.tb_Contact");
            DropTable("dbo.tb_Post");
            DropTable("dbo.tb_News");
            DropTable("dbo.tb_Category");
            DropTable("dbo.tb_Adv");
        }
    }
}
