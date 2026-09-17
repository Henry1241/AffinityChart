using AffinityChart.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


public class DataBaseConn : DbContext
{
    public DataBaseConn(DbContextOptions<DbContext> options) : base(options)
    {
    }

    public DbSet<Cajonera> Cajoneros { get; set; }
    public DbSet<Affinity> Affinities { get; set; }

    
}

builder.Services.AddDBContext<>(options =>
        options.useNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")))