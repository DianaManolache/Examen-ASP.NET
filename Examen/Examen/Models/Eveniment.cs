namespace Examen.Models
{
    public class Eveniment
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public ICollection<ParticipantEveniment> ParticipantEveniments { get; set; }

    }
}
