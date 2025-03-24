using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oricform2.Migrations
{
    /// <inheritdoc />
    public partial class RenameIdToRicForm2Id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HonorsAwards_OricForms_RicForm2Id",
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

            migrationBuilder.RenameColumn(
                name: "ric_form_2_Id",
                table: "VisitRepresentatives",
                newName: "ric_form_2_id");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRepresentatives_ric_form_2_Id",
                table: "VisitRepresentatives",
                newName: "IX_VisitRepresentatives_ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_Id",
                table: "TrainingWorkshopSeminars",
                newName: "ric_form_2_id");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingWorkshopSeminars_ric_form_2_Id",
                table: "TrainingWorkshopSeminars",
                newName: "IX_TrainingWorkshopSeminars_ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_Id",
                table: "ScienceArtsProducts",
                newName: "ric_form_2_id");

            migrationBuilder.RenameIndex(
                name: "IX_ScienceArtsProducts_ric_form_2_Id",
                table: "ScienceArtsProducts",
                newName: "IX_ScienceArtsProducts_ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_Id",
                table: "ResearchPublications",
                newName: "ric_form_2_id");

            migrationBuilder.RenameIndex(
                name: "IX_ResearchPublications_ric_form_2_Id",
                table: "ResearchPublications",
                newName: "IX_ResearchPublications_ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_Id",
                table: "ResearchProducts",
                newName: "ric_form_2_id");

            migrationBuilder.RenameIndex(
                name: "IX_ResearchProducts_ric_form_2_Id",
                table: "ResearchProducts",
                newName: "IX_ResearchProducts_ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_Id",
                table: "Patents",
                newName: "ric_form_2_id");

            migrationBuilder.RenameIndex(
                name: "IX_Patents_ric_form_2_Id",
                table: "Patents",
                newName: "IX_Patents_ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_Id",
                table: "OricForms",
                newName: "ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_Id",
                table: "IPLicensingNegotiations",
                newName: "ric_form_2_id");

            migrationBuilder.RenameIndex(
                name: "IX_IPLicensingNegotiations_ric_form_2_Id",
                table: "IPLicensingNegotiations",
                newName: "IX_IPLicensingNegotiations_ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_Id",
                table: "IPDisclosures",
                newName: "ric_form_2_id");

            migrationBuilder.RenameIndex(
                name: "IX_IPDisclosures_ric_form_2_Id",
                table: "IPDisclosures",
                newName: "IX_IPDisclosures_ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "RicForm2Id",
                table: "HonorsAwards",
                newName: "ric_form_2_id");

            migrationBuilder.RenameIndex(
                name: "IX_HonorsAwards_RicForm2Id",
                table: "HonorsAwards",
                newName: "IX_HonorsAwards_ric_form_2_id");

            migrationBuilder.AddForeignKey(
                name: "FK_HonorsAwards_OricForms_ric_form_2_id",
                table: "HonorsAwards",
                column: "ric_form_2_id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IPDisclosures_OricForms_ric_form_2_id",
                table: "IPDisclosures",
                column: "ric_form_2_id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IPLicensingNegotiations_OricForms_ric_form_2_id",
                table: "IPLicensingNegotiations",
                column: "ric_form_2_id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patents_OricForms_ric_form_2_id",
                table: "Patents",
                column: "ric_form_2_id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchProducts_OricForms_ric_form_2_id",
                table: "ResearchProducts",
                column: "ric_form_2_id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchPublications_OricForms_ric_form_2_id",
                table: "ResearchPublications",
                column: "ric_form_2_id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScienceArtsProducts_OricForms_ric_form_2_id",
                table: "ScienceArtsProducts",
                column: "ric_form_2_id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingWorkshopSeminars_OricForms_ric_form_2_id",
                table: "TrainingWorkshopSeminars",
                column: "ric_form_2_id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitRepresentatives_OricForms_ric_form_2_id",
                table: "VisitRepresentatives",
                column: "ric_form_2_id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HonorsAwards_OricForms_ric_form_2_id",
                table: "HonorsAwards");

            migrationBuilder.DropForeignKey(
                name: "FK_IPDisclosures_OricForms_ric_form_2_id",
                table: "IPDisclosures");

            migrationBuilder.DropForeignKey(
                name: "FK_IPLicensingNegotiations_OricForms_ric_form_2_id",
                table: "IPLicensingNegotiations");

            migrationBuilder.DropForeignKey(
                name: "FK_Patents_OricForms_ric_form_2_id",
                table: "Patents");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchProducts_OricForms_ric_form_2_id",
                table: "ResearchProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_ResearchPublications_OricForms_ric_form_2_id",
                table: "ResearchPublications");

            migrationBuilder.DropForeignKey(
                name: "FK_ScienceArtsProducts_OricForms_ric_form_2_id",
                table: "ScienceArtsProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingWorkshopSeminars_OricForms_ric_form_2_id",
                table: "TrainingWorkshopSeminars");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitRepresentatives_OricForms_ric_form_2_id",
                table: "VisitRepresentatives");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_id",
                table: "VisitRepresentatives",
                newName: "ric_form_2_Id");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRepresentatives_ric_form_2_id",
                table: "VisitRepresentatives",
                newName: "IX_VisitRepresentatives_ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_id",
                table: "TrainingWorkshopSeminars",
                newName: "ric_form_2_Id");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingWorkshopSeminars_ric_form_2_id",
                table: "TrainingWorkshopSeminars",
                newName: "IX_TrainingWorkshopSeminars_ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_id",
                table: "ScienceArtsProducts",
                newName: "ric_form_2_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ScienceArtsProducts_ric_form_2_id",
                table: "ScienceArtsProducts",
                newName: "IX_ScienceArtsProducts_ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_id",
                table: "ResearchPublications",
                newName: "ric_form_2_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ResearchPublications_ric_form_2_id",
                table: "ResearchPublications",
                newName: "IX_ResearchPublications_ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_id",
                table: "ResearchProducts",
                newName: "ric_form_2_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ResearchProducts_ric_form_2_id",
                table: "ResearchProducts",
                newName: "IX_ResearchProducts_ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_id",
                table: "Patents",
                newName: "ric_form_2_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Patents_ric_form_2_id",
                table: "Patents",
                newName: "IX_Patents_ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_id",
                table: "OricForms",
                newName: "ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_id",
                table: "IPLicensingNegotiations",
                newName: "ric_form_2_Id");

            migrationBuilder.RenameIndex(
                name: "IX_IPLicensingNegotiations_ric_form_2_id",
                table: "IPLicensingNegotiations",
                newName: "IX_IPLicensingNegotiations_ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_id",
                table: "IPDisclosures",
                newName: "ric_form_2_Id");

            migrationBuilder.RenameIndex(
                name: "IX_IPDisclosures_ric_form_2_id",
                table: "IPDisclosures",
                newName: "IX_IPDisclosures_ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_id",
                table: "HonorsAwards",
                newName: "RicForm2Id");

            migrationBuilder.RenameIndex(
                name: "IX_HonorsAwards_ric_form_2_id",
                table: "HonorsAwards",
                newName: "IX_HonorsAwards_RicForm2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HonorsAwards_OricForms_RicForm2Id",
                table: "HonorsAwards",
                column: "RicForm2Id",
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
    }
}
