using cw1_0851_proxy.Models;
using Microsoft.EntityFrameworkCore;

namespace cw1_0851_proxy.Context
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Room> Room { get; set; }
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {

        }
    }
}
