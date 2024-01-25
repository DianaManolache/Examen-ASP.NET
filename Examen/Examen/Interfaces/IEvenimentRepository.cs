using Examen.Models;

namespace Examen.Interfaces
{
    public interface IEvenimentRepository
    {
        ICollection<Eveniment> GetEveniments();
        Eveniment GetEveniment(int id);
        Eveniment GetEveniment(string name);
        bool EvenimentExists(int evenimentId);
        bool CreateEveniment(int Id, Eveniment eveniment);
        bool Save();

    }
}
