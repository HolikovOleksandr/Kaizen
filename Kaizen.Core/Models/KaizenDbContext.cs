using Kaizen.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Kaizen.Core;

 public class KaizenDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public KaizenDbContext(DbContextOptions<KaizenDbContext> options) : base(options)
    {

    }
}
