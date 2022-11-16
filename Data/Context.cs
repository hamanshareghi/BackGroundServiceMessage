using BackGroundServiceMessage.Models;
using Microsoft.EntityFrameworkCore;

namespace BackGroundServiceMessage.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Message> Messages { get; set; }

    }
}
