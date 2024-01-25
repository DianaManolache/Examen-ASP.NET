using Examen.Data;
using Examen.Models;

namespace Examen
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {

        }
    }
}