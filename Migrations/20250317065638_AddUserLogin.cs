using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Oricform2.Migrations
{
    /// <inheritdoc />
    public partial class AddUserLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "SubmitAnotherResponse",
                table: "VisitRepresentatives");

            migrationBuilder.DropColumn(
                name: "SubmitAnotherResponse",
                table: "TrainingWorkshopSeminars");

            migrationBuilder.DropColumn(
                name: "SubmitAnotherResponse",
                table: "ScienceArtsProducts");

            migrationBuilder.DropColumn(
                name: "SubmitAnotherResponse",
                table: "ResearchPublications");

            migrationBuilder.DropColumn(
                name: "SubmitAnotherResponse",
                table: "ResearchProducts");

            migrationBuilder.DropColumn(
                name: "SubmitAnotherResponse",
                table: "Patents");

            migrationBuilder.DropColumn(
                name: "SubmitAnotherResponse",
                table: "IPLicensingNegotiations");

            migrationBuilder.DropColumn(
                name: "SubmitAnotherResponse",
                table: "IPDisclosures");

            migrationBuilder.DropColumn(
                name: "SubmitAnotherResponse",
                table: "HonorsAwards");

            migrationBuilder.DropColumn(
                name: "SubmitAnotherResponse",
                table: "ExhibitionEvents");

            migrationBuilder.DropColumn(
                name: "SubmitAnotherResponse",
                table: "ExclusiveOrNonExclusives");

            migrationBuilder.DropColumn(
                name: "SubmitAnotherResponse",
                table: "ConferencesArranged");

            migrationBuilder.DropColumn(
                name: "SubmitAnotherResponse",
                table: "AgreementsSigned");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_Id",
                table: "HonorsAwards",
                newName: "RicForm2Id");

            migrationBuilder.RenameIndex(
                name: "IX_HonorsAwards_ric_form_2_Id",
                table: "HonorsAwards",
                newName: "IX_HonorsAwards_RicForm2Id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_Id",
                table: "ExhibitionEvents",
                newName: "ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "NumberOfParticipants",
                table: "ExhibitionEvents",
                newName: "numberofparticipants");

            migrationBuilder.RenameColumn(
                name: "FocusAndOutcomes",
                table: "ExhibitionEvents",
                newName: "focusandoutcomes");

            migrationBuilder.RenameColumn(
                name: "Evidence",
                table: "ExhibitionEvents",
                newName: "evidence");

            migrationBuilder.RenameColumn(
                name: "EventType",
                table: "ExhibitionEvents",
                newName: "eventtype");

            migrationBuilder.RenameColumn(
                name: "EventLevel",
                table: "ExhibitionEvents",
                newName: "eventlevel");

            migrationBuilder.RenameColumn(
                name: "EventDate",
                table: "ExhibitionEvents",
                newName: "eventdate");

            migrationBuilder.RenameColumn(
                name: "AudienceType",
                table: "ExhibitionEvents",
                newName: "audiencetype");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ExhibitionEvents",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_ExhibitionEvents_ric_form_2_Id",
                table: "ExhibitionEvents",
                newName: "IX_ExhibitionEvents_ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_Id",
                table: "ExclusiveOrNonExclusives",
                newName: "ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "LicenseType",
                table: "ExclusiveOrNonExclusives",
                newName: "licensetype");

            migrationBuilder.RenameColumn(
                name: "LicenseRegion",
                table: "ExclusiveOrNonExclusives",
                newName: "licenseregion");

            migrationBuilder.RenameColumn(
                name: "LicenseDetails",
                table: "ExclusiveOrNonExclusives",
                newName: "licensedetails");

            migrationBuilder.RenameColumn(
                name: "LeadInventorName",
                table: "ExclusiveOrNonExclusives",
                newName: "leadinventorname");

            migrationBuilder.RenameColumn(
                name: "LeadInventorDesignation",
                table: "ExclusiveOrNonExclusives",
                newName: "leadinventordesignation");

            migrationBuilder.RenameColumn(
                name: "LeadInventorDepartment",
                table: "ExclusiveOrNonExclusives",
                newName: "leadinventordepartment");

            migrationBuilder.RenameColumn(
                name: "KeyScientificAspects",
                table: "ExclusiveOrNonExclusives",
                newName: "keyscientificaspects");

            migrationBuilder.RenameColumn(
                name: "InventionTitle",
                table: "ExclusiveOrNonExclusives",
                newName: "inventiontitle");

            migrationBuilder.RenameColumn(
                name: "IPCategory",
                table: "ExclusiveOrNonExclusives",
                newName: "ipcategory");

            migrationBuilder.RenameColumn(
                name: "FieldOfUse",
                table: "ExclusiveOrNonExclusives",
                newName: "fieldofuse");

            migrationBuilder.RenameColumn(
                name: "Evidence",
                table: "ExclusiveOrNonExclusives",
                newName: "evidence");

            migrationBuilder.RenameColumn(
                name: "DevelopmentStatus",
                table: "ExclusiveOrNonExclusives",
                newName: "developmentstatus");

            migrationBuilder.RenameColumn(
                name: "DateAndDurationOfAgreement",
                table: "ExclusiveOrNonExclusives",
                newName: "dateanddurationofagreement");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ExclusiveOrNonExclusives",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_ExclusiveOrNonExclusives_ric_form_2_Id",
                table: "ExclusiveOrNonExclusives",
                newName: "IX_ExclusiveOrNonExclusives_ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_Id",
                table: "ConferencesArranged",
                newName: "ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "ConferencesArranged",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Organizer",
                table: "ConferencesArranged",
                newName: "organizer");

            migrationBuilder.RenameColumn(
                name: "NumberOfParticipants",
                table: "ConferencesArranged",
                newName: "numberofparticipants");

            migrationBuilder.RenameColumn(
                name: "FocusAndOutcomes",
                table: "ConferencesArranged",
                newName: "focusandoutcomes");

            migrationBuilder.RenameColumn(
                name: "Evidence",
                table: "ConferencesArranged",
                newName: "evidence");

            migrationBuilder.RenameColumn(
                name: "EventType",
                table: "ConferencesArranged",
                newName: "eventtype");

            migrationBuilder.RenameColumn(
                name: "EventLevel",
                table: "ConferencesArranged",
                newName: "eventlevel");

            migrationBuilder.RenameColumn(
                name: "EventDate",
                table: "ConferencesArranged",
                newName: "eventdate");

            migrationBuilder.RenameColumn(
                name: "AudienceType",
                table: "ConferencesArranged",
                newName: "audiencetype");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ConferencesArranged",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_ConferencesArranged_ric_form_2_Id",
                table: "ConferencesArranged",
                newName: "IX_ConferencesArranged_ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_Id",
                table: "AgreementsSigned",
                newName: "ric_form_2_id");

            migrationBuilder.RenameColumn(
                name: "TypeOfLinkage",
                table: "AgreementsSigned",
                newName: "typeoflinkage");

            migrationBuilder.RenameColumn(
                name: "ScopeOfCollaboration",
                table: "AgreementsSigned",
                newName: "scopeofcollaboration");

            migrationBuilder.RenameColumn(
                name: "NationalOrInternational",
                table: "AgreementsSigned",
                newName: "nationalorinternational");

            migrationBuilder.RenameColumn(
                name: "LinkageEstablishmentDate",
                table: "AgreementsSigned",
                newName: "linkageestablishmentdate");

            migrationBuilder.RenameColumn(
                name: "KeyInitiatives",
                table: "AgreementsSigned",
                newName: "keyinitiatives");

            migrationBuilder.RenameColumn(
                name: "HostInstitutionNameAndAddress",
                table: "AgreementsSigned",
                newName: "hostinstitutionnameandaddress");

            migrationBuilder.RenameColumn(
                name: "FinancialSupport",
                table: "AgreementsSigned",
                newName: "financialsupport");

            migrationBuilder.RenameColumn(
                name: "Field",
                table: "AgreementsSigned",
                newName: "field");

            migrationBuilder.RenameColumn(
                name: "Evidence",
                table: "AgreementsSigned",
                newName: "evidence");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "AgreementsSigned",
                newName: "duration");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AgreementsSigned",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_AgreementsSigned_ric_form_2_Id",
                table: "AgreementsSigned",
                newName: "IX_AgreementsSigned_ric_form_2_id");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    dataoric_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    role = table.Column<string>(type: "text", nullable: false),
                    department_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.dataoric_id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AgreementsSigned_OricForms_ric_form_2_id",
                table: "AgreementsSigned",
                column: "ric_form_2_id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConferencesArranged_OricForms_ric_form_2_id",
                table: "ConferencesArranged",
                column: "ric_form_2_id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExclusiveOrNonExclusives_OricForms_ric_form_2_id",
                table: "ExclusiveOrNonExclusives",
                column: "ric_form_2_id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExhibitionEvents_OricForms_ric_form_2_id",
                table: "ExhibitionEvents",
                column: "ric_form_2_id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HonorsAwards_OricForms_RicForm2Id",
                table: "HonorsAwards",
                column: "RicForm2Id",
                principalTable: "OricForms",
                principalColumn: "ric_form_2_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgreementsSigned_OricForms_ric_form_2_id",
                table: "AgreementsSigned");

            migrationBuilder.DropForeignKey(
                name: "FK_ConferencesArranged_OricForms_ric_form_2_id",
                table: "ConferencesArranged");

            migrationBuilder.DropForeignKey(
                name: "FK_ExclusiveOrNonExclusives_OricForms_ric_form_2_id",
                table: "ExclusiveOrNonExclusives");

            migrationBuilder.DropForeignKey(
                name: "FK_ExhibitionEvents_OricForms_ric_form_2_id",
                table: "ExhibitionEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_HonorsAwards_OricForms_RicForm2Id",
                table: "HonorsAwards");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.RenameColumn(
                name: "RicForm2Id",
                table: "HonorsAwards",
                newName: "ric_form_2_Id");

            migrationBuilder.RenameIndex(
                name: "IX_HonorsAwards_RicForm2Id",
                table: "HonorsAwards",
                newName: "IX_HonorsAwards_ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_id",
                table: "ExhibitionEvents",
                newName: "ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "numberofparticipants",
                table: "ExhibitionEvents",
                newName: "NumberOfParticipants");

            migrationBuilder.RenameColumn(
                name: "focusandoutcomes",
                table: "ExhibitionEvents",
                newName: "FocusAndOutcomes");

            migrationBuilder.RenameColumn(
                name: "evidence",
                table: "ExhibitionEvents",
                newName: "Evidence");

            migrationBuilder.RenameColumn(
                name: "eventtype",
                table: "ExhibitionEvents",
                newName: "EventType");

            migrationBuilder.RenameColumn(
                name: "eventlevel",
                table: "ExhibitionEvents",
                newName: "EventLevel");

            migrationBuilder.RenameColumn(
                name: "eventdate",
                table: "ExhibitionEvents",
                newName: "EventDate");

            migrationBuilder.RenameColumn(
                name: "audiencetype",
                table: "ExhibitionEvents",
                newName: "AudienceType");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ExhibitionEvents",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ExhibitionEvents_ric_form_2_id",
                table: "ExhibitionEvents",
                newName: "IX_ExhibitionEvents_ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_id",
                table: "ExclusiveOrNonExclusives",
                newName: "ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "licensetype",
                table: "ExclusiveOrNonExclusives",
                newName: "LicenseType");

            migrationBuilder.RenameColumn(
                name: "licenseregion",
                table: "ExclusiveOrNonExclusives",
                newName: "LicenseRegion");

            migrationBuilder.RenameColumn(
                name: "licensedetails",
                table: "ExclusiveOrNonExclusives",
                newName: "LicenseDetails");

            migrationBuilder.RenameColumn(
                name: "leadinventorname",
                table: "ExclusiveOrNonExclusives",
                newName: "LeadInventorName");

            migrationBuilder.RenameColumn(
                name: "leadinventordesignation",
                table: "ExclusiveOrNonExclusives",
                newName: "LeadInventorDesignation");

            migrationBuilder.RenameColumn(
                name: "leadinventordepartment",
                table: "ExclusiveOrNonExclusives",
                newName: "LeadInventorDepartment");

            migrationBuilder.RenameColumn(
                name: "keyscientificaspects",
                table: "ExclusiveOrNonExclusives",
                newName: "KeyScientificAspects");

            migrationBuilder.RenameColumn(
                name: "ipcategory",
                table: "ExclusiveOrNonExclusives",
                newName: "IPCategory");

            migrationBuilder.RenameColumn(
                name: "inventiontitle",
                table: "ExclusiveOrNonExclusives",
                newName: "InventionTitle");

            migrationBuilder.RenameColumn(
                name: "fieldofuse",
                table: "ExclusiveOrNonExclusives",
                newName: "FieldOfUse");

            migrationBuilder.RenameColumn(
                name: "evidence",
                table: "ExclusiveOrNonExclusives",
                newName: "Evidence");

            migrationBuilder.RenameColumn(
                name: "developmentstatus",
                table: "ExclusiveOrNonExclusives",
                newName: "DevelopmentStatus");

            migrationBuilder.RenameColumn(
                name: "dateanddurationofagreement",
                table: "ExclusiveOrNonExclusives",
                newName: "DateAndDurationOfAgreement");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ExclusiveOrNonExclusives",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ExclusiveOrNonExclusives_ric_form_2_id",
                table: "ExclusiveOrNonExclusives",
                newName: "IX_ExclusiveOrNonExclusives_ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "ConferencesArranged",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_id",
                table: "ConferencesArranged",
                newName: "ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "organizer",
                table: "ConferencesArranged",
                newName: "Organizer");

            migrationBuilder.RenameColumn(
                name: "numberofparticipants",
                table: "ConferencesArranged",
                newName: "NumberOfParticipants");

            migrationBuilder.RenameColumn(
                name: "focusandoutcomes",
                table: "ConferencesArranged",
                newName: "FocusAndOutcomes");

            migrationBuilder.RenameColumn(
                name: "evidence",
                table: "ConferencesArranged",
                newName: "Evidence");

            migrationBuilder.RenameColumn(
                name: "eventtype",
                table: "ConferencesArranged",
                newName: "EventType");

            migrationBuilder.RenameColumn(
                name: "eventlevel",
                table: "ConferencesArranged",
                newName: "EventLevel");

            migrationBuilder.RenameColumn(
                name: "eventdate",
                table: "ConferencesArranged",
                newName: "EventDate");

            migrationBuilder.RenameColumn(
                name: "audiencetype",
                table: "ConferencesArranged",
                newName: "AudienceType");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ConferencesArranged",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ConferencesArranged_ric_form_2_id",
                table: "ConferencesArranged",
                newName: "IX_ConferencesArranged_ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "typeoflinkage",
                table: "AgreementsSigned",
                newName: "TypeOfLinkage");

            migrationBuilder.RenameColumn(
                name: "scopeofcollaboration",
                table: "AgreementsSigned",
                newName: "ScopeOfCollaboration");

            migrationBuilder.RenameColumn(
                name: "ric_form_2_id",
                table: "AgreementsSigned",
                newName: "ric_form_2_Id");

            migrationBuilder.RenameColumn(
                name: "nationalorinternational",
                table: "AgreementsSigned",
                newName: "NationalOrInternational");

            migrationBuilder.RenameColumn(
                name: "linkageestablishmentdate",
                table: "AgreementsSigned",
                newName: "LinkageEstablishmentDate");

            migrationBuilder.RenameColumn(
                name: "keyinitiatives",
                table: "AgreementsSigned",
                newName: "KeyInitiatives");

            migrationBuilder.RenameColumn(
                name: "hostinstitutionnameandaddress",
                table: "AgreementsSigned",
                newName: "HostInstitutionNameAndAddress");

            migrationBuilder.RenameColumn(
                name: "financialsupport",
                table: "AgreementsSigned",
                newName: "FinancialSupport");

            migrationBuilder.RenameColumn(
                name: "field",
                table: "AgreementsSigned",
                newName: "Field");

            migrationBuilder.RenameColumn(
                name: "evidence",
                table: "AgreementsSigned",
                newName: "Evidence");

            migrationBuilder.RenameColumn(
                name: "duration",
                table: "AgreementsSigned",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AgreementsSigned",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_AgreementsSigned_ric_form_2_id",
                table: "AgreementsSigned",
                newName: "IX_AgreementsSigned_ric_form_2_Id");

            migrationBuilder.AddColumn<bool>(
                name: "SubmitAnotherResponse",
                table: "VisitRepresentatives",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SubmitAnotherResponse",
                table: "TrainingWorkshopSeminars",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SubmitAnotherResponse",
                table: "ScienceArtsProducts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SubmitAnotherResponse",
                table: "ResearchPublications",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SubmitAnotherResponse",
                table: "ResearchProducts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SubmitAnotherResponse",
                table: "Patents",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SubmitAnotherResponse",
                table: "IPLicensingNegotiations",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SubmitAnotherResponse",
                table: "IPDisclosures",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SubmitAnotherResponse",
                table: "HonorsAwards",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SubmitAnotherResponse",
                table: "ExhibitionEvents",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SubmitAnotherResponse",
                table: "ExclusiveOrNonExclusives",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SubmitAnotherResponse",
                table: "ConferencesArranged",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SubmitAnotherResponse",
                table: "AgreementsSigned",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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
        }
    }
}
