using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AdminSolution.Migrations
{
    public partial class @default : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientContact",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    alternateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clientAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientContact", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientContact");
        }
    }
}
