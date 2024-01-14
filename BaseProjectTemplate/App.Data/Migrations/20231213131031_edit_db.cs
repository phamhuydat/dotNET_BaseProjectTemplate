using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class edit_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1201,
                column: "GroupName",
                value: "Quản lý danh mục");

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1202,
                column: "GroupName",
                value: "Quản lý danh mục");

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1203,
                column: "GroupName",
                value: "Quản lý danh mục");

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1204,
                column: "GroupName",
                value: "Quản lý danh mục");

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1206,
                column: "GroupName",
                value: "Quản lý danh mục");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1201,
                column: "GroupName",
                value: "Quản lý người dùng");

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1202,
                column: "GroupName",
                value: "Quản lý người dùng");

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1203,
                column: "GroupName",
                value: "Quản lý người dùng");

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1204,
                column: "GroupName",
                value: "Quản lý người dùng");

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1206,
                column: "GroupName",
                value: "Quản lý người dùng");
        }
    }
}
