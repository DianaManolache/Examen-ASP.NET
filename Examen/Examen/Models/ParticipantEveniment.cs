namespace Examen.Models
{
    public class ParticipantEveniment
    {
        public int EvenimentId { get; set; }
        public int ParticipantId { get; set; }
        public Eveniment Eveniment { get; set; }
        public Participant Participant { get; set; }

    }
}
