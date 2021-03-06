using Microsoft.EntityFrameworkCore;
using vega.Models;

namespace vega
{
  public class VegaDbContext : DbContext
  {
    public VegaDbContext(DbContextOptions<VegaDbContext> options)
        : base(options) { }
    public DbSet<Make> Makes { get; set; }
  }

}
