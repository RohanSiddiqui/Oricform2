using AutoMapper;
using Oricform2.DTOs;  // Your DTOs namespace
using Oricform2.Models; // Your Models namespace

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AgreementSignedDTO, AgreementSigned>()
            .ForMember(dest => dest.id, opt => opt.Ignore()) // Ignore primary key
            .ReverseMap();

        CreateMap<ConferenceArrangedDTO, ConferenceArranged>()
            .ForMember(dest => dest.id, opt => opt.Ignore())
            .ReverseMap();

        CreateMap<ExclusiveOrNonExclusiveDTO, ExclusiveOrNonExclusive>()
            .ForMember(dest => dest.id, opt => opt.Ignore())
            .ReverseMap();

        CreateMap<ExhibitionEventDTO, ExhibitionEvent>()
            .ForMember(dest => dest.id, opt => opt.Ignore())
            .ReverseMap();

        CreateMap<HonorOrAwardDTO, HonorOrAward>()
            .ForMember(dest => dest.id, opt => opt.Ignore())
            .ReverseMap();

        CreateMap<IPDisclosureDTO, IPDisclosure>()
            .ForMember(dest => dest.id, opt => opt.Ignore())
            .ReverseMap();

        CreateMap<IPLicensingNegotiationDTO, IPLicensingNegotiation>()
            .ForMember(dest => dest.id, opt => opt.Ignore())
            .ReverseMap();

        CreateMap<OricForm2DTO, OricForm2>()
            .ForMember(dest => dest.ric_form_2_id, opt => opt.Ignore()) // Main form primary key
            .ReverseMap();

        CreateMap<PatentDTO, Patent>()
            .ForMember(dest => dest.id, opt => opt.Ignore())
            .ReverseMap();

        CreateMap<ResearchProductDTO, ResearchProduct>()
            .ForMember(dest => dest.id, opt => opt.Ignore())
            .ReverseMap();

        CreateMap<ResearchPublicationDTO, ResearchPublication>()
            .ForMember(dest => dest.id, opt => opt.Ignore())
            .ReverseMap();

        CreateMap<ScienceArtsProductDTO, ScienceArtsProduct>()
            .ForMember(dest => dest.id, opt => opt.Ignore())
            .ReverseMap();

        CreateMap<TrainingWorkshopSeminarDTO, TrainingWorkshopSeminar>()
            .ForMember(dest => dest.id, opt => opt.Ignore())
            .ReverseMap();

        CreateMap<VisitRepresentativeDTO, VisitRepresentative>()
            .ForMember(dest => dest.id, opt => opt.Ignore())
            .ReverseMap();
    }
}
