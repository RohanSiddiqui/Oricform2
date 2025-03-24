using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Oricform2.Migrations
{
    /// <inheritdoc />
    public partial class CheckMissingColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "ScienceArtsProducts",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ScienceArtsProducts",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "ProductCategory",
                table: "ScienceArtsProducts",
                newName: "productcategory");

            migrationBuilder.RenameColumn(
                name: "LeadName",
                table: "ScienceArtsProducts",
                newName: "leadname");

            migrationBuilder.RenameColumn(
                name: "LeadDesignation",
                table: "ScienceArtsProducts",
                newName: "leaddesignation");

            migrationBuilder.RenameColumn(
                name: "LeadDepartment",
                table: "ScienceArtsProducts",
                newName: "leaddepartment");

            migrationBuilder.RenameColumn(
                name: "Forum",
                table: "ScienceArtsProducts",
                newName: "forum");

            migrationBuilder.RenameColumn(
                name: "FinancialSupport",
                table: "ScienceArtsProducts",
                newName: "financialsupport");

            migrationBuilder.RenameColumn(
                name: "FieldOfUse",
                table: "ScienceArtsProducts",
                newName: "fieldofuse");

            migrationBuilder.RenameColumn(
                name: "Evidence",
                table: "ScienceArtsProducts",
                newName: "evidence");

            migrationBuilder.RenameColumn(
                name: "DisplayRegion",
                table: "ScienceArtsProducts",
                newName: "displayregion");

            migrationBuilder.RenameColumn(
                name: "PublicationReference",
                table: "ResearchPublications",
                newName: "publicationreference");

            migrationBuilder.RenameColumn(
                name: "PublicationLink",
                table: "ResearchPublications",
                newName: "publicationlink");

            migrationBuilder.RenameColumn(
                name: "PublicationCategory",
                table: "ResearchPublications",
                newName: "publicationcategory");

            migrationBuilder.RenameColumn(
                name: "Evidence",
                table: "ResearchPublications",
                newName: "evidence");

            migrationBuilder.RenameColumn(
                name: "ResearchRegion",
                table: "ResearchProducts",
                newName: "researchregion");

            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "ResearchProducts",
                newName: "remarks");

            migrationBuilder.RenameColumn(
                name: "LeadInventorName",
                table: "ResearchProducts",
                newName: "leadinventorname");

            migrationBuilder.RenameColumn(
                name: "LeadInventorDesignation",
                table: "ResearchProducts",
                newName: "leadinventordesignation");

            migrationBuilder.RenameColumn(
                name: "LeadInventorDepartment",
                table: "ResearchProducts",
                newName: "leadinventordepartment");

            migrationBuilder.RenameColumn(
                name: "KeyScientificAspects",
                table: "ResearchProducts",
                newName: "keyscientificaspects");

            migrationBuilder.RenameColumn(
                name: "InventionTitle",
                table: "ResearchProducts",
                newName: "inventiontitle");

            migrationBuilder.RenameColumn(
                name: "IPCategory",
                table: "ResearchProducts",
                newName: "ipcategory");

            migrationBuilder.RenameColumn(
                name: "FinancialSupport",
                table: "ResearchProducts",
                newName: "financialsupport");

            migrationBuilder.RenameColumn(
                name: "FieldOfUse",
                table: "ResearchProducts",
                newName: "fieldofuse");

            migrationBuilder.RenameColumn(
                name: "Evidence",
                table: "ResearchProducts",
                newName: "evidence");

            migrationBuilder.RenameColumn(
                name: "DevelopmentStatus",
                table: "ResearchProducts",
                newName: "developmentstatus");

            migrationBuilder.RenameColumn(
                name: "CollaboratingIndustrialPartner",
                table: "ResearchProducts",
                newName: "collaboratingindustrialpartner");

            migrationBuilder.RenameColumn(
                name: "PatentGrantingAuthority",
                table: "Patents",
                newName: "patentgrantingauthority");

            migrationBuilder.RenameColumn(
                name: "PatentFiledWith",
                table: "Patents",
                newName: "patentfiledwith");

            migrationBuilder.RenameColumn(
                name: "NationalOrInternational",
                table: "Patents",
                newName: "nationalorinternational");

            migrationBuilder.RenameColumn(
                name: "LeadInventorName",
                table: "Patents",
                newName: "leadinventorname");

            migrationBuilder.RenameColumn(
                name: "LeadInventorDesignation",
                table: "Patents",
                newName: "leadinventordesignation");

            migrationBuilder.RenameColumn(
                name: "LeadInventorDepartment",
                table: "Patents",
                newName: "leadinventordepartment");

            migrationBuilder.RenameColumn(
                name: "KeyScientificAspects",
                table: "Patents",
                newName: "keyscientificaspects");

            migrationBuilder.RenameColumn(
                name: "InventionTitle",
                table: "Patents",
                newName: "inventiontitle");

            migrationBuilder.RenameColumn(
                name: "IPCategory",
                table: "Patents",
                newName: "ipcategory");

            migrationBuilder.RenameColumn(
                name: "GrantingEvidence",
                table: "Patents",
                newName: "grantingevidence");

            migrationBuilder.RenameColumn(
                name: "FinancialSupport",
                table: "Patents",
                newName: "financialsupport");

            migrationBuilder.RenameColumn(
                name: "FilingEvidence",
                table: "Patents",
                newName: "filingevidence");

            migrationBuilder.RenameColumn(
                name: "FiledOrGranted",
                table: "Patents",
                newName: "filedorgranted");

            migrationBuilder.RenameColumn(
                name: "DevelopmentStatus",
                table: "Patents",
                newName: "developmentstatus");

            migrationBuilder.RenameColumn(
                name: "DateOfFiling",
                table: "Patents",
                newName: "dateoffiling");

            migrationBuilder.RenameColumn(
                name: "CommercialPartner",
                table: "Patents",
                newName: "commercialpartner");

            migrationBuilder.RenameColumn(
                name: "ResearchPublicationsCount",
                table: "OricForms",
                newName: "researchpublicationscount");

            migrationBuilder.RenameColumn(
                name: "ProductsDisplayedCount",
                table: "OricForms",
                newName: "productsdisplayedcount");

            migrationBuilder.RenameColumn(
                name: "ProductsDevelopedCount",
                table: "OricForms",
                newName: "productsdevelopedcount");

            migrationBuilder.RenameColumn(
                name: "PatentsGrantedCount",
                table: "OricForms",
                newName: "patentsgrantedcount");

            migrationBuilder.RenameColumn(
                name: "PatentsFiledCount",
                table: "OricForms",
                newName: "patentsfiledcount");

            migrationBuilder.RenameColumn(
                name: "ORICTrainingsCount",
                table: "OricForms",
                newName: "orictrainingscount");

            migrationBuilder.RenameColumn(
                name: "LicensingNegotiationsCount",
                table: "OricForms",
                newName: "licensingnegotiationscount");

            migrationBuilder.RenameColumn(
                name: "LicensesSignedCount",
                table: "OricForms",
                newName: "licensessignedcount");

            migrationBuilder.RenameColumn(
                name: "IndustryVisitsCount",
                table: "OricForms",
                newName: "industryvisitscount");

            migrationBuilder.RenameColumn(
                name: "IPDisclosuresCount",
                table: "OricForms",
                newName: "ipdisclosurescount");

            migrationBuilder.RenameColumn(
                name: "HonorsAwardsCount",
                table: "OricForms",
                newName: "honorsawardscount");

            migrationBuilder.RenameColumn(
                name: "FacultyMemberName",
                table: "OricForms",
                newName: "facultymembername");

            migrationBuilder.RenameColumn(
                name: "FacultyEmail",
                table: "OricForms",
                newName: "facultyemail");

            migrationBuilder.RenameColumn(
                name: "ExternalTrainingsCount",
                table: "OricForms",
                newName: "externaltrainingscount");

            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                table: "OricForms",
                newName: "departmentname");

            migrationBuilder.RenameColumn(
                name: "CollaborationAgreementsCount",
                table: "OricForms",
                newName: "collaborationagreementscount");

            migrationBuilder.RenameColumn(
                name: "Evidence",
                table: "IPLicensingNegotiations",
                newName: "evidence");

            migrationBuilder.RenameColumn(
                name: "StatusOfNegotiation",
                table: "IPLicensingNegotiations",
                newName: "status_of_negotiation");

            migrationBuilder.RenameColumn(
                name: "LicensingType",
                table: "IPLicensingNegotiations",
                newName: "licensing_type");

            migrationBuilder.RenameColumn(
                name: "LicenseDetails",
                table: "IPLicensingNegotiations",
                newName: "license_details");

            migrationBuilder.RenameColumn(
                name: "LeadInventorName",
                table: "IPLicensingNegotiations",
                newName: "lead_inventor_name");

            migrationBuilder.RenameColumn(
                name: "LeadInventorDesignation",
                table: "IPLicensingNegotiations",
                newName: "lead_inventor_designation");

            migrationBuilder.RenameColumn(
                name: "LeadInventorDepartment",
                table: "IPLicensingNegotiations",
                newName: "lead_inventor_department");

            migrationBuilder.RenameColumn(
                name: "KeyScientificAspects",
                table: "IPLicensingNegotiations",
                newName: "key_scientific_aspects");

            migrationBuilder.RenameColumn(
                name: "InventionTitle",
                table: "IPLicensingNegotiations",
                newName: "ip_category");

            migrationBuilder.RenameColumn(
                name: "IPCategory",
                table: "IPLicensingNegotiations",
                newName: "invention_title");

            migrationBuilder.RenameColumn(
                name: "FieldOfUse",
                table: "IPLicensingNegotiations",
                newName: "field_of_use");

            migrationBuilder.RenameColumn(
                name: "DurationOfAgreement",
                table: "IPLicensingNegotiations",
                newName: "duration_of_agreement");

            migrationBuilder.RenameColumn(
                name: "DevelopmentStatus",
                table: "IPLicensingNegotiations",
                newName: "development_status");

            migrationBuilder.RenameColumn(
                name: "PreviousDisclosure",
                table: "IPDisclosures",
                newName: "previousdisclosure");

            migrationBuilder.RenameColumn(
                name: "LeadInventorName",
                table: "IPDisclosures",
                newName: "leadinventorname");

            migrationBuilder.RenameColumn(
                name: "LeadInventorDesignation",
                table: "IPDisclosures",
                newName: "leadinventordesignation");

            migrationBuilder.RenameColumn(
                name: "LeadInventorDepartment",
                table: "IPDisclosures",
                newName: "leadinventordepartment");

            migrationBuilder.RenameColumn(
                name: "KeyScientificAspects",
                table: "IPDisclosures",
                newName: "keyscientificaspects");

            migrationBuilder.RenameColumn(
                name: "InventionTitle",
                table: "IPDisclosures",
                newName: "inventiontitle");

            migrationBuilder.RenameColumn(
                name: "IPCategory",
                table: "IPDisclosures",
                newName: "ipcategory");

            migrationBuilder.RenameColumn(
                name: "FinancialSupport",
                table: "IPDisclosures",
                newName: "financialsupport");

            migrationBuilder.RenameColumn(
                name: "Evidence",
                table: "IPDisclosures",
                newName: "evidence");

            migrationBuilder.RenameColumn(
                name: "DisclosureMadeWith",
                table: "IPDisclosures",
                newName: "disclosuremadewith");

            migrationBuilder.RenameColumn(
                name: "DisclosureMadeDate",
                table: "IPDisclosures",
                newName: "disclosuremadedate");

            migrationBuilder.RenameColumn(
                name: "DevelopmentStatus",
                table: "IPDisclosures",
                newName: "developmentstatus");

            migrationBuilder.RenameColumn(
                name: "CommercialPartner",
                table: "IPDisclosures",
                newName: "commercialpartner");

            migrationBuilder.RenameColumn(
                name: "WorkDetails",
                table: "HonorsAwards",
                newName: "workdetails");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "HonorsAwards",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "HonorsAwards",
                newName: "remarks");

            migrationBuilder.RenameColumn(
                name: "PrizeMoney",
                table: "HonorsAwards",
                newName: "prizemoney");

            migrationBuilder.RenameColumn(
                name: "ForumOrOrganization",
                table: "HonorsAwards",
                newName: "forumororganization");

            migrationBuilder.RenameColumn(
                name: "Evidence",
                table: "HonorsAwards",
                newName: "evidence");

            migrationBuilder.RenameColumn(
                name: "AwardWinnerDetails",
                table: "HonorsAwards",
                newName: "awardwinnerdetails");

            migrationBuilder.RenameColumn(
                name: "AwardReceived",
                table: "HonorsAwards",
                newName: "awardreceived");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "ScienceArtsProducts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "ScienceArtsProducts",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "productcategory",
                table: "ScienceArtsProducts",
                newName: "ProductCategory");

            migrationBuilder.RenameColumn(
                name: "leadname",
                table: "ScienceArtsProducts",
                newName: "LeadName");

            migrationBuilder.RenameColumn(
                name: "leaddesignation",
                table: "ScienceArtsProducts",
                newName: "LeadDesignation");

            migrationBuilder.RenameColumn(
                name: "leaddepartment",
                table: "ScienceArtsProducts",
                newName: "LeadDepartment");

            migrationBuilder.RenameColumn(
                name: "forum",
                table: "ScienceArtsProducts",
                newName: "Forum");

            migrationBuilder.RenameColumn(
                name: "financialsupport",
                table: "ScienceArtsProducts",
                newName: "FinancialSupport");

            migrationBuilder.RenameColumn(
                name: "fieldofuse",
                table: "ScienceArtsProducts",
                newName: "FieldOfUse");

            migrationBuilder.RenameColumn(
                name: "evidence",
                table: "ScienceArtsProducts",
                newName: "Evidence");

            migrationBuilder.RenameColumn(
                name: "displayregion",
                table: "ScienceArtsProducts",
                newName: "DisplayRegion");

            migrationBuilder.RenameColumn(
                name: "publicationreference",
                table: "ResearchPublications",
                newName: "PublicationReference");

            migrationBuilder.RenameColumn(
                name: "publicationlink",
                table: "ResearchPublications",
                newName: "PublicationLink");

            migrationBuilder.RenameColumn(
                name: "publicationcategory",
                table: "ResearchPublications",
                newName: "PublicationCategory");

            migrationBuilder.RenameColumn(
                name: "evidence",
                table: "ResearchPublications",
                newName: "Evidence");

            migrationBuilder.RenameColumn(
                name: "researchregion",
                table: "ResearchProducts",
                newName: "ResearchRegion");

            migrationBuilder.RenameColumn(
                name: "remarks",
                table: "ResearchProducts",
                newName: "Remarks");

            migrationBuilder.RenameColumn(
                name: "leadinventorname",
                table: "ResearchProducts",
                newName: "LeadInventorName");

            migrationBuilder.RenameColumn(
                name: "leadinventordesignation",
                table: "ResearchProducts",
                newName: "LeadInventorDesignation");

            migrationBuilder.RenameColumn(
                name: "leadinventordepartment",
                table: "ResearchProducts",
                newName: "LeadInventorDepartment");

            migrationBuilder.RenameColumn(
                name: "keyscientificaspects",
                table: "ResearchProducts",
                newName: "KeyScientificAspects");

            migrationBuilder.RenameColumn(
                name: "ipcategory",
                table: "ResearchProducts",
                newName: "IPCategory");

            migrationBuilder.RenameColumn(
                name: "inventiontitle",
                table: "ResearchProducts",
                newName: "InventionTitle");

            migrationBuilder.RenameColumn(
                name: "financialsupport",
                table: "ResearchProducts",
                newName: "FinancialSupport");

            migrationBuilder.RenameColumn(
                name: "fieldofuse",
                table: "ResearchProducts",
                newName: "FieldOfUse");

            migrationBuilder.RenameColumn(
                name: "evidence",
                table: "ResearchProducts",
                newName: "Evidence");

            migrationBuilder.RenameColumn(
                name: "developmentstatus",
                table: "ResearchProducts",
                newName: "DevelopmentStatus");

            migrationBuilder.RenameColumn(
                name: "collaboratingindustrialpartner",
                table: "ResearchProducts",
                newName: "CollaboratingIndustrialPartner");

            migrationBuilder.RenameColumn(
                name: "patentgrantingauthority",
                table: "Patents",
                newName: "PatentGrantingAuthority");

            migrationBuilder.RenameColumn(
                name: "patentfiledwith",
                table: "Patents",
                newName: "PatentFiledWith");

            migrationBuilder.RenameColumn(
                name: "nationalorinternational",
                table: "Patents",
                newName: "NationalOrInternational");

            migrationBuilder.RenameColumn(
                name: "leadinventorname",
                table: "Patents",
                newName: "LeadInventorName");

            migrationBuilder.RenameColumn(
                name: "leadinventordesignation",
                table: "Patents",
                newName: "LeadInventorDesignation");

            migrationBuilder.RenameColumn(
                name: "leadinventordepartment",
                table: "Patents",
                newName: "LeadInventorDepartment");

            migrationBuilder.RenameColumn(
                name: "keyscientificaspects",
                table: "Patents",
                newName: "KeyScientificAspects");

            migrationBuilder.RenameColumn(
                name: "ipcategory",
                table: "Patents",
                newName: "IPCategory");

            migrationBuilder.RenameColumn(
                name: "inventiontitle",
                table: "Patents",
                newName: "InventionTitle");

            migrationBuilder.RenameColumn(
                name: "grantingevidence",
                table: "Patents",
                newName: "GrantingEvidence");

            migrationBuilder.RenameColumn(
                name: "financialsupport",
                table: "Patents",
                newName: "FinancialSupport");

            migrationBuilder.RenameColumn(
                name: "filingevidence",
                table: "Patents",
                newName: "FilingEvidence");

            migrationBuilder.RenameColumn(
                name: "filedorgranted",
                table: "Patents",
                newName: "FiledOrGranted");

            migrationBuilder.RenameColumn(
                name: "developmentstatus",
                table: "Patents",
                newName: "DevelopmentStatus");

            migrationBuilder.RenameColumn(
                name: "dateoffiling",
                table: "Patents",
                newName: "DateOfFiling");

            migrationBuilder.RenameColumn(
                name: "commercialpartner",
                table: "Patents",
                newName: "CommercialPartner");

            migrationBuilder.RenameColumn(
                name: "researchpublicationscount",
                table: "OricForms",
                newName: "ResearchPublicationsCount");

            migrationBuilder.RenameColumn(
                name: "productsdisplayedcount",
                table: "OricForms",
                newName: "ProductsDisplayedCount");

            migrationBuilder.RenameColumn(
                name: "productsdevelopedcount",
                table: "OricForms",
                newName: "ProductsDevelopedCount");

            migrationBuilder.RenameColumn(
                name: "patentsgrantedcount",
                table: "OricForms",
                newName: "PatentsGrantedCount");

            migrationBuilder.RenameColumn(
                name: "patentsfiledcount",
                table: "OricForms",
                newName: "PatentsFiledCount");

            migrationBuilder.RenameColumn(
                name: "orictrainingscount",
                table: "OricForms",
                newName: "ORICTrainingsCount");

            migrationBuilder.RenameColumn(
                name: "licensingnegotiationscount",
                table: "OricForms",
                newName: "LicensingNegotiationsCount");

            migrationBuilder.RenameColumn(
                name: "licensessignedcount",
                table: "OricForms",
                newName: "LicensesSignedCount");

            migrationBuilder.RenameColumn(
                name: "ipdisclosurescount",
                table: "OricForms",
                newName: "IPDisclosuresCount");

            migrationBuilder.RenameColumn(
                name: "industryvisitscount",
                table: "OricForms",
                newName: "IndustryVisitsCount");

            migrationBuilder.RenameColumn(
                name: "honorsawardscount",
                table: "OricForms",
                newName: "HonorsAwardsCount");

            migrationBuilder.RenameColumn(
                name: "facultymembername",
                table: "OricForms",
                newName: "FacultyMemberName");

            migrationBuilder.RenameColumn(
                name: "facultyemail",
                table: "OricForms",
                newName: "FacultyEmail");

            migrationBuilder.RenameColumn(
                name: "externaltrainingscount",
                table: "OricForms",
                newName: "ExternalTrainingsCount");

            migrationBuilder.RenameColumn(
                name: "departmentname",
                table: "OricForms",
                newName: "DepartmentName");

            migrationBuilder.RenameColumn(
                name: "collaborationagreementscount",
                table: "OricForms",
                newName: "CollaborationAgreementsCount");

            migrationBuilder.RenameColumn(
                name: "evidence",
                table: "IPLicensingNegotiations",
                newName: "Evidence");

            migrationBuilder.RenameColumn(
                name: "status_of_negotiation",
                table: "IPLicensingNegotiations",
                newName: "StatusOfNegotiation");

            migrationBuilder.RenameColumn(
                name: "licensing_type",
                table: "IPLicensingNegotiations",
                newName: "LicensingType");

            migrationBuilder.RenameColumn(
                name: "license_details",
                table: "IPLicensingNegotiations",
                newName: "LicenseDetails");

            migrationBuilder.RenameColumn(
                name: "lead_inventor_name",
                table: "IPLicensingNegotiations",
                newName: "LeadInventorName");

            migrationBuilder.RenameColumn(
                name: "lead_inventor_designation",
                table: "IPLicensingNegotiations",
                newName: "LeadInventorDesignation");

            migrationBuilder.RenameColumn(
                name: "lead_inventor_department",
                table: "IPLicensingNegotiations",
                newName: "LeadInventorDepartment");

            migrationBuilder.RenameColumn(
                name: "key_scientific_aspects",
                table: "IPLicensingNegotiations",
                newName: "KeyScientificAspects");

            migrationBuilder.RenameColumn(
                name: "ip_category",
                table: "IPLicensingNegotiations",
                newName: "InventionTitle");

            migrationBuilder.RenameColumn(
                name: "invention_title",
                table: "IPLicensingNegotiations",
                newName: "IPCategory");

            migrationBuilder.RenameColumn(
                name: "field_of_use",
                table: "IPLicensingNegotiations",
                newName: "FieldOfUse");

            migrationBuilder.RenameColumn(
                name: "duration_of_agreement",
                table: "IPLicensingNegotiations",
                newName: "DurationOfAgreement");

            migrationBuilder.RenameColumn(
                name: "development_status",
                table: "IPLicensingNegotiations",
                newName: "DevelopmentStatus");

            migrationBuilder.RenameColumn(
                name: "previousdisclosure",
                table: "IPDisclosures",
                newName: "PreviousDisclosure");

            migrationBuilder.RenameColumn(
                name: "leadinventorname",
                table: "IPDisclosures",
                newName: "LeadInventorName");

            migrationBuilder.RenameColumn(
                name: "leadinventordesignation",
                table: "IPDisclosures",
                newName: "LeadInventorDesignation");

            migrationBuilder.RenameColumn(
                name: "leadinventordepartment",
                table: "IPDisclosures",
                newName: "LeadInventorDepartment");

            migrationBuilder.RenameColumn(
                name: "keyscientificaspects",
                table: "IPDisclosures",
                newName: "KeyScientificAspects");

            migrationBuilder.RenameColumn(
                name: "ipcategory",
                table: "IPDisclosures",
                newName: "IPCategory");

            migrationBuilder.RenameColumn(
                name: "inventiontitle",
                table: "IPDisclosures",
                newName: "InventionTitle");

            migrationBuilder.RenameColumn(
                name: "financialsupport",
                table: "IPDisclosures",
                newName: "FinancialSupport");

            migrationBuilder.RenameColumn(
                name: "evidence",
                table: "IPDisclosures",
                newName: "Evidence");

            migrationBuilder.RenameColumn(
                name: "disclosuremadewith",
                table: "IPDisclosures",
                newName: "DisclosureMadeWith");

            migrationBuilder.RenameColumn(
                name: "disclosuremadedate",
                table: "IPDisclosures",
                newName: "DisclosureMadeDate");

            migrationBuilder.RenameColumn(
                name: "developmentstatus",
                table: "IPDisclosures",
                newName: "DevelopmentStatus");

            migrationBuilder.RenameColumn(
                name: "commercialpartner",
                table: "IPDisclosures",
                newName: "CommercialPartner");

            migrationBuilder.RenameColumn(
                name: "workdetails",
                table: "HonorsAwards",
                newName: "WorkDetails");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "HonorsAwards",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "remarks",
                table: "HonorsAwards",
                newName: "Remarks");

            migrationBuilder.RenameColumn(
                name: "prizemoney",
                table: "HonorsAwards",
                newName: "PrizeMoney");

            migrationBuilder.RenameColumn(
                name: "forumororganization",
                table: "HonorsAwards",
                newName: "ForumOrOrganization");

            migrationBuilder.RenameColumn(
                name: "evidence",
                table: "HonorsAwards",
                newName: "Evidence");

            migrationBuilder.RenameColumn(
                name: "awardwinnerdetails",
                table: "HonorsAwards",
                newName: "AwardWinnerDetails");

            migrationBuilder.RenameColumn(
                name: "awardreceived",
                table: "HonorsAwards",
                newName: "AwardReceived");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    dataoric_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    department_id = table.Column<int>(type: "integer", nullable: false),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    role = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.dataoric_id);
                });
        }
    }
}
