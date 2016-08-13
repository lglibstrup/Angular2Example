using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MC.DataAccess.Migrations
{
    public partial class Foreignkeytest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Networks_NetworkId1",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_NetworkId1",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "NetworkId1",
                table: "Items");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NetworkId1",
                table: "Items",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_NetworkId1",
                table: "Items",
                column: "NetworkId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Networks_NetworkId1",
                table: "Items",
                column: "NetworkId1",
                principalTable: "Networks",
                principalColumn: "NetworkId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
