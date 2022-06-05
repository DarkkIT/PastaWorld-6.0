﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PriLalo.Data.Migrations
{
    public partial class InitiLcREATE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "AspNetRoles",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoles", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUsers",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
            //        PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
            //        TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
            //        LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
            //        AccessFailedCount = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUsers", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Ingredients",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Ingredients", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Meals",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        IsTop = table.Column<bool>(type: "bit", nullable: false),
            //        CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Meals", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MetaData",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        IsActive = table.Column<bool>(type: "bit", nullable: false),
            //        CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MetaData", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Settings",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Settings", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SiteSettings",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        HomePageImageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        HomePageSecondImageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        HomePageThirdImageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        HomePageSubImageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PriceDelivery = table.Column<double>(type: "float", nullable: false),
            //        WorkingHours = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DeliveryTime = table.Column<int>(type: "int", nullable: false),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Mol = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Bulstat = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SiteSettings", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetRoleClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserClaims_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserLogins",
            //    columns: table => new
            //    {
            //        LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserLogins_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserRoles",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserTokens",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserTokens_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "News",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        NewsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
            //        CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_News", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_News_AspNetUsers_ApplicationUserId",
            //            column: x => x.ApplicationUserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Order",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        City = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        AddressComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DeliveryPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        MealsPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        IsUserAddress = table.Column<bool>(type: "bit", nullable: false),
            //        IsBankCard = table.Column<bool>(type: "bit", nullable: false),
            //        IsAgreedTermsAndConditions = table.Column<bool>(type: "bit", nullable: false),
            //        ClientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
            //        DistributorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
            //        CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Order", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Order_AspNetUsers_ClientId",
            //            column: x => x.ClientId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Order_AspNetUsers_DistributorId",
            //            column: x => x.DistributorId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MealIngredients",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MealId = table.Column<int>(type: "int", nullable: false),
            //        IngredientId = table.Column<int>(type: "int", nullable: false),
            //        CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MealIngredients", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_MealIngredients_Ingredients_IngredientId",
            //            column: x => x.IngredientId,
            //            principalTable: "Ingredients",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_MealIngredients_Meals_MealId",
            //            column: x => x.MealId,
            //            principalTable: "Meals",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MealUsers",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
            //        MealId = table.Column<int>(type: "int", nullable: false),
            //        CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MealUsers", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_MealUsers_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_MealUsers_Meals_MealId",
            //            column: x => x.MealId,
            //            principalTable: "Meals",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CartItem",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Quantity = table.Column<int>(type: "int", nullable: false),
            //        MealId = table.Column<int>(type: "int", nullable: false),
            //        OrderId = table.Column<int>(type: "int", nullable: false),
            //        CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CartItem", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_CartItem_Meals_MealId",
            //            column: x => x.MealId,
            //            principalTable: "Meals",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_CartItem_Order_OrderId",
            //            column: x => x.OrderId,
            //            principalTable: "Order",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetRoleClaims_RoleId",
            //    table: "AspNetRoleClaims",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetRoles_IsDeleted",
            //    table: "AspNetRoles",
            //    column: "IsDeleted");

            //migrationBuilder.CreateIndex(
            //    name: "RoleNameIndex",
            //    table: "AspNetRoles",
            //    column: "NormalizedName",
            //    unique: true,
            //    filter: "[NormalizedName] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserClaims_UserId",
            //    table: "AspNetUserClaims",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserLogins_UserId",
            //    table: "AspNetUserLogins",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserRoles_RoleId",
            //    table: "AspNetUserRoles",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "EmailIndex",
            //    table: "AspNetUsers",
            //    column: "NormalizedEmail");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUsers_IsDeleted",
            //    table: "AspNetUsers",
            //    column: "IsDeleted");

            //migrationBuilder.CreateIndex(
            //    name: "UserNameIndex",
            //    table: "AspNetUsers",
            //    column: "NormalizedUserName",
            //    unique: true,
            //    filter: "[NormalizedUserName] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CartItem_IsDeleted",
            //    table: "CartItem",
            //    column: "IsDeleted");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CartItem_MealId",
            //    table: "CartItem",
            //    column: "MealId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CartItem_OrderId",
            //    table: "CartItem",
            //    column: "OrderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Ingredients_IsDeleted",
            //    table: "Ingredients",
            //    column: "IsDeleted");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MealIngredients_IngredientId",
            //    table: "MealIngredients",
            //    column: "IngredientId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MealIngredients_MealId",
            //    table: "MealIngredients",
            //    column: "MealId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Meals_IsDeleted",
            //    table: "Meals",
            //    column: "IsDeleted");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MealUsers_MealId",
            //    table: "MealUsers",
            //    column: "MealId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MealUsers_UserId",
            //    table: "MealUsers",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MetaData_IsDeleted",
            //    table: "MetaData",
            //    column: "IsDeleted");

            //migrationBuilder.CreateIndex(
            //    name: "IX_News_ApplicationUserId",
            //    table: "News",
            //    column: "ApplicationUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_News_IsDeleted",
            //    table: "News",
            //    column: "IsDeleted");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Order_ClientId",
            //    table: "Order",
            //    column: "ClientId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Order_DistributorId",
            //    table: "Order",
            //    column: "DistributorId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Order_IsDeleted",
            //    table: "Order",
            //    column: "IsDeleted");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Settings_IsDeleted",
            //    table: "Settings",
            //    column: "IsDeleted");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SiteSettings_IsDeleted",
            //    table: "SiteSettings",
            //    column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "MealIngredients");

            migrationBuilder.DropTable(
                name: "MealUsers");

            migrationBuilder.DropTable(
                name: "MetaData");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "SiteSettings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
