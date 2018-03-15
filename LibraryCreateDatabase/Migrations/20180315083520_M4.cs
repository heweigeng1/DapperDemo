using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryCreateDatabase.Migrations
{
    public partial class M4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AreaCode",
                table: "Areas",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Areas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Delflag",
                table: "Areas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                table: "Areas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentAreaCode",
                table: "Areas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaCode",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "Delflag",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "ParentAreaCode",
                table: "Areas");
        }
    }
}
