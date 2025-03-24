using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Oricform2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgreementsSigned",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeOfLinkage = table.Column<string>(type: "text", nullable: false),
                    NationalOrInternational = table.Column<string>(type: "text", nullable: false),
                    HostInstitutionNameAndAddress = table.Column<string>(type: "text", nullable: false),
                    Duration = table.Column<string>(type: "text", nullable: false),
                    KeyInitiatives = table.Column<string>(type: "text", nullable: false),
                    Field = table.Column<string>(type: "text", nullable: false),
                    ScopeOfCollaboration = table.Column<string>(type: "text", nullable: false),
                    LinkageEstablishmentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FinancialSupport = table.Column<string>(type: "text", nullable: true),
                    EvidenceFilePath = table.Column<string>(type: "text", nullable: true),
                    SubmitAnotherResponse = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgreementsSigned", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConferencesArranged",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EventType = table.Column<string>(type: "text", nullable: false),
                    EventLevel = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    EventDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NumberOfParticipants = table.Column<int>(type: "integer", nullable: false),
                    FocusAndOutcomes = table.Column<string>(type: "text", nullable: false),
                    Organizer = table.Column<string>(type: "text", nullable: false),
                    AudienceType = table.Column<string>(type: "text", nullable: false),
                    EvidenceFilePath = table.Column<string>(type: "text", nullable: true),
                    SubmitAnotherResponse = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConferencesArranged", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExclusiveOrNonExclusives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LicenseType = table.Column<string>(type: "text", nullable: false),
                    LicenseRegion = table.Column<string>(type: "text", nullable: false),
                    LeadInventorName = table.Column<string>(type: "text", nullable: false),
                    LeadInventorDesignation = table.Column<string>(type: "text", nullable: false),
                    LeadInventorDepartment = table.Column<string>(type: "text", nullable: false),
                    InventionTitle = table.Column<string>(type: "text", nullable: false),
                    IPCategory = table.Column<string>(type: "text", nullable: false),
                    DevelopmentStatus = table.Column<string>(type: "text", nullable: false),
                    KeyScientificAspects = table.Column<string>(type: "text", nullable: false),
                    FieldOfUse = table.Column<string>(type: "text", nullable: false),
                    DateAndDurationOfAgreement = table.Column<string>(type: "text", nullable: false),
                    LicenseDetails = table.Column<string>(type: "text", nullable: false),
                    AgreementCoverCopyPath = table.Column<string>(type: "text", nullable: true),
                    SubmitAnotherResponse = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExclusiveOrNonExclusives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExhibitionEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EventLevel = table.Column<string>(type: "text", nullable: false),
                    EventType = table.Column<string>(type: "text", nullable: false),
                    EventDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NumberOfParticipants = table.Column<int>(type: "integer", nullable: false),
                    FocusAndOutcomes = table.Column<string>(type: "text", nullable: false),
                    AudienceType = table.Column<string>(type: "text", nullable: false),
                    EvidenceFilePath = table.Column<string>(type: "text", nullable: true),
                    SubmitAnotherResponse = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExhibitionEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HonorsAwards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    ForumOrOrganization = table.Column<string>(type: "text", nullable: false),
                    AwardReceived = table.Column<string>(type: "text", nullable: false),
                    WorkDetails = table.Column<string>(type: "text", nullable: false),
                    PrizeMoney = table.Column<decimal>(type: "numeric", nullable: true),
                    AwardWinnerDetails = table.Column<string>(type: "text", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: true),
                    EvidenceFilePath = table.Column<string>(type: "text", nullable: true),
                    SubmitAnotherResponse = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HonorsAwards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IPDisclosures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LeadInventorName = table.Column<string>(type: "text", nullable: false),
                    LeadInventorDesignation = table.Column<string>(type: "text", nullable: false),
                    LeadInventorDepartment = table.Column<string>(type: "text", nullable: false),
                    InventionTitle = table.Column<string>(type: "text", nullable: false),
                    IPCategory = table.Column<string>(type: "text", nullable: false),
                    DevelopmentStatus = table.Column<string>(type: "text", nullable: false),
                    KeyScientificAspects = table.Column<string>(type: "text", nullable: false),
                    CommercialPartner = table.Column<string>(type: "text", nullable: true),
                    DisclosureMadeWith = table.Column<string>(type: "text", nullable: false),
                    DisclosureMadeDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FinancialSupport = table.Column<string>(type: "text", nullable: true),
                    PreviousDisclosure = table.Column<string>(type: "text", nullable: true),
                    DisclosureEvidenceFilePath = table.Column<string>(type: "text", nullable: true),
                    SubmitAnotherResponse = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPDisclosures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IPLicensingNegotiations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LicensingType = table.Column<string>(type: "text", nullable: false),
                    LeadInventorName = table.Column<string>(type: "text", nullable: false),
                    LeadInventorDesignation = table.Column<string>(type: "text", nullable: false),
                    LeadInventorDepartment = table.Column<string>(type: "text", nullable: false),
                    InventionTitle = table.Column<string>(type: "text", nullable: false),
                    IPCategory = table.Column<string>(type: "text", nullable: false),
                    DevelopmentStatus = table.Column<string>(type: "text", nullable: false),
                    KeyScientificAspects = table.Column<string>(type: "text", nullable: false),
                    FieldOfUse = table.Column<string>(type: "text", nullable: false),
                    DurationOfAgreement = table.Column<string>(type: "text", nullable: false),
                    LicenseDetails = table.Column<string>(type: "text", nullable: false),
                    StatusOfNegotiation = table.Column<string>(type: "text", nullable: false),
                    NegotiationEvidenceFilePath = table.Column<string>(type: "text", nullable: true),
                    SubmitAnotherResponse = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPLicensingNegotiations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OricForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FacultyMemberName = table.Column<string>(type: "text", nullable: false),
                    DepartmentName = table.Column<string>(type: "text", nullable: false),
                    FacultyEmail = table.Column<string>(type: "text", nullable: false),
                    IPDisclosuresCount = table.Column<int>(type: "integer", nullable: true),
                    PatentsFiledCount = table.Column<int>(type: "integer", nullable: true),
                    PatentsGrantedCount = table.Column<int>(type: "integer", nullable: true),
                    LicensingNegotiationsCount = table.Column<int>(type: "integer", nullable: true),
                    LicensesSignedCount = table.Column<int>(type: "integer", nullable: true),
                    ProductsDevelopedCount = table.Column<int>(type: "integer", nullable: true),
                    ProductsDisplayedCount = table.Column<int>(type: "integer", nullable: true),
                    IndustryVisitsCount = table.Column<int>(type: "integer", nullable: true),
                    CollaborationAgreementsCount = table.Column<int>(type: "integer", nullable: true),
                    HonorsAwardsCount = table.Column<int>(type: "integer", nullable: true),
                    ORICTrainingsCount = table.Column<int>(type: "integer", nullable: true),
                    ExternalTrainingsCount = table.Column<int>(type: "integer", nullable: true),
                    ResearchPublicationsCount = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OricForms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FiledOrGranted = table.Column<string>(type: "text", nullable: false),
                    NationalOrInternational = table.Column<string>(type: "text", nullable: false),
                    LeadInventorName = table.Column<string>(type: "text", nullable: false),
                    LeadInventorDesignation = table.Column<string>(type: "text", nullable: false),
                    LeadInventorDepartment = table.Column<string>(type: "text", nullable: false),
                    InventionTitle = table.Column<string>(type: "text", nullable: false),
                    IPCategory = table.Column<string>(type: "text", nullable: false),
                    DevelopmentStatus = table.Column<string>(type: "text", nullable: false),
                    KeyScientificAspects = table.Column<string>(type: "text", nullable: false),
                    CommercialPartner = table.Column<string>(type: "text", nullable: true),
                    PatentFiledWith = table.Column<string>(type: "text", nullable: false),
                    PatentGrantingAuthority = table.Column<string>(type: "text", nullable: false),
                    FinancialSupport = table.Column<string>(type: "text", nullable: true),
                    DateOfFiling = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FilingEvidenceFilePath = table.Column<string>(type: "text", nullable: true),
                    GrantingEvidenceFilePath = table.Column<string>(type: "text", nullable: true),
                    SubmitAnotherResponse = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResearchProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ResearchRegion = table.Column<string>(type: "text", nullable: false),
                    LeadInventorName = table.Column<string>(type: "text", nullable: false),
                    LeadInventorDesignation = table.Column<string>(type: "text", nullable: false),
                    LeadInventorDepartment = table.Column<string>(type: "text", nullable: false),
                    InventionTitle = table.Column<string>(type: "text", nullable: false),
                    IPCategory = table.Column<string>(type: "text", nullable: false),
                    DevelopmentStatus = table.Column<string>(type: "text", nullable: false),
                    KeyScientificAspects = table.Column<string>(type: "text", nullable: false),
                    FieldOfUse = table.Column<string>(type: "text", nullable: false),
                    CollaboratingIndustrialPartner = table.Column<string>(type: "text", nullable: false),
                    FinancialSupport = table.Column<string>(type: "text", nullable: true),
                    Remarks = table.Column<string>(type: "text", nullable: true),
                    EvidenceFilePath = table.Column<string>(type: "text", nullable: true),
                    SubmitAnotherResponse = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResearchPublications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PublicationCategory = table.Column<string>(type: "text", nullable: false),
                    PublicationReference = table.Column<string>(type: "text", nullable: false),
                    PublicationLink = table.Column<string>(type: "text", nullable: false),
                    FirstPageFilePath = table.Column<string>(type: "text", nullable: true),
                    SubmitAnotherResponse = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchPublications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScienceArtsProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DisplayRegion = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LeadName = table.Column<string>(type: "text", nullable: false),
                    LeadDesignation = table.Column<string>(type: "text", nullable: false),
                    LeadDepartment = table.Column<string>(type: "text", nullable: false),
                    ProductCategory = table.Column<string>(type: "text", nullable: false),
                    Forum = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    FinancialSupport = table.Column<string>(type: "text", nullable: true),
                    FieldOfUse = table.Column<string>(type: "text", nullable: false),
                    EvidenceFilePath = table.Column<string>(type: "text", nullable: true),
                    SubmitAnotherResponse = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScienceArtsProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingWorkshopSeminars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EventType = table.Column<string>(type: "text", nullable: false),
                    EventLevel = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    EventDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NumberOfParticipants = table.Column<int>(type: "integer", nullable: false),
                    FocusAndOutcomes = table.Column<string>(type: "text", nullable: false),
                    EvidenceFilePath = table.Column<string>(type: "text", nullable: true),
                    SubmitAnotherResponse = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingWorkshopSeminars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VisitRepresentatives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VisitorName = table.Column<string>(type: "text", nullable: false),
                    VisitDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Agenda = table.Column<string>(type: "text", nullable: false),
                    EvidenceFilePath = table.Column<string>(type: "text", nullable: true),
                    SubmitAnotherResponse = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitRepresentatives", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgreementsSigned");

            migrationBuilder.DropTable(
                name: "ConferencesArranged");

            migrationBuilder.DropTable(
                name: "ExclusiveOrNonExclusives");

            migrationBuilder.DropTable(
                name: "ExhibitionEvents");

            migrationBuilder.DropTable(
                name: "HonorsAwards");

            migrationBuilder.DropTable(
                name: "IPDisclosures");

            migrationBuilder.DropTable(
                name: "IPLicensingNegotiations");

            migrationBuilder.DropTable(
                name: "OricForms");

            migrationBuilder.DropTable(
                name: "Patents");

            migrationBuilder.DropTable(
                name: "ResearchProducts");

            migrationBuilder.DropTable(
                name: "ResearchPublications");

            migrationBuilder.DropTable(
                name: "ScienceArtsProducts");

            migrationBuilder.DropTable(
                name: "TrainingWorkshopSeminars");

            migrationBuilder.DropTable(
                name: "VisitRepresentatives");
        }
    }
}
