using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oricform2.Migrations
{
    /// <inheritdoc />
    public partial class pk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VisitRepresentatives",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TrainingWorkshopSeminars",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ScienceArtsProducts",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ResearchPublications",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ResearchProducts",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Patents",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "IPLicensingNegotiations",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "IPDisclosures",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HonorsAwards",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "VisitRepresentatives",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TrainingWorkshopSeminars",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ScienceArtsProducts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ResearchPublications",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ResearchProducts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Patents",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "IPLicensingNegotiations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "IPDisclosures",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "HonorsAwards",
                newName: "Id");
        }
    }
}
