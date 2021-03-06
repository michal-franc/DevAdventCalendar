﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DevAdventCalendarCompetition.Repository.Migrations
{
    public partial class FixedMappings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestAnswer_AspNetUsers_UserId",
                table: "TestAnswer");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "TestAnswer",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TestAnswer_AspNetUsers_UserId",
                table: "TestAnswer",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestAnswer_AspNetUsers_UserId",
                table: "TestAnswer");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "TestAnswer",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_TestAnswer_AspNetUsers_UserId",
                table: "TestAnswer",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
