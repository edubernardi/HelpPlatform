using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelpPlatform.Migrations
{
    /// <inheritdoc />
    public partial class DonationRequests2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_donationRequests",
                table: "donationRequests");

            migrationBuilder.RenameTable(
                name: "donationRequests",
                newName: "DonationRequests");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DonationRequests",
                table: "DonationRequests",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DonationRequests",
                table: "DonationRequests");

            migrationBuilder.RenameTable(
                name: "DonationRequests",
                newName: "donationRequests");

            migrationBuilder.AddPrimaryKey(
                name: "PK_donationRequests",
                table: "donationRequests",
                column: "Id");
        }
    }
}
