using AffinityChart.Models;
using Microsoft.EntityFrameworkCore;

namespace AffinityChart.Data;

public class CajoneraContext(DbContextOptions<CajoneraContext> options) : DbContext(options)
{
    public DbSet<Cajonera> cajonera { get; set; }
}