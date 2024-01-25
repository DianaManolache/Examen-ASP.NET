using Examen.Data;
using Examen.Interfaces;
using Examen.Models;

namespace Examen.Repositories
{
    public class ParticipantRepository : IParticipantRepository
    {
        private readonly DataContext _context;

        public ParticipantRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Participant> GetParticipants()
        {
            return _context.Participants.OrderBy(p => p.Id).ToList();
        }
        public Participant GetParticipant(int id)
        {
            return _context.Participants.Where(p => p.Id == id).FirstOrDefault();
        }
        public Participant GetParticipant(string tip)
        {
            return _context.Participants.Where(p => p.tip == tip).FirstOrDefault();
        }
        public bool ParticipantExists(int participantId)
        {
            return _context.Participants.Any(p => p.Id == participantId);
        }
        public bool CreateParticipant(int participantId, Participant participant)
        {
            var participantEvenimentEntity = _context.Eveniments.Where(e => e.Id == participantId).FirstOrDefault();

            var participantEveniment = new ParticipantEveniment()
            {
                Eveniment = participantEvenimentEntity,
                Participant = participant,
            };

            _context.Add(participantEveniment);
            _context.Add(participant);

            return Save();
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}


