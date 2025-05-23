﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class add_relation_destination_to_reservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DestinationId",
                table: "Reservations",
                column: "DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Destinations_DestinationId",
                table: "Reservations",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "DesctinationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Destinations_DestinationId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_DestinationId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "DestinationId",
                table: "Reservations");
        }
    }
}
