﻿using FilmStore.Data.Base;
using FilmStore.Data.ViewModels;
using FilmStore.Models;

namespace FilmStore.Data.Services.Interfaces
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
