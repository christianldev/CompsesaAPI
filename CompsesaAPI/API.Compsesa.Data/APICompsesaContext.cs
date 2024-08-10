using System;
using API.Compsesa.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Compsesa.Data;

public class APICompsesaContext : DbContext
{
    public APICompsesaContext(DbContextOptions options) : base(options) { }
    public DbSet<DatosSensores> DatosSensores { get; set; }
    public DbSet<Sensores> Sensores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql();
    }

}
