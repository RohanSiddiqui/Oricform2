using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Oricform2.Data;
using Oricform2.DTOs;
using Oricform2.Models;
using System;
using System.Threading.Tasks;

namespace OricDataPortal.Controllers
{
    [ApiController]
    [Route("api/ric-forms")]
    public class RicFormsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public RicFormsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // Main oricform2
        // CREATE (POST) API for OricForm2
        [HttpPost("oric-form-2")]
        public async Task<IActionResult> AddOricForm2(OricForm2DTO dto)
        {
            var oricForm2 = _mapper.Map<OricForm2>(dto);

            _context.OricForms.Add(oricForm2);
            await _context.SaveChangesAsync();

            return Ok("Oric Form 2 submitted successfully.");
        }

        // UPDATE (PUT) API for OricForm2
        [HttpPut("oric-form-2/{id}")]
        public async Task<IActionResult> UpdateOricForm2(int id, OricForm2DTO dto)
        {
            var oricForm2 = await _context.OricForms.FindAsync(id);
            if (oricForm2 == null)
            {
                return NotFound("Record not found.");
            }

            _mapper.Map(dto, oricForm2);
            await _context.SaveChangesAsync();

            return Ok("Oric Form 2 updated successfully.");
        }

        // DELETE API for OricForm2
        [HttpDelete("oric-form-2/{id}")]
        public async Task<IActionResult> DeleteOricForm2(int id)
        {
            var oricForm2 = await _context.OricForms.FindAsync(id);
            if (oricForm2 == null)
            {
                return NotFound("Record not found.");
            }

            _context.OricForms.Remove(oricForm2);
            await _context.SaveChangesAsync();

            return Ok("OricForm2 and all related subforms deleted successfully."); }

            // AgreementSigned form
            // CREATE (POST) API for AgreementSigned
            [HttpPost("agreement")]
            public async Task<IActionResult> AddAgreement(AgreementSignedDTO dto)
            {
                // Check if the provided ric_form_2_id exists in OricForms
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching OricForm2 record found.");
                }

                var agreement = _mapper.Map<AgreementSigned>(dto);
                _context.AgreementsSigned.Add(agreement);
                await _context.SaveChangesAsync();

