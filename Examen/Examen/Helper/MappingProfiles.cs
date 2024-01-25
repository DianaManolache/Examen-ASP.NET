using AutoMapper;
using Examen.Dto;
using Examen.Models;
using System.Diagnostics.Metrics;

namespace Examen.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Eveniment, EvenimentDto>();
            CreateMap<EvenimentDto, Eveniment>();
            CreateMap<ParticipantDto, Participant>();
            CreateMap<Participant, ParticipantDto>();
        }
    }
}
