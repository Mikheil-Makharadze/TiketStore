using FilmStore.Data.Base;
using FilmStore.Data.Services.Interfaces;
using FilmStore.Models;

namespace FilmStore.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