                return Ok("Agreement signed successfully.");
            }

            // UPDATE (PUT) API for AgreementSigned
            [HttpPut("agreement{id}")]
            public async Task<IActionResult> UpdateAgreement(int id, AgreementSignedDTO dto)
            {
                var agreement = await _context.AgreementsSigned.FindAsync(id);
                if (agreement == null)
                {
                    return NotFound("Record not found.");
                }

                // Check if the provided ric_form_2_id exists
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching OricForm2 record found.");
                }

                _mapper.Map(dto, agreement);
                await _context.SaveChangesAsync();

                return Ok("Agreement updated successfully.");
            }

        // DELETE API for AgreementSigned
        [HttpDelete("agreement{id}")]
        public async Task<IActionResult> DeleteAgreement(int id)
        {
            var agreement = await _context.AgreementsSigned.FindAsync(id);
            if (agreement == null)
            {
                return NotFound("Record not found.");
            }

            _context.AgreementsSigned.Remove(agreement);
            await _context.SaveChangesAsync();

            return Ok("Agreement deleted successfully.");
        }



            //Conference Arranged form
            [HttpPost("conference-arranged")]
                public async Task<IActionResult> AddConference(ConferenceArrangedDTO dto)
            {
                // Check if the provided ric_form_2_id exists in OricForms
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                var conference = _mapper.Map<ConferenceArranged>(dto);
                _context.ConferencesArranged.Add(conference);
                await _context.SaveChangesAsync();

                return Ok("Conference arranged record added successfully.");
             }

             [HttpPut("conference-arranged/{id}")]
                public async Task<IActionResult> UpdateConference(int id, ConferenceArrangedDTO dto)
            {
                var conference = await _context.ConferencesArranged.FindAsync(id);
                if (conference == null)
                {
                    return NotFound("Record not found.");
                }

                // Check if the provided ric_form_2_id exists in OricForms
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                _mapper.Map(dto, conference);
                await _context.SaveChangesAsync();

                return Ok("Conference arranged record updated successfully.");
            }

                [HttpDelete("conference-arranged/{id}")]
                public async Task<IActionResult> DeleteConference(int id)
            {
                var conference = await _context.ConferencesArranged.FindAsync(id);
                if (conference == null)
                {
                    return NotFound("Record not found.");
                }

                _context.ConferencesArranged.Remove(conference);
                await _context.SaveChangesAsync();

                return Ok("Conference arranged record deleted successfully.");
            }
            // exclusive or non exclsuive form
            [HttpPost("exclusive-or-nonexclusive")]
            public async Task<IActionResult> AddExclusiveOrNonExclusive(ExclusiveOrNonExclusiveDTO dto)
            {
                // Check if the provided ric_form_2_id exists in OricForms
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                var exclusiveLicense = _mapper.Map<ExclusiveOrNonExclusive>(dto);
                _context.ExclusiveOrNonExclusives.Add(exclusiveLicense);
                await _context.SaveChangesAsync();

                return Ok("Exclusive/Non-Exclusive license record added successfully.");
            }

            [HttpPut("exclusive-or-nonexclusive/{id}")]
            public async Task<IActionResult> UpdateExclusiveOrNonExclusive(int id, ExclusiveOrNonExclusiveDTO dto)
            {
                var exclusiveLicense = await _context.ExclusiveOrNonExclusives.FindAsync(id);
                if (exclusiveLicense == null)
                {
                    return NotFound("Record not found.");
                }

                // Check if the provided ric_form_2_id exists in OricForms
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                _mapper.Map(dto, exclusiveLicense);
                await _context.SaveChangesAsync();

                return Ok("Exclusive/Non-Exclusive license record updated successfully.");
            }

            [HttpDelete("exclusive-or-nonexclusive/{id}")]
            public async Task<IActionResult> DeleteExclusiveOrNonExclusive(int id)
            {
                var exclusiveLicense = await _context.ExclusiveOrNonExclusives.FindAsync(id);
                if (exclusiveLicense == null)
                {
                    return NotFound("Record not found.");
                }

                _context.ExclusiveOrNonExclusives.Remove(exclusiveLicense);
                await _context.SaveChangesAsync();

                return Ok("Exclusive/Non-Exclusive license record deleted successfully.");
            }

            //  exhibition event form

            [HttpPost("exhibition-event")]
            public async Task<IActionResult> AddExhibitionEvent(ExhibitionEventDTO dto)
            {
                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                var exhibitionEvent = _mapper.Map<ExhibitionEvent>(dto);
                _context.ExhibitionEvents.Add(exhibitionEvent);
                await _context.SaveChangesAsync();

                return Ok("Exhibition event record added successfully.");
            }

            [HttpPut("exhibition-event/{id}")]
            public async Task<IActionResult> UpdateExhibitionEvent(int id, ExhibitionEventDTO dto)
            {
                var exhibitionEvent = await _context.ExhibitionEvents.FindAsync(id);
                if (exhibitionEvent == null)
                {
                    return NotFound("Record not found.");
                }

                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                _mapper.Map(dto, exhibitionEvent);
                await _context.SaveChangesAsync();

                return Ok("Exhibition event record updated successfully.");
            }

            [HttpDelete("exhibition-event/{id}")]
            public async Task<IActionResult> DeleteExhibitionEvent(int id)
            {
                var exhibitionEvent = await _context.ExhibitionEvents.FindAsync(id);
                if (exhibitionEvent == null)
                {
                    return NotFound("Record not found.");
                }

                _context.ExhibitionEvents.Remove(exhibitionEvent);
                await _context.SaveChangesAsync();

                return Ok("Exhibition event record deleted successfully.");
            }


            // honor or award
            [HttpPost("honor-award")]
            public async Task<IActionResult> AddHonorOrAward(HonorOrAwardDTO dto)
            {
                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                var honorOrAward = _mapper.Map<HonorOrAward>(dto);
                _context.HonorsAwards.Add(honorOrAward);
                await _context.SaveChangesAsync();

                return Ok("Honor/Award added successfully.");
            }

            [HttpPut("honor-award/{id}")]
            public async Task<IActionResult> UpdateHonorOrAward(int id, HonorOrAwardDTO dto)
            {
                var honorOrAward = await _context.HonorsAwards.FindAsync(id);
                if (honorOrAward == null)
                {
                    return NotFound("Record not found.");
                }

                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                _mapper.Map(dto, honorOrAward);
                await _context.SaveChangesAsync();

                return Ok("Honor/Award record updated successfully.");
            }

            [HttpDelete("honor-award/{id}")]
            public async Task<IActionResult> DeleteHonorOrAward(int id)
            {
                var honorOrAward = await _context.HonorsAwards.FindAsync(id);
                if (honorOrAward == null)
                {
                    return NotFound("Record not found.");
                }

                _context.HonorsAwards.Remove(honorOrAward);
                await _context.SaveChangesAsync();

                return Ok("Honor/Award record deleted successfully.");
            }

            // Ip disclousre form
            [HttpPost("ip-disclosure")]
            public async Task<IActionResult> AddIPDisclosure(IPDisclosureDTO dto)
            {
                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                var ipDisclosure = _mapper.Map<IPDisclosure>(dto);
                _context.IPDisclosures.Add(ipDisclosure);
                await _context.SaveChangesAsync();

                return Ok("IP Disclosure added successfully.");
            }

            [HttpPut("ip-disclosure/{id}")]
            public async Task<IActionResult> UpdateIPDisclosure(int id, IPDisclosureDTO dto)
            {
                var ipDisclosure = await _context.IPDisclosures.FindAsync(id);
                if (ipDisclosure == null)
                {
                    return NotFound("Record not found.");
                }

                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                _mapper.Map(dto, ipDisclosure);
                await _context.SaveChangesAsync();

                return Ok("IP Disclosure record updated successfully.");
            }

            [HttpDelete("ip-disclosure/{id}")]
            public async Task<IActionResult> DeleteIPDisclosure(int id)
            {
                var ipDisclosure = await _context.IPDisclosures.FindAsync(id);
                if (ipDisclosure == null)
                {
                    return NotFound("Record not found.");
                }

                _context.IPDisclosures.Remove(ipDisclosure);
                await _context.SaveChangesAsync();

                return Ok("IP Disclosure record deleted successfully.");
            }


            // Ip licensing 



            [HttpPost("ip-licensing-negotiation")]
            public async Task<IActionResult> AddIPLicensingNegotiation(IPLicensingNegotiationDTO dto)
            {
                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                var ipNegotiation = _mapper.Map<IPLicensingNegotiation>(dto);
                _context.IPLicensingNegotiations.Add(ipNegotiation);
                await _context.SaveChangesAsync();

                return Ok("IP Licensing Negotiation added successfully.");
            }

            [HttpPut("ip-licensing-negotiation/{id}")]
            public async Task<IActionResult> UpdateIPLicensingNegotiation(int id, IPLicensingNegotiationDTO dto)
            {
                var ipNegotiation = await _context.IPLicensingNegotiations.FindAsync(id);
                if (ipNegotiation == null)
                {
                    return NotFound("Record not found.");
                }

                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                _mapper.Map(dto, ipNegotiation);
                await _context.SaveChangesAsync();

                return Ok("IP Licensing Negotiation record updated successfully.");
            }

            [HttpDelete("ip-licensing-negotiation/{id}")]
            public async Task<IActionResult> DeleteIPLicensingNegotiation(int id)
            {
                var ipNegotiation = await _context.IPLicensingNegotiations.FindAsync(id);
                if (ipNegotiation == null)
                {
                    return NotFound("Record not found.");
                }

                _context.IPLicensingNegotiations.Remove(ipNegotiation);
                await _context.SaveChangesAsync();

                return Ok("IP Licensing Negotiation record deleted successfully.");
            }


            // Patent
            [HttpPost("patent")]
            public async Task<IActionResult> AddPatent(PatentDTO dto)
            {
                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                var patent = _mapper.Map<Patent>(dto);
                _context.Patents.Add(patent);
                await _context.SaveChangesAsync();

                return Ok("Patent record added successfully.");
            }

            [HttpPut("patent/{id}")]
            public async Task<IActionResult> UpdatePatent(int id, PatentDTO dto)
            {
                var patent = await _context.Patents.FindAsync(id);
                if (patent == null)
                {
                    return NotFound("Record not found.");
                }

                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                _mapper.Map(dto, patent);
                await _context.SaveChangesAsync();

                return Ok("Patent record updated successfully.");
            }

            [HttpDelete("patent/{id}")]
            public async Task<IActionResult> DeletePatent(int id)
            {
                var patent = await _context.Patents.FindAsync(id);
                if (patent == null)
                {
                    return NotFound("Record not found.");
                }

                _context.Patents.Remove(patent);
                await _context.SaveChangesAsync();

                return Ok("Patent record deleted successfully.");
            }

            // research product
            [HttpPost("research-product")]
            public async Task<IActionResult> AddResearchProduct(ResearchProductDTO dto)
            {
                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                var researchProduct = _mapper.Map<ResearchProduct>(dto);
                _context.ResearchProducts.Add(researchProduct);
                await _context.SaveChangesAsync();

                return Ok("Research product record added successfully.");
            }

            [HttpPut("research-product/{id}")]
            public async Task<IActionResult> UpdateResearchProduct(int id, ResearchProductDTO dto)
            {
                var researchProduct = await _context.ResearchProducts.FindAsync(id);
                if (researchProduct == null)
                {
                    return NotFound("Record not found.");
                }

                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                _mapper.Map(dto, researchProduct);
                await _context.SaveChangesAsync();

                return Ok("Research product record updated successfully.");
            }

            [HttpDelete("research-product/{id}")]
            public async Task<IActionResult> DeleteResearchProduct(int id)
            {
                var researchProduct = await _context.ResearchProducts.FindAsync(id);
                if (researchProduct == null)
                {
                    return NotFound("Record not found.");
                }

                _context.ResearchProducts.Remove(researchProduct);
                await _context.SaveChangesAsync();

                return Ok("Research product record deleted successfully.");
            }


            //  research publication

            [HttpPost("research-publication")]
            public async Task<IActionResult> AddResearchPublication(ResearchPublicationDTO dto)
            {
                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                var researchPublication = _mapper.Map<ResearchPublication>(dto);
                _context.ResearchPublications.Add(researchPublication);
                await _context.SaveChangesAsync();

                return Ok("Research publication record added successfully.");
            }

            [HttpPut("research-publication/{id}")]
            public async Task<IActionResult> UpdateResearchPublication(int id, ResearchPublicationDTO dto)
            {
                var researchPublication = await _context.ResearchPublications.FindAsync(id);
                if (researchPublication == null)
                {
                    return NotFound("Record not found.");
                }

                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                _mapper.Map(dto, researchPublication);
                await _context.SaveChangesAsync();

                return Ok("Research publication record updated successfully.");
            }

            [HttpDelete("research-publication/{id}")]
            public async Task<IActionResult> DeleteResearchPublication(int id)
            {
                var researchPublication = await _context.ResearchPublications.FindAsync(id);
                if (researchPublication == null)
                {
                    return NotFound("Record not found.");
                }

                _context.ResearchPublications.Remove(researchPublication);
                await _context.SaveChangesAsync();

                return Ok("Research publication record deleted successfully.");
            }

            // science arts product
            [HttpPost("science-arts-product")]
            public async Task<IActionResult> AddScienceArtsProduct(ScienceArtsProductDTO dto)
            {
                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                var scienceArtsProduct = _mapper.Map<ScienceArtsProduct>(dto);
                _context.ScienceArtsProducts.Add(scienceArtsProduct);
                await _context.SaveChangesAsync();

                return Ok("Science & Arts product record added successfully.");
            }

            [HttpPut("science-arts-product/{id}")]
            public async Task<IActionResult> UpdateScienceArtsProduct(int id, ScienceArtsProductDTO dto)
            {
                var scienceArtsProduct = await _context.ScienceArtsProducts.FindAsync(id);
                if (scienceArtsProduct == null)
                {
                    return NotFound("Record not found.");
                }

                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                _mapper.Map(dto, scienceArtsProduct);
                await _context.SaveChangesAsync();

                return Ok("Science & Arts product record updated successfully.");
            }

            [HttpDelete("science-arts-product/{id}")]
            public async Task<IActionResult> DeleteScienceArtsProduct(int id)
            {
                var scienceArtsProduct = await _context.ScienceArtsProducts.FindAsync(id);
                if (scienceArtsProduct == null)
                {
                    return NotFound("Record not found.");
                }

                _context.ScienceArtsProducts.Remove(scienceArtsProduct);
                await _context.SaveChangesAsync();

                return Ok("Science & Arts product record deleted successfully.");
            }


            //training workshop seminar

            [HttpPost("training-workshop-seminar")]
            public async Task<IActionResult> AddTrainingWorkshopSeminar(TrainingWorkshopSeminarDTO dto)
            {
                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                var trainingWorkshopSeminar = _mapper.Map<TrainingWorkshopSeminar>(dto);
                _context.TrainingWorkshopSeminars.Add(trainingWorkshopSeminar);
                await _context.SaveChangesAsync();

                return Ok("Training/Workshop/Seminar record added successfully.");
            }

            [HttpPut("training-workshop-seminar/{id}")]
            public async Task<IActionResult> UpdateTrainingWorkshopSeminar(int id, TrainingWorkshopSeminarDTO dto)
            {
                var trainingWorkshopSeminar = await _context.TrainingWorkshopSeminars.FindAsync(id);
                if (trainingWorkshopSeminar == null)
                {
                    return NotFound("Record not found.");
                }

                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                _mapper.Map(dto, trainingWorkshopSeminar);
                await _context.SaveChangesAsync();

                return Ok("Training/Workshop/Seminar record updated successfully.");
            }

            [HttpDelete("training-workshop-seminar/{id}")]
            public async Task<IActionResult> DeleteTrainingWorkshopSeminar(int id)
            {
                var trainingWorkshopSeminar = await _context.TrainingWorkshopSeminars.FindAsync(id);
                if (trainingWorkshopSeminar == null)
                {
                    return NotFound("Record not found.");
                }

                _context.TrainingWorkshopSeminars.Remove(trainingWorkshopSeminar);
                await _context.SaveChangesAsync();

                return Ok("Training/Workshop/Seminar record deleted successfully.");
            }

            // visit representative

            [HttpPost("visit-representative")]
            public async Task<IActionResult> AddVisitRepresentative(VisitRepresentativeDTO dto)
            {
                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                var visitRepresentative = _mapper.Map<VisitRepresentative>(dto);
                _context.VisitRepresentatives.Add(visitRepresentative);
                await _context.SaveChangesAsync();

                return Ok("Visit Representative record added successfully.");
            }

            [HttpPut("visit-representative/{id}")]
            public async Task<IActionResult> UpdateVisitRepresentative(int id, VisitRepresentativeDTO dto)
            {
                var visitRepresentative = await _context.VisitRepresentatives.FindAsync(id);
                if (visitRepresentative == null)
                {
                    return NotFound("Record not found.");
                }

                // Check if the provided ric_form_2_id exists in OricForm2
                var oricFormExists = await _context.OricForms.AnyAsync(o => o.ric_form_2_id == dto.ric_form_2_id);
                if (!oricFormExists)
                {
                    return BadRequest("Invalid ric_form_2_id. No matching record found in OricForm2.");
                }

                _mapper.Map(dto, visitRepresentative);
                await _context.SaveChangesAsync();

                return Ok("Visit Representative record updated successfully.");
            }

            [HttpDelete("visit-representative/{id}")]
            public async Task<IActionResult> DeleteVisitRepresentative(int id)
            {
                var visitRepresentative = await _context.VisitRepresentatives.FindAsync(id);
                if (visitRepresentative == null)
                {
                    return NotFound("Record not found.");
                }

                _context.VisitRepresentatives.Remove(visitRepresentative);
                await _context.SaveChangesAsync();

                return Ok("Visit Representative record deleted successfully.");
            }

        }

    }

