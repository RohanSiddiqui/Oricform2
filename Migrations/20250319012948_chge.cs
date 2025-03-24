using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oricform2.Migrations
{
    /// <inheritdoc />
    public partial class chge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VisitorName",
                table: "VisitRepresentatives",
                newName: "visitorname");

            migrationBuilder.RenameColumn(
                name: "VisitDate",
                table: "VisitRepresentatives",
                newName: "visitdate");

            migrationBuilder.RenameColumn(
                name: "Evidence",
                table: "VisitRepresentatives",
                newName: "evidence");

            migrationBuilder.RenameColumn(
                name: "Agenda",
                table: "VisitRepresentatives",
                newName: "agenda");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "TrainingWorkshopSeminars",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "NumberOfParticipants",
                table: "TrainingWorkshopSeminars",
                newName: "numberofparticipants");

            migrationBuilder.RenameColumn(
                name: "FocusAndOutcomes",
                table: "TrainingWorkshopSeminars",
                newName: "focusandoutcomes");

            migrationBuilder.RenameColumn(
                name: "Evidence",
                table: "TrainingWorkshopSeminars",
                newName: "evidence");

            migrationBuilder.RenameColumn(
                name: "EventType",
                table: "TrainingWorkshopSeminars",
                newName: "eventtype");

            migrationBuilder.RenameColumn(
                name: "EventLevel",
                table: "TrainingWorkshopSeminars",
                newName: "eventlevel");

            migrationBuilder.RenameColumn(
                name: "EventDate",
                table: "TrainingWorkshopSeminars",
                newName: "eventdate");

            migrationBuilder.AlterColumn<string>(
                name: "evidence",
                table: "VisitRepresentatives",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "evidence",
                table: "TrainingWorkshopSeminars",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "evidence",
                table: "ScienceArtsProducts",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "evidence",
                table: "ResearchPublications",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "evidence",
                table: "ResearchProducts",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "grantingevidence",
                table: "Patents",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "filingevidence",
                table: "Patents",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "evidence",
                table: "IPLicensingNegotiations",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "evidence",
                table: "IPDisclosures",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "evidence",
                table: "HonorsAwards",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "evidence",
                table: "ExhibitionEvents",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "evidence",
                table: "ExclusiveOrNonExclusives",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "evidence",
                table: "ConferencesArranged",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "evidence",
                table: "AgreementsSigned",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "visitorname",
                table: "VisitRepresentatives",
                newName: "VisitorName");

            migrationBuilder.RenameColumn(
                name: "visitdate",
                table: "VisitRepresentatives",
                newName: "VisitDate");

            migrationBuilder.RenameColumn(
                name: "evidence",
                table: "VisitRepresentatives",
                newName: "Evidence");

            migrationBuilder.RenameColumn(
                name: "agenda",
                table: "VisitRepresentatives",
                newName: "Agenda");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "TrainingWorkshopSeminars",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "numberofparticipants",
                table: "TrainingWorkshopSeminars",
                newName: "NumberOfParticipants");

            migrationBuilder.RenameColumn(
                name: "focusandoutcomes",
                table: "TrainingWorkshopSeminars",
                newName: "FocusAndOutcomes");

            migrationBuilder.RenameColumn(
                name: "evidence",
                table: "TrainingWorkshopSeminars",
                newName: "Evidence");

            migrationBuilder.RenameColumn(
                name: "eventtype",
                table: "TrainingWorkshopSeminars",
                newName: "EventType");

            migrationBuilder.RenameColumn(
                name: "eventlevel",
                table: "TrainingWorkshopSeminars",
                newName: "EventLevel");

            migrationBuilder.RenameColumn(
                name: "eventdate",
                table: "TrainingWorkshopSeminars",
                newName: "EventDate");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Evidence",
                table: "VisitRepresentatives",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Evidence",
                table: "TrainingWorkshopSeminars",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "evidence",
                table: "ScienceArtsProducts",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "evidence",
                table: "ResearchPublications",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "evidence",
                table: "ResearchProducts",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "grantingevidence",
                table: "Patents",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "filingevidence",
                table: "Patents",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "evidence",
                table: "IPLicensingNegotiations",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "evidence",
                table: "IPDisclosures",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "evidence",
                table: "HonorsAwards",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "evidence",
                table: "ExhibitionEvents",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "evidence",
                table: "ExclusiveOrNonExclusives",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "evidence",
                table: "ConferencesArranged",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "evidence",
                table: "AgreementsSigned",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
