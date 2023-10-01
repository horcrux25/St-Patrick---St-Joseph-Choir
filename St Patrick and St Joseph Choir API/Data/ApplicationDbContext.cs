using Microsoft.EntityFrameworkCore;

namespace St_Patrick_and_St_Joseph_Choir_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
