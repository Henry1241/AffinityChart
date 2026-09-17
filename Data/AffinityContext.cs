using AffinityChart.Enums;
using AffinityChart.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql.NameTranslation;

namespace AffinityChart.Data;

public class AffinityContext(DbContextOptions<AffinityContext> options) : DbContext(options)
{
    public DbSet<Affinity> affinityChart { get; set; }
}

