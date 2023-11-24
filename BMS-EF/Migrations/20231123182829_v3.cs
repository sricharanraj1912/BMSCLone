using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMS_EF.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "makePayments");

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "BookTickets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookTickets_UsersUserId",
                table: "BookTickets",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTickets_RegisterUsers_UsersUserId",
                table: "BookTickets",
                column: "UsersUserId",
                principalTable: "RegisterUsers",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTickets_RegisterUsers_UsersUserId",
                table: "BookTickets");

            migrationBuilder.DropIndex(
                name: "IX_BookTickets_UsersUserId",
                table: "BookTickets");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "BookTickets");

            migrationBuilder.CreateTable(
                name: "makePayments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usersUserId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_makePayments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_makePayments_RegisterUsers_usersUserId",
                        column: x => x.usersUserId,
                        principalTable: "RegisterUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_makePayments_usersUserId",
                table: "makePayments",
                column: "usersUserId");
        }
    }
}
