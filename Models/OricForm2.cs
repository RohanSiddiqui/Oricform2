using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oricform2.Models
{
    public class OricForm2
    {
        [Key]
        public int ric_form_2_id { get; set; } // Renamed for consistency

        public string facultymembername { get; set; } // Removed incorrect [ForeignKey] attribute

        [Required]
        public string departmentname { get; set; }

        [Required, EmailAddress]
        public string facultyemail { get; set; }

        public int? ipdisclosurescount { get; set; }
        public int? patentsfiledcount { get; set; }
        public int? patentsgrantedcount { get; set; }
        public int? licensingnegotiationscount { get; set; }
        public int? licensessignedcount { get; set; }
        public int? productsdevelopedcount { get; set; }
        public int? productsdisplayedcount { get; set; }
        public int? industryvisitscount { get; set; }
        public int? collaborationagreementscount { get; set; }
        public int? honorsawardscount { get; set; }
        public int? orictrainingscount { get; set; }
        public int? externaltrainingscount { get; set; }
        public int? researchpublicationscount { get; set; }

        // Navigation Properties
        public ICollection<AgreementSigned> AgreementSigneds { get; set; }
        public ICollection<ConferenceArranged> ConferenceArrangeds { get; set; }
        public ICollection<ExclusiveOrNonExclusive> ExclusiveorNonExclusives { get; set; }
        public ICollection<ExhibitionEvent> ExhibitionEvents { get; set; }
        public ICollection<HonorOrAward> HonorOrAwards { get; set; }
        public ICollection<IPDisclosure> IPDisclosures { get; set; }
        public ICollection<IPLicensingNegotiation> IPLicensingNegotiations { get; set; }
        public ICollection<Patent> Patents { get; set; }
        public ICollection<ResearchProduct> ResearchProducts { get; set; }
        public ICollection<ResearchPublication> ResearchPublications { get; set; }
        public ICollection<ScienceArtsProduct> ScienceArtsProducts { get; set; }
        public ICollection<TrainingWorkshopSeminar> TrainingWorkshopSeminars { get; set; }
        public ICollection<VisitRepresentative> VisitRepresentatives { get; set; }

        // Constructor to initialize collections
        public OricForm2()
        {
            AgreementSigneds = new List<AgreementSigned>();
            ConferenceArrangeds = new List<ConferenceArranged>();
            ExclusiveorNonExclusives = new List<ExclusiveOrNonExclusive>();
            ExhibitionEvents = new List<ExhibitionEvent>();
            HonorOrAwards = new List<HonorOrAward>();
            IPDisclosures = new List<IPDisclosure>();
            IPLicensingNegotiations = new List<IPLicensingNegotiation>();
            Patents = new List<Patent>();
            ResearchProducts = new List<ResearchProduct>();
            ResearchPublications = new List<ResearchPublication>();
            ScienceArtsProducts = new List<ScienceArtsProduct>();
            TrainingWorkshopSeminars = new List<TrainingWorkshopSeminar>();
            VisitRepresentatives = new List<VisitRepresentative>();
        }
    }
}
