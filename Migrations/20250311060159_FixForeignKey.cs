using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oricform2.Migrations
{
    /// <inheritdoc />
    public partial class FixForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "OricForm2ric_form_2_Id",
                table: "VisitRepresentatives");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "TrainingWorkshopSeminars");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "ScienceArtsProducts");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "ResearchPublications");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "ResearchProducts");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "Patents");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "IPLicensingNegotiations");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "IPDisclosures");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "HonorsAwards");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "ExhibitionEvents");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "ExclusiveOrNonExclusives");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "ConferencesArranged");

            migrationBuilder.DropColumn(
                name: "OricForm2ric_form_2_Id",
                table: "AgreementsSigned");

            migrationBuilder.CreateIndex(
                name: "IX_VisitRepresentatives_ric_form_2_Id",
                table: "VisitRepresentatives",
                column: "ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWorkshopSeminars_ric_form_2_Id",
                table: "TrainingWorkshopSeminars",
                column: "ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ScienceArtsProducts_ric_form_2_Id",
                table: "ScienceArtsProducts",
                column: "ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchPublications_ric_form_2_Id",
                table: "ResearchPublications",
                column: "ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchProducts_ric_form_2_Id",
                table: "ResearchProducts",
                column: "ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patents_ric_form_2_Id",
                table: "Patents",
                column: "ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_IPLicensingNegotiations_ric_form_2_Id",
                table: "IPLicensingNegotiations",
                column: "ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_IPDisclosures_ric_form_2_Id",
                table: "IPDisclosures",
                column: "ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HonorsAwards_ric_form_2_Id",
                table: "HonorsAwards",
                column: "ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ExhibitionEvents_ric_form_2_Id",
                table: "ExhibitionEvents",
                column: "ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ExclusiveOrNonExclusives_ric_form_2_Id",
                table: "ExclusiveOrNonExclusives",
                column: "ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ConferencesArranged_ric_form_2_Id",
                table: "ConferencesArranged",
                column: "ric_form_2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AgreementsSigned_ric_form_2_Id",
                table: "AgreementsSigned",
                column: "ric_form_2_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AgreementsSigned_OricForms_ric_form_2_Id",
                table: "AgreementsSigned",
                column: "ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConferencesArranged_OricForms_ric_form_2_Id",
                table: "ConferencesArranged",
                column: "ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExclusiveOrNonExclusives_OricForms_ric_form_2_Id",
                table: "ExclusiveOrNonExclusives",
                column: "ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExhibitionEvents_OricForms_ric_form_2_Id",
                table: "ExhibitionEvents",
                column: "ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HonorsAwards_OricForms_ric_form_2_Id",
                table: "HonorsAwards",
                column: "ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IPDisclosures_OricForms_ric_form_2_Id",
                table: "IPDisclosures",
                column: "ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IPLicensingNegotiations_OricForms_ric_form_2_Id",
                table: "IPLicensingNegotiations",
                column: "ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patents_OricForms_ric_form_2_Id",
                table: "Patents",
                column: "ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchProducts_OricForms_ric_form_2_Id",
                table: "ResearchProducts",
                column: "ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchPublications_OricForms_ric_form_2_Id",
                table: "ResearchPublications",
                column: "ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScienceArtsProducts_OricForms_ric_form_2_Id",
                table: "ScienceArtsProducts",
                column: "ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingWorkshopSeminars_OricForms_ric_form_2_Id",
                table: "TrainingWorkshopSeminars",
                column: "ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitRepresentatives_OricForms_ric_form_2_Id",
                table: "VisitRepresentatives",
                column: "ric_form_2_Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgreementsSigned_OricForms_ric_form_2_Id",
                table: "AgreementsSigned");

            migrationBuilder.DropForeignKey(
                name: "FK_ConferencesArranged_OricForms_ric_form_2_Id",
                table: "ConferencesArranged");

            migrationBuilder.DropForeignKey(
                name: "FK_ExclusiveOrNonExclusives_OricForms_ric_form_2_Id",
                table: "ExclusiveOrNonExclusives");

            migrationBuilder.DropForeignKey(
                name: "FK_ExhibitionEvents_OricForms_ric_form_2_Id",
                table: "ExhibitionEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_HonorsAwards_OricForms_ric_form_2_Id",
                table: "HonorsAwards");

            migrationBuilder.DropForeignKey(
                name: "FK_IPDisclosures_OricForms_ric_form_2_Id",
                table: "IPDisclosures");

            migrationBuilder.DropForeignKey(
                name: "FK_IPLicensingNegotiations_OricForms_ric_form_2_Id",
                table: "IPLicensingNegotiations");

            migrationBuilder.DropForeignKey(
                name: "FK_Patents_OricForms_ric_form_2_Id",
                table: "Patents");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchProducts_OricForms_ric_form_2_Id",
                table: "ResearchProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchPublications_OricForms_ric_form_2_Id",
                table: "ResearchPublications");

            migrationBuilder.DropForeignKey(
                name: "FK_ScienceArtsProducts_OricForms_ric_form_2_Id",
                table: "ScienceArtsProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingWorkshopSeminars_OricForms_ric_form_2_Id",
                table: "TrainingWorkshopSeminars");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitRepresentatives_OricForms_ric_form_2_Id",
                table: "VisitRepresentatives");

            migrationBuilder.DropIndex(
                name: "IX_VisitRepresentatives_ric_form_2_Id",
                table: "VisitRepresentatives");

            migrationBuilder.DropIndex(
                name: "IX_TrainingWorkshopSeminars_ric_form_2_Id",
                table: "TrainingWorkshopSeminars");

            migrationBuilder.DropIndex(
                name: "IX_ScienceArtsProducts_ric_form_2_Id",
                table: "ScienceArtsProducts");

            migrationBuilder.DropIndex(
                name: "IX_ResearchPublications_ric_form_2_Id",
                table: "ResearchPublications");

            migrationBuilder.DropIndex(
                name: "IX_ResearchProducts_ric_form_2_Id",
                table: "ResearchProducts");

            migrationBuilder.DropIndex(
                name: "IX_Patents_ric_form_2_Id",
                table: "Patents");

            migrationBuilder.DropIndex(
                name: "IX_IPLicensingNegotiations_ric_form_2_Id",
                table: "IPLicensingNegotiations");

            migrationBuilder.DropIndex(
                name: "IX_IPDisclosures_ric_form_2_Id",
                table: "IPDisclosures");

            migrationBuilder.DropIndex(
                name: "IX_HonorsAwards_ric_form_2_Id",
                table: "HonorsAwards");

            migrationBuilder.DropIndex(
                name: "IX_ExhibitionEvents_ric_form_2_Id",
                table: "ExhibitionEvents");

            migrationBuilder.DropIndex(
                name: "IX_ExclusiveOrNonExclusives_ric_form_2_Id",
                table: "ExclusiveOrNonExclusives");

            migrationBuilder.DropIndex(
                name: "IX_ConferencesArranged_ric_form_2_Id",
                table: "ConferencesArranged");

            migrationBuilder.DropIndex(
                name: "IX_AgreementsSigned_ric_form_2_Id",
                table: "AgreementsSigned");

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "VisitRepresentatives",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "TrainingWorkshopSeminars",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "ScienceArtsProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "ResearchPublications",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "ResearchProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "Patents",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "IPLicensingNegotiations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "IPDisclosures",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "HonorsAwards",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "ExhibitionEvents",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "ExclusiveOrNonExclusives",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
                table: "ConferencesArranged",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OricForm2ric_form_2_Id",
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
    }
}
