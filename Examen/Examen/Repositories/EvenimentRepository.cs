using Examen.Data;
using Examen.Interfaces;
using Examen.Models;

namespace Examen.Repositories
{
    public class EvenimentRepository : IEvenimentRepository
    {
        private readonly DataContext _context;

        public EvenimentRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Eveniment> GetEveniments()
        {
            return _context.Eveniments.OrderBy(e => e.Id).ToList();
        }

        public Eveniment GetEveniment(int id)
        {
            return _context.Eveniments.Where(e => e.Id == id).FirstOrDefault();
        }
        public bool EvenimentExists(int evenimentId)
        {
            return _context.Eveniments.Any(e => e.Id == evenimentId);
        }
        public Eveniment GetEveniment(string name)
        {
            return _context.Eveniments.Where(e => e.Name == name).FirstOrDefault();
        }

        public bool CreateEveniment(int evenimentId, Eveniment eveniment)
        {
            var participantEvenimentEntity = _context.Participants.Where(p => p.Id == evenimentId).FirstOrDefault();

            var participantEveniment = new ParticipantEveniment()
            {
                Participant = participantEvenimentEntity,
                Eveniment = eveniment,
            };

            _context.Add(participantEveniment);
            _context.Add(eveniment);

            return Save();
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
