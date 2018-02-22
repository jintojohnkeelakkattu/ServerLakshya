using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AdminSolution.Migrations
{
    public partial class check2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_ClientContact_ClientContactsID",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_ClientContactsID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ClientContactsID",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Events_ClientId",
                table: "Events",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_ClientContact_ClientId",
                table: "Events",
                column: "ClientId",
                principalTable: "ClientContact",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_ClientContact_ClientId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_ClientId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "ClientContactsID",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_ClientContactsID",
                table: "Events",
                column: "ClientContactsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_ClientContact_ClientContactsID",
                table: "Events",
                column: "ClientContactsID",
                principalTable: "ClientContact",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
