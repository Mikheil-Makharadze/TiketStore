using FilmStore.Data.Base;
using FilmStore.Data.Services.Interfaces;
using FilmStore.Models;

namespace FilmStore.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
