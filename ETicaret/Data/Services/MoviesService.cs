﻿using ETicaret.Data.Base;
using ETicaret.Data.ViewModels;
using ETicaret.Models;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Data.Services
{
    public class MoviesService:EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext _context;
        public MoviesService(AppDbContext context):base(context)
        {
            _context = context;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
                .Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(a => a.Actors_Movies).ThenInclude(m => m.Actor)
                .FirstOrDefaultAsync(n => n.Id == id);

            return movieDetails;
        }

        public async Task<MovieDropdownsVM> GetMovieDropdownsVMValues()
        {
            var response = new MovieDropdownsVM
            {
                Actors = await _context.Actors.OrderBy(n => n.FullName).ToListAsync(),
                Cinemas = await _context.Cinemas.OrderBy(n => n.Name).ToListAsync(),
                Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync()
            };

            return response;
        }
    }
}
