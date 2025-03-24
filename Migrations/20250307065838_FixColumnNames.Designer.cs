﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Oricform2.Data;

#nullable disable

namespace Oricform2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250307065838_FixColumnNames")]
    partial class FixColumnNames
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Oricform2.Models.AgreementSigned", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Evidence")
                        .HasColumnType("bytea");

                    b.Property<string>("Field")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FinancialSupport")
                        .HasColumnType("text");

                    b.Property<string>("HostInstitutionNameAndAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KeyInitiatives")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LinkageEstablishmentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NationalOrInternational")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OricForm2ric_form_2_Id")
                        .HasColumnType("integer");

                    b.Property<string>("ScopeOfCollaboration")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("SubmitAnotherResponse")
                        .HasColumnType("boolean");

                    b.Property<string>("TypeOfLinkage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OricForm2ric_form_2_Id");

                    b.ToTable("AgreementsSigned");
                });

            modelBuilder.Entity("Oricform2.Models.ConferenceArranged", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AudienceType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EventLevel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Evidence")
                        .HasColumnType("bytea");

                    b.Property<string>("FocusAndOutcomes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfParticipants")
                        .HasColumnType("integer");

                    b.Property<string>("Organizer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OricForm2ric_form_2_Id")
                        .HasColumnType("integer");

                    b.Property<bool>("SubmitAnotherResponse")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OricForm2ric_form_2_Id");

                    b.ToTable("ConferencesArranged");
                });

            modelBuilder.Entity("Oricform2.Models.ExclusiveOrNonExclusive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DateAndDurationOfAgreement")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DevelopmentStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Evidence")
                        .HasColumnType("bytea");

                    b.Property<string>("FieldOfUse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IPCategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("InventionTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KeyScientificAspects")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadInventorDepartment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadInventorDesignation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadInventorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LicenseDetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LicenseRegion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LicenseType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OricForm2ric_form_2_Id")
                        .HasColumnType("integer");

                    b.Property<bool>("SubmitAnotherResponse")
                        .HasColumnType("boolean");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OricForm2ric_form_2_Id");

                    b.ToTable("ExclusiveOrNonExclusives");
                });

            modelBuilder.Entity("Oricform2.Models.ExhibitionEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AudienceType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EventLevel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Evidence")
                        .HasColumnType("bytea");

                    b.Property<string>("FocusAndOutcomes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfParticipants")
                        .HasColumnType("integer");

                    b.Property<int>("OricForm2ric_form_2_Id")
                        .HasColumnType("integer");

                    b.Property<bool>("SubmitAnotherResponse")
                        .HasColumnType("boolean");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OricForm2ric_form_2_Id");

                    b.ToTable("ExhibitionEvents");
                });

            modelBuilder.Entity("Oricform2.Models.HonorOrAward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AwardReceived")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AwardWinnerDetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Evidence")
                        .HasColumnType("bytea");

                    b.Property<string>("ForumOrOrganization")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OricForm2ric_form_2_Id")
                        .HasColumnType("integer");

                    b.Property<decimal?>("PrizeMoney")
                        .HasColumnType("numeric");

                    b.Property<string>("Remarks")
                        .HasColumnType("text");

                    b.Property<bool>("SubmitAnotherResponse")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WorkDetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OricForm2ric_form_2_Id");

                    b.ToTable("HonorsAwards");
                });

            modelBuilder.Entity("Oricform2.Models.IPDisclosure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CommercialPartner")
                        .HasColumnType("text");

                    b.Property<string>("DevelopmentStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DisclosureMadeDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DisclosureMadeWith")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Evidence")
                        .HasColumnType("bytea");

                    b.Property<string>("FinancialSupport")
                        .HasColumnType("text");

                    b.Property<string>("IPCategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("InventionTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KeyScientificAspects")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadInventorDepartment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadInventorDesignation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadInventorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OricForm2ric_form_2_Id")
                        .HasColumnType("integer");

                    b.Property<string>("PreviousDisclosure")
                        .HasColumnType("text");

                    b.Property<bool>("SubmitAnotherResponse")
                        .HasColumnType("boolean");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OricForm2ric_form_2_Id");

                    b.ToTable("IPDisclosures");
                });

            modelBuilder.Entity("Oricform2.Models.IPLicensingNegotiation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DevelopmentStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DurationOfAgreement")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Evidence")
                        .HasColumnType("bytea");

                    b.Property<string>("FieldOfUse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IPCategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("InventionTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KeyScientificAspects")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadInventorDepartment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadInventorDesignation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadInventorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LicenseDetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LicensingType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OricForm2ric_form_2_Id")
                        .HasColumnType("integer");

                    b.Property<string>("StatusOfNegotiation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("SubmitAnotherResponse")
                        .HasColumnType("boolean");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OricForm2ric_form_2_Id");

                    b.ToTable("IPLicensingNegotiations");
                });

            modelBuilder.Entity("Oricform2.Models.OricForm2", b =>
                {
                    b.Property<int>("ric_form_2_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ric_form_2_Id"));

                    b.Property<int?>("CollaborationAgreementsCount")
                        .HasColumnType("integer");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ExternalTrainingsCount")
                        .HasColumnType("integer");

                    b.Property<string>("FacultyEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FacultyMemberName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("HonorsAwardsCount")
                        .HasColumnType("integer");

                    b.Property<int?>("IPDisclosuresCount")
                        .HasColumnType("integer");

                    b.Property<int?>("IndustryVisitsCount")
                        .HasColumnType("integer");

                    b.Property<int?>("LicensesSignedCount")
                        .HasColumnType("integer");

                    b.Property<int?>("LicensingNegotiationsCount")
                        .HasColumnType("integer");

                    b.Property<int?>("ORICTrainingsCount")
                        .HasColumnType("integer");

                    b.Property<int?>("PatentsFiledCount")
                        .HasColumnType("integer");

                    b.Property<int?>("PatentsGrantedCount")
                        .HasColumnType("integer");

                    b.Property<int?>("ProductsDevelopedCount")
                        .HasColumnType("integer");

                    b.Property<int?>("ProductsDisplayedCount")
                        .HasColumnType("integer");

                    b.Property<int?>("ResearchPublicationsCount")
                        .HasColumnType("integer");

                    b.HasKey("ric_form_2_Id");

                    b.ToTable("OricForms");
                });

            modelBuilder.Entity("Oricform2.Models.Patent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CommercialPartner")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfFiling")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DevelopmentStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FiledOrGranted")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("FilingEvidence")
                        .HasColumnType("bytea");

                    b.Property<string>("FinancialSupport")
                        .HasColumnType("text");

                    b.Property<byte[]>("GrantingEvidence")
                        .HasColumnType("bytea");

                    b.Property<string>("IPCategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("InventionTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KeyScientificAspects")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadInventorDepartment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadInventorDesignation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadInventorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NationalOrInternational")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OricForm2ric_form_2_Id")
                        .HasColumnType("integer");

                    b.Property<string>("PatentFiledWith")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PatentGrantingAuthority")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("SubmitAnotherResponse")
                        .HasColumnType("boolean");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OricForm2ric_form_2_Id");

                    b.ToTable("Patents");
                });

            modelBuilder.Entity("Oricform2.Models.ResearchProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CollaboratingIndustrialPartner")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DevelopmentStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Evidence")
                        .HasColumnType("bytea");

                    b.Property<string>("FieldOfUse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FinancialSupport")
                        .HasColumnType("text");

                    b.Property<string>("IPCategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("InventionTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KeyScientificAspects")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadInventorDepartment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadInventorDesignation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadInventorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OricForm2ric_form_2_Id")
                        .HasColumnType("integer");

                    b.Property<string>("Remarks")
                        .HasColumnType("text");

                    b.Property<string>("ResearchRegion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("SubmitAnotherResponse")
                        .HasColumnType("boolean");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OricForm2ric_form_2_Id");

                    b.ToTable("ResearchProducts");
                });

            modelBuilder.Entity("Oricform2.Models.ResearchPublication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Evidence")
                        .HasColumnType("bytea");

                    b.Property<int>("OricForm2ric_form_2_Id")
                        .HasColumnType("integer");

                    b.Property<string>("PublicationCategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PublicationLink")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PublicationReference")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("SubmitAnotherResponse")
                        .HasColumnType("boolean");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OricForm2ric_form_2_Id");

                    b.ToTable("ResearchPublications");
                });

            modelBuilder.Entity("Oricform2.Models.ScienceArtsProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DisplayRegion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Evidence")
                        .HasColumnType("bytea");

                    b.Property<string>("FieldOfUse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FinancialSupport")
                        .HasColumnType("text");

                    b.Property<string>("Forum")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadDepartment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadDesignation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeadName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OricForm2ric_form_2_Id")
                        .HasColumnType("integer");

                    b.Property<string>("ProductCategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("SubmitAnotherResponse")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OricForm2ric_form_2_Id");

                    b.ToTable("ScienceArtsProducts");
                });

            modelBuilder.Entity("Oricform2.Models.TrainingWorkshopSeminar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EventLevel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Evidence")
                        .HasColumnType("bytea");

                    b.Property<string>("FocusAndOutcomes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfParticipants")
                        .HasColumnType("integer");

                    b.Property<int>("OricForm2ric_form_2_Id")
                        .HasColumnType("integer");

                    b.Property<bool>("SubmitAnotherResponse")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OricForm2ric_form_2_Id");

                    b.ToTable("TrainingWorkshopSeminars");
                });

            modelBuilder.Entity("Oricform2.Models.VisitRepresentative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Agenda")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Evidence")
                        .HasColumnType("bytea");

                    b.Property<int>("OricForm2ric_form_2_Id")
                        .HasColumnType("integer");

                    b.Property<bool>("SubmitAnotherResponse")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("VisitorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OricForm2ric_form_2_Id");

                    b.ToTable("VisitRepresentatives");
                });

            modelBuilder.Entity("Oricform2.Models.AgreementSigned", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("AgreementSigneds")
                        .HasForeignKey("OricForm2ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.ConferenceArranged", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("ConferenceArrangeds")
                        .HasForeignKey("OricForm2ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.ExclusiveOrNonExclusive", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("ExclusiveorNonExclusives")
                        .HasForeignKey("OricForm2ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.ExhibitionEvent", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("ExhibitionEvents")
                        .HasForeignKey("OricForm2ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.HonorOrAward", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("HonorOrAwards")
                        .HasForeignKey("OricForm2ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.IPDisclosure", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("IPDisclosures")
                        .HasForeignKey("OricForm2ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.IPLicensingNegotiation", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("IPLicensingNegotiations")
                        .HasForeignKey("OricForm2ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.Patent", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("Patents")
                        .HasForeignKey("OricForm2ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.ResearchProduct", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("ResearchProducts")
                        .HasForeignKey("OricForm2ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.ResearchPublication", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("ResearchPublications")
                        .HasForeignKey("OricForm2ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.ScienceArtsProduct", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("ScienceArtsProducts")
                        .HasForeignKey("OricForm2ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.TrainingWorkshopSeminar", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("TrainingWorkshopSeminars")
                        .HasForeignKey("OricForm2ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.VisitRepresentative", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("VisitRepresentatives")
                        .HasForeignKey("OricForm2ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.OricForm2", b =>
                {
                    b.Navigation("AgreementSigneds");

                    b.Navigation("ConferenceArrangeds");

                    b.Navigation("ExclusiveorNonExclusives");

                    b.Navigation("ExhibitionEvents");

                    b.Navigation("HonorOrAwards");

                    b.Navigation("IPDisclosures");

                    b.Navigation("IPLicensingNegotiations");

                    b.Navigation("Patents");

                    b.Navigation("ResearchProducts");

                    b.Navigation("ResearchPublications");

                    b.Navigation("ScienceArtsProducts");

                    b.Navigation("TrainingWorkshopSeminars");

                    b.Navigation("VisitRepresentatives");
                });
#pragma warning restore 612, 618
        }
    }
}
