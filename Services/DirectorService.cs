using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data;
using Api.Models;

namespace Api.Services
{
    public class DirectorService : IDirectorService
    {
        private readonly ApplicationDbContext _context;

        public DirectorService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<Director>> AddDirectorService(Director newDirector)
        {
            await _context.AddAsync(newDirector);
            await _context.SaveChangesAsync();
            
            return _context.Director.ToList();
        }
    }
}