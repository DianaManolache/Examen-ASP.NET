using AutoMapper;
using Examen.Interfaces;
using Examen.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{

    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]

    public class ParticipantController : Controller
    {
        private readonly IEvenimentRepository _evenimentRepository;
        private readonly IParticipantRepository _participantRepository;
        private readonly IMapper _mapper;

        public ParticipantController(IEvenimentRepository evenimentRepository,
            IParticipantRepository participantRepository,
            IMapper mapper)
        {
            _participantRepository = participantRepository;
            _evenimentRepository = evenimentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Participant>))]
        public IActionResult Getparticipants()
        {
            var participants = _mapper.Map<List<ParticipantDto>>(_participantRepository.GetParticipants());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(participants);
        }
    }
}


