using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Oricform2.Models;

namespace Oricform2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //login form
        public DbSet<Login> dataoric { get; set; }

        // Existing Models (Form 2)
        public DbSet<AgreementSigned> AgreementsSigned { get; set; }
        public DbSet<ConferenceArranged> ConferencesArranged { get; set; }
        public DbSet<ExclusiveOrNonExclusive> ExclusiveOrNonExclusives { get; set; }
        public DbSet<ExhibitionEvent> ExhibitionEvents { get; set; }
        public DbSet<HonorOrAward> HonorsAwards { get; set; }
        public DbSet<IPDisclosure> IPDisclosures { get; set; }
        public DbSet<IPLicensingNegotiation> IPLicensingNegotiations { get; set; }
        public DbSet<OricForm2> OricForms { get; set; }
        public DbSet<Patent> Patents { get; set; }
        public DbSet<ResearchProduct> ResearchProducts { get; set; }
        public DbSet<ResearchPublication> ResearchPublications { get; set; }
        public DbSet<ScienceArtsProduct> ScienceArtsProducts { get; set; }
        public DbSet<TrainingWorkshopSeminar> TrainingWorkshopSeminars { get; set; }
        public DbSet<VisitRepresentative> VisitRepresentatives { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuring Cascade Delete for All Related Entities
            modelBuilder.Entity<AgreementSigned>()
                .HasOne(a => a.OricForm2)
                .WithMany(o => o.AgreementSigneds)
                .HasForeignKey(a => a.ric_form_2_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ConferenceArranged>()
                .HasOne(c => c.OricForm2)
                .WithMany(o => o.ConferenceArrangeds)
                .HasForeignKey(c => c.ric_form_2_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ExclusiveOrNonExclusive>()
                .HasOne(e => e.OricForm2)
                .WithMany(o => o.ExclusiveorNonExclusives)
                .HasForeignKey(e => e.ric_form_2_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ExhibitionEvent>()

                .HasOne(e => e.OricForm2)
                .WithMany(o => o.ExhibitionEvents)
                .HasForeignKey(e => e.ric_form_2_id)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<HonorOrAward>()
                .HasOne(h => h.OricForm2)
                .WithMany(o => o.HonorOrAwards)
                .HasForeignKey(h => h.ric_form_2_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<IPDisclosure>()
                .HasOne(ip => ip.OricForm2)
                .WithMany(o => o.IPDisclosures)
                .HasForeignKey(ip => ip.ric_form_2_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<IPLicensingNegotiation>()
                .HasOne(ip => ip.OricForm2)
                .WithMany(o => o.IPLicensingNegotiations)
                .HasForeignKey(ip => ip.ric_form_2_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Patent>()
                .HasOne(p => p.OricForm2)
                .WithMany(o => o.Patents)
                .HasForeignKey(p => p.ric_form_2_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ResearchProduct>()
                .HasOne(rp => rp.OricForm2)
                .WithMany(o => o.ResearchProducts)
                .HasForeignKey(rp => rp.ric_form_2_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ResearchPublication>()
                .HasOne(rp => rp.OricForm2)
                .WithMany(o => o.ResearchPublications)
                .HasForeignKey(rp => rp.ric_form_2_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ScienceArtsProduct>()
                .HasOne(sp => sp.OricForm2)
                .WithMany(o => o.ScienceArtsProducts)
                .HasForeignKey(sp => sp.ric_form_2_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TrainingWorkshopSeminar>()
                .HasOne(tws => tws.OricForm2)
                .WithMany(o => o.TrainingWorkshopSeminars)
                .HasForeignKey(tws => tws.ric_form_2_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<VisitRepresentative>()
                .HasOne(v => v.OricForm2)
                .WithMany(o => o.VisitRepresentatives)
                .HasForeignKey(v => v.ric_form_2_id)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
