using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Models;

namespace Api.Services
{
    public interface IDirectorService
    {
        Task<List<Director>> GetAllDirectorsService();
        Task<Director> GetDirectorByIdService(int id);
        Task<List<Director>> AddDirectorService(Director newDirector);
        Task<Director> UpdateDirectorService(int id, Director updateDirector);
    }
}