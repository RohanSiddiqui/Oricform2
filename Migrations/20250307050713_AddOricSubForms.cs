using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oricform2.Migrations
{
    /// <inheritdoc />
    public partial class AddOricSubForms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EvidenceFilePath",
                table: "VisitRepresentatives");

            migrationBuilder.DropColumn(
                name: "EvidenceFilePath",
                table: "TrainingWorkshopSeminars");

            migrationBuilder.DropColumn(
                name: "EvidenceFilePath",
                table: "ScienceArtsProducts");

            migrationBuilder.DropColumn(
                name: "FirstPageFilePath",
                table: "ResearchPublications");

            migrationBuilder.DropColumn(
                name: "EvidenceFilePath",
                table: "ResearchProducts");

            migrationBuilder.DropColumn(
                name: "FilingEvidenceFilePath",
                table: "Patents");

            migrationBuilder.DropColumn(
                name: "GrantingEvidenceFilePath",
                table: "Patents");

            migrationBuilder.DropColumn(
                name: "NegotiationEvidenceFilePath",
                table: "IPLicensingNegotiations");

            migrationBuilder.DropColumn(
                name: "DisclosureEvidenceFilePath",
                table: "IPDisclosures");

            migrationBuilder.DropColumn(
                name: "EvidenceFilePath",
                table: "HonorsAwards");

            migrationBuilder.DropColumn(
                name: "EvidenceFilePath",
                table: "ExhibitionEvents");

            migrationBuilder.DropColumn(
                name: "AgreementCoverCopyPath",
                table: "ExclusiveOrNonExclusives");

            migrationBuilder.DropColumn(
                name: "EvidenceFilePath",
                table: "ConferencesArranged");

            migrationBuilder.DropColumn(
                name: "EvidenceFilePath",
                table: "AgreementsSigned");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OricForms",
                newName: "ric_form_2_Id");

            migrationBuilder.AddColumn<byte[]>(
                name: "Evidence",
                table: "VisitRepresentatives",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "VisitRepresentatives",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ric_form_2_Id",
                table: "VisitRepresentatives",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Evidence",
                table: "TrainingWorkshopSeminars",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "TrainingWorkshopSeminars",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ric_form_2_Id",
                table: "TrainingWorkshopSeminars",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Evidence",
                table: "ScienceArtsProducts",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "ScienceArtsProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ric_form_2_Id",
                table: "ScienceArtsProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Evidence",
                table: "ResearchPublications",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "ResearchPublications",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ric_form_2_Id",
                table: "ResearchPublications",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Evidence",
                table: "ResearchProducts",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "ResearchProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ric_form_2_Id",
                table: "ResearchProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "FilingEvidence",
                table: "Patents",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "GrantingEvidence",
                table: "Patents",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "Patents",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ric_form_2_Id",
                table: "Patents",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Evidence",
                table: "IPLicensingNegotiations",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "IPLicensingNegotiations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ric_form_2_Id",
                table: "IPLicensingNegotiations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Evidence",
                table: "IPDisclosures",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "IPDisclosures",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ric_form_2_Id",
                table: "IPDisclosures",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Evidence",
                table: "HonorsAwards",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "HonorsAwards",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ric_form_2_Id",
                table: "HonorsAwards",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Evidence",
                table: "ExhibitionEvents",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "ExhibitionEvents",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ric_form_2_Id",
                table: "ExhibitionEvents",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Evidence",
                table: "ExclusiveOrNonExclusives",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "ExclusiveOrNonExclusives",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ric_form_2_Id",
                table: "ExclusiveOrNonExclusives",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Evidence",
                table: "ConferencesArranged",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "ConferencesArranged",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ric_form_2_Id",
                table: "ConferencesArranged",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Evidence",
                table: "AgreementsSigned",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "AgreementsSigned",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ric_form_2_Id",
                table: "AgreementsSigned",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VisitRepresentatives_OricForm2ric_form_2_Id",
                table: "VisitRepresentatives",
                column: "OricForm2ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWorkshopSeminars_OricForm2ric_form_2_Id",
                table: "TrainingWorkshopSeminars",
                column: "OricForm2ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ScienceArtsProducts_OricForm2ric_form_2_Id",
                table: "ScienceArtsProducts",
                column: "OricForm2ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchPublications_OricForm2ric_form_2_Id",
                table: "ResearchPublications",
                column: "OricForm2ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchProducts_OricForm2ric_form_2_Id",
                table: "ResearchProducts",
                column: "OricForm2ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patents_OricForm2ric_form_2_Id",
                table: "Patents",
                column: "OricForm2ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_IPLicensingNegotiations_OricForm2ric_form_2_Id",
                table: "IPLicensingNegotiations",
                column: "OricForm2ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_IPDisclosures_OricForm2ric_form_2_Id",
                table: "IPDisclosures",
                column: "OricForm2ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HonorsAwards_OricForm2ric_form_2_Id",
                table: "HonorsAwards",
                column: "OricForm2ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ExhibitionEvents_OricForm2ric_form_2_Id",
                table: "ExhibitionEvents",
                column: "OricForm2ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ExclusiveOrNonExclusives_OricForm2ric_form_2_Id",
                table: "ExclusiveOrNonExclusives",
                column: "OricForm2ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ConferencesArranged_OricForm2ric_form_2_Id",
                table: "ConferencesArranged",
                column: "OricForm2ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AgreementsSigned_OricForm2ric_form_2_Id",
                table: "AgreementsSigned",
                column: "OricForm2ric_form_2_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AgreementsSigned_OricForms_OricForm2ric_form_2_Id",
                table: "AgreementsSigned",
                column: "OricForm2ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConferencesArranged_OricForms_OricForm2ric_form_2_Id",
                table: "ConferencesArranged",
                column: "OricForm2ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExclusiveOrNonExclusives_OricForms_OricForm2ric_form_2_Id",
                table: "ExclusiveOrNonExclusives",
                column: "OricForm2ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExhibitionEvents_OricForms_OricForm2ric_form_2_Id",
                table: "ExhibitionEvents",
                column: "OricForm2ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HonorsAwards_OricForms_OricForm2ric_form_2_Id",
                table: "HonorsAwards",
                column: "OricForm2ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IPDisclosures_OricForms_OricForm2ric_form_2_Id",
                table: "IPDisclosures",
                column: "OricForm2ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IPLicensingNegotiations_OricForms_OricForm2ric_form_2_Id",
                table: "IPLicensingNegotiations",
                column: "OricForm2ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patents_OricForms_OricForm2ric_form_2_Id",
                table: "Patents",
                column: "OricForm2ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchProducts_OricForms_OricForm2ric_form_2_Id",
                table: "ResearchProducts",
                column: "OricForm2ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchPublications_OricForms_OricForm2ric_form_2_Id",
                table: "ResearchPublications",
                column: "OricForm2ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScienceArtsProducts_OricForms_OricForm2ric_form_2_Id",
                table: "ScienceArtsProducts",
                column: "OricForm2ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingWorkshopSeminars_OricForms_OricForm2ric_form_2_Id",
                table: "TrainingWorkshopSeminars",
                column: "OricForm2ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitRepresentatives_OricForms_OricForm2ric_form_2_Id",
                table: "VisitRepresentatives",
                column: "OricForm2ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgreementsSigned_OricForms_OricForm2ric_form_2_Id",
                table: "AgreementsSigned");

            migrationBuilder.DropForeignKey(
                name: "FK_ConferencesArranged_OricForms_OricForm2ric_form_2_Id",
                table: "ConferencesArranged");

            migrationBuilder.DropForeignKey(
                name: "FK_ExclusiveOrNonExclusives_OricForms_OricForm2ric_form_2_Id",
                table: "ExclusiveOrNonExclusives");

            migrationBuilder.DropForeignKey(
                name: "FK_ExhibitionEvents_OricForms_OricForm2ric_form_2_Id",
                table: "ExhibitionEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_HonorsAwards_OricForms_OricForm2ric_form_2_Id",
                table: "HonorsAwards");

            migrationBuilder.DropForeignKey(
                name: "FK_IPDisclosures_OricForms_OricForm2ric_form_2_Id",
                table: "IPDisclosures");

            migrationBuilder.DropForeignKey(
                name: "FK_IPLicensingNegotiations_OricForms_OricForm2ric_form_2_Id",
                table: "IPLicensingNegotiations");

            migrationBuilder.DropForeignKey(
                name: "FK_Patents_OricForms_OricForm2ric_form_2_Id",
                table: "Patents");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchProducts_OricForms_OricForm2ric_form_2_Id",
                table: "ResearchProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchPublications_OricForms_OricForm2ric_form_2_Id",
                table: "ResearchPublications");

            migrationBuilder.DropForeignKey(
                name: "FK_ScienceArtsProducts_OricForms_OricForm2ric_form_2_Id",
                table: "ScienceArtsProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingWorkshopSeminars_OricForms_OricForm2ric_form_2_Id",
                table: "TrainingWorkshopSeminars");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitRepresentatives_OricForms_OricForm2ric_form_2_Id",
                table: "VisitRepresentatives");

            migrationBuilder.DropIndex(
                name: "IX_VisitRepresentatives_OricForm2ric_form_2_Id",
                table: "VisitRepresentatives");

            migrationBuilder.DropIndex(
                name: "IX_TrainingWorkshopSeminars_OricForm2ric_form_2_Id",
                table: "TrainingWorkshopSeminars");

            migrationBuilder.DropIndex(
                name: "IX_ScienceArtsProducts_OricForm2ric_form_2_Id",
                table: "ScienceArtsProducts");

            migrationBuilder.DropIndex(
                name: "IX_ResearchPublications_OricForm2ric_form_2_Id",
                table: "ResearchPublications");

            migrationBuilder.DropIndex(
                name: "IX_ResearchProducts_OricForm2ric_form_2_Id",
                table: "ResearchProducts");

            migrationBuilder.DropIndex(
                name: "IX_Patents_OricForm2ric_form_2_Id",
                table: "Patents");

            migrationBuilder.DropIndex(
                name: "IX_IPLicensingNegotiations_OricForm2ric_form_2_Id",
                table: "IPLicensingNegotiations");

            migrationBuilder.DropIndex(
                name: "IX_IPDisclosures_OricForm2ric_form_2_Id",
                table: "IPDisclosures");

            migrationBuilder.DropIndex(
                name: "IX_HonorsAwards_OricForm2ric_form_2_Id",
                table: "HonorsAwards");

            migrationBuilder.DropIndex(
                name: "IX_ExhibitionEvents_OricForm2ric_form_2_Id",
                table: "ExhibitionEvents");

            migrationBuilder.DropIndex(
                name: "IX_ExclusiveOrNonExclusives_OricForm2ric_form_2_Id",
                table: "ExclusiveOrNonExclusives");

            migrationBuilder.DropIndex(
                name: "IX_ConferencesArranged_OricForm2ric_form_2_Id",
                table: "ConferencesArranged");

            migrationBuilder.DropIndex(
                name: "IX_AgreementsSigned_OricForm2ric_form_2_Id",
                table: "AgreementsSigned");

            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "VisitRepresentatives");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "VisitRepresentatives");

            migrationBuilder.DropColumn(
                name: "ric_form_2_Id",
                table: "VisitRepresentatives");

            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "TrainingWorkshopSeminars");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "TrainingWorkshopSeminars");

            migrationBuilder.DropColumn(
                name: "ric_form_2_Id",
                table: "TrainingWorkshopSeminars");

            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "ScienceArtsProducts");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "ScienceArtsProducts");

            migrationBuilder.DropColumn(
                name: "ric_form_2_Id",
                table: "ScienceArtsProducts");

            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "ResearchPublications");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "ResearchPublications");

            migrationBuilder.DropColumn(
                name: "ric_form_2_Id",
                table: "ResearchPublications");

            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "ResearchProducts");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "ResearchProducts");

            migrationBuilder.DropColumn(
                name: "ric_form_2_Id",
                table: "ResearchProducts");

            migrationBuilder.DropColumn(
                name: "FilingEvidence",
                table: "Patents");

            migrationBuilder.DropColumn(
                name: "GrantingEvidence",
                table: "Patents");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "Patents");

            migrationBuilder.DropColumn(
                name: "ric_form_2_Id",
                table: "Patents");

            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "IPLicensingNegotiations");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "IPLicensingNegotiations");

            migrationBuilder.DropColumn(
                name: "ric_form_2_Id",
                table: "IPLicensingNegotiations");

            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "IPDisclosures");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "IPDisclosures");

            migrationBuilder.DropColumn(
                name: "ric_form_2_Id",
                table: "IPDisclosures");

            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "HonorsAwards");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "HonorsAwards");

            migrationBuilder.DropColumn(
                name: "ric_form_2_Id",
                table: "HonorsAwards");

            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "ExhibitionEvents");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "ExhibitionEvents");

            migrationBuilder.DropColumn(
                name: "ric_form_2_Id",
                table: "ExhibitionEvents");

            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "ExclusiveOrNonExclusives");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "ExclusiveOrNonExclusives");

            migrationBuilder.DropColumn(
                name: "ric_form_2_Id",
                table: "ExclusiveOrNonExclusives");

            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "ConferencesArranged");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "ConferencesArranged");

            migrationBuilder.DropColumn(
                name: "ric_form_2_Id",
                table: "ConferencesArranged");

            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "AgreementsSigned");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "AgreementsSigned");

            migrationBuilder.DropColumn(
                name: "ric_form_2_Id",
                table: "AgreementsSigned");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_Id",
                table: "OricForms",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "EvidenceFilePath",
                table: "VisitRepresentatives",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvidenceFilePath",
                table: "TrainingWorkshopSeminars",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvidenceFilePath",
                table: "ScienceArtsProducts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstPageFilePath",
                table: "ResearchPublications",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvidenceFilePath",
                table: "ResearchProducts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FilingEvidenceFilePath",
                table: "Patents",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GrantingEvidenceFilePath",
                table: "Patents",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NegotiationEvidenceFilePath",
                table: "IPLicensingNegotiations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisclosureEvidenceFilePath",
                table: "IPDisclosures",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvidenceFilePath",
                table: "HonorsAwards",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvidenceFilePath",
                table: "ExhibitionEvents",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AgreementCoverCopyPath",
                table: "ExclusiveOrNonExclusives",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvidenceFilePath",
                table: "ConferencesArranged",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvidenceFilePath",
                table: "AgreementsSigned",
                type: "text",
                nullable: true);
        }
    }
}
