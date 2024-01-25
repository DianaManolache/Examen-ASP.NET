using AutoMapper;
using Examen.Interfaces;
using Examen.Models;
using Examen.Dto;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{

    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
        
    public class EvenimentController : Controller
    {
        private readonly IEvenimentRepository _evenimentRepository;
        private readonly IParticipantRepository _participantRepository;
        private readonly IMapper _mapper;

        public EvenimentController(IEvenimentRepository evenimentRepository,
            IParticipantRepository participantRepository,
            IMapper mapper)
        {
            _participantRepository = participantRepository;
            _evenimentRepository = evenimentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Eveniment>))]
        public IActionResult GetEveniments()
        {
            var events = _mapper.Map<List<EvenimentDto>>(_evenimentRepository.GetEveniments());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(events);
        }
    }
}


