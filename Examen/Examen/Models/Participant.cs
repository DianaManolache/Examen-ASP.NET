namespace Examen.Models
{
    public class Participant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string tip { get; set; }
        public ICollection<ParticipantEveniment>ParticipantEveniments { get; set; }

    }
}
