using Microsoft.EntityFrameworkCore;
using SkiLand.DAL.DdContext;
using SkiLand.Domain.Models;
using SkiLand.Domain.Repositories;

namespace SkiLand.DAL.Repositories
{
    public class HotelRepository: Repository<Hotel>, IHotelRepository
    {
        public HotelRepository(AppDbContext dbContext):base(dbContext)
        {
                
        }
    }
}
