using EventAuth.Models;
using Microsoft.EntityFrameworkCore;

namespace EventAuth.Context
{
    public class EventAuthContext : DbContext
    {
        public EventAuthContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
