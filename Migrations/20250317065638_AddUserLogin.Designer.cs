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
    [Migration("20250317065638_AddUserLogin")]
    partial class AddUserLogin
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
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("duration")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("evidence")
                        .HasColumnType("bytea");

                    b.Property<string>("field")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("financialsupport")
                        .HasColumnType("text");

                    b.Property<string>("hostinstitutionnameandaddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("keyinitiatives")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("linkageestablishmentdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nationalorinternational")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_id")
                        .HasColumnType("integer");

                    b.Property<string>("scopeofcollaboration")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("typeoflinkage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("ric_form_2_id");

                    b.ToTable("AgreementsSigned");
                });

            modelBuilder.Entity("Oricform2.Models.ConferenceArranged", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("audiencetype")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("eventdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("eventlevel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("eventtype")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("evidence")
                        .HasColumnType("bytea");

                    b.Property<string>("focusandoutcomes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("numberofparticipants")
                        .HasColumnType("integer");

                    b.Property<string>("organizer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_id")
                        .HasColumnType("integer");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("ric_form_2_id");

                    b.ToTable("ConferencesArranged");
                });

            modelBuilder.Entity("Oricform2.Models.ExclusiveOrNonExclusive", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("dateanddurationofagreement")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("developmentstatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("evidence")
                        .HasColumnType("bytea");

                    b.Property<string>("fieldofuse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("inventiontitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ipcategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("keyscientificaspects")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("leadinventordepartment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("leadinventordesignation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("leadinventorname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("licensedetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("licenseregion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("licensetype")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_id")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("ric_form_2_id");

                    b.ToTable("ExclusiveOrNonExclusives");
                });

            modelBuilder.Entity("Oricform2.Models.ExhibitionEvent", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("audiencetype")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("eventdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("eventlevel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("eventtype")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("evidence")
                        .HasColumnType("bytea");

                    b.Property<string>("focusandoutcomes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("numberofparticipants")
                        .HasColumnType("integer");

                    b.Property<int>("ric_form_2_id")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("ric_form_2_id");

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

                    b.Property<decimal?>("PrizeMoney")
                        .HasColumnType("numeric");

                    b.Property<string>("Remarks")
                        .HasColumnType("text");

                    b.Property<int>("RicForm2Id")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WorkDetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RicForm2Id");

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

                    b.Property<string>("PreviousDisclosure")
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ric_form_2_Id");

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

                    b.Property<string>("StatusOfNegotiation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ric_form_2_Id");

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

                    b.Property<string>("PatentFiledWith")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PatentGrantingAuthority")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ric_form_2_Id");

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

                    b.Property<string>("Remarks")
                        .HasColumnType("text");

                    b.Property<string>("ResearchRegion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ric_form_2_Id");

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

                    b.Property<string>("PublicationCategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PublicationLink")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PublicationReference")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ric_form_2_Id");

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

                    b.Property<string>("ProductCategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ric_form_2_Id");

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

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ric_form_2_Id");

                    b.ToTable("TrainingWorkshopSeminars");
                });

            modelBuilder.Entity("Oricform2.Models.User", b =>
                {
                    b.Property<int>("dataoric_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("dataoric_id"));

                    b.Property<int>("department_id")
                        .HasColumnType("integer");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("dataoric_id");

                    b.ToTable("Users");
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

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("VisitorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ric_form_2_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ric_form_2_Id");

                    b.ToTable("VisitRepresentatives");
                });

            modelBuilder.Entity("Oricform2.Models.AgreementSigned", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("AgreementSigneds")
                        .HasForeignKey("ric_form_2_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.ConferenceArranged", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("ConferenceArrangeds")
                        .HasForeignKey("ric_form_2_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.ExclusiveOrNonExclusive", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("ExclusiveorNonExclusives")
                        .HasForeignKey("ric_form_2_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.ExhibitionEvent", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("ExhibitionEvents")
                        .HasForeignKey("ric_form_2_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.HonorOrAward", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("HonorOrAwards")
                        .HasForeignKey("RicForm2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.IPDisclosure", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("IPDisclosures")
                        .HasForeignKey("ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.IPLicensingNegotiation", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("IPLicensingNegotiations")
                        .HasForeignKey("ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.Patent", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("Patents")
                        .HasForeignKey("ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.ResearchProduct", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("ResearchProducts")
                        .HasForeignKey("ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.ResearchPublication", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("ResearchPublications")
                        .HasForeignKey("ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.ScienceArtsProduct", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("ScienceArtsProducts")
                        .HasForeignKey("ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.TrainingWorkshopSeminar", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("TrainingWorkshopSeminars")
                        .HasForeignKey("ric_form_2_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OricForm2");
                });

            modelBuilder.Entity("Oricform2.Models.VisitRepresentative", b =>
                {
                    b.HasOne("Oricform2.Models.OricForm2", "OricForm2")
                        .WithMany("VisitRepresentatives")
                        .HasForeignKey("ric_form_2_Id")
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
