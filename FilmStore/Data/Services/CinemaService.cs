using FilmStore.Data.Base;
using FilmStore.Data.Services.Interfaces;
using FilmStore.Models;

namespace FilmStore.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
