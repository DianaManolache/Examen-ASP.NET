using Examen.Models;

namespace Examen.Interfaces
{
    public interface IParticipantRepository
    {
        ICollection<Participant> GetParticipants();

        Participant GetParticipant(int id);
        Participant GetParticipant(string tip);
        bool ParticipantExists(int participantId);
        bool CreateParticipant(int Id, Participant participant);
        bool Save();
    }
}

