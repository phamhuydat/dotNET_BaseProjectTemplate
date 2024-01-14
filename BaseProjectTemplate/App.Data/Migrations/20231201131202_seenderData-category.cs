using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class seenderDatacategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppCategories",
                table: "AppCategories");

            migrationBuilder.RenameTable(
                name: "AppCategories",
                newName: "AppCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppCategory",
                table: "AppCategory",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AppCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, -1, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DANH MỤC TEST", null, "DANH MỤC TEST", -1, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AppCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 2, -1, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DANH MỤC TEST", null, "DANH MỤC TEST", -1, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AppCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedDate", "Description", "DisplayOrder", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 3, -1, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DANH MỤC TEST", null, "DANH MỤC TEST", -1, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppCategory",
                table: "AppCategory");

            migrationBuilder.DeleteData(
                table: "AppCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "AppCategory",
                newName: "AppCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppCategories",
                table: "AppCategories",
                column: "Id");
        }
    }
}
