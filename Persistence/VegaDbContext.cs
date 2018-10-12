using Microsoft.EntityFrameworkCore;

namespace vega
{
  public class VegaDbContext : DbContext
  {
    public VegaDbContext(DbContextOptions<VegaDbContext> options)
        : base(options) { }
  }
}
