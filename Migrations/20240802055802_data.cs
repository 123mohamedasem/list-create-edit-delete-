using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace list_item.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "lists",
                columns: new[] { "Id", "Deadline", "Description", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 2, 22, 57, 59, 685, DateTimeKind.Local).AddTicks(4350), "Description 1", "Task 1" },
                    { 2, new DateTime(2024, 8, 3, 22, 57, 59, 685, DateTimeKind.Local).AddTicks(4407), "Description 2", "Task 2" },
                    { 3, new DateTime(2024, 8, 4, 22, 57, 59, 685, DateTimeKind.Local).AddTicks(4410), "Description 3", "Task 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "lists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "lists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "lists",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
