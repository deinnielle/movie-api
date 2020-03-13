using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Services
{
    public class DirectorService : IDirectorService
    {
        private readonly ApplicationDbContext _context;

        public DirectorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Director>> GetAllDirectorsService()
        {
            return _context.Director.Include(m => m.Movies).ToList();
        }

        public async Task<Director> GetDirectorByIdService(int id)
        {
            return _context.Director.Include(m => m.Movies).FirstOrDefault(d => d.Id == id);
        }

        public async Task<List<Director>> AddDirectorService(Director newDirector)
        {
            await _context.AddAsync(newDirector);
            await _context.SaveChangesAsync();
            
            return _context.Director.ToList();
        }

        public async Task<Director> UpdateDirectorService(int id, Director updateDirector)
        {
            Director director = _context.Director.FirstOrDefault(d=> d.Id == id);
            director.Name = updateDirector.Name;
            director.Age = updateDirector.Age;
            await _context.SaveChangesAsync();
            
            return _context.Director.FirstOrDefault(d=> d.Id == id);
        }
    }
}