using System;
using API.Compsesa.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Compsesa.Data;

public class APICompsesaContext : DbContext
{
    public APICompsesaContext(DbContextOptions<APICompsesaContext> options) : base(options) { }
    public APICompsesaContext() { }
    public DbSet<DatosSensores> DatosSensores { get; set; }
    public DbSet<Sensores> Sensores { get; set; }


}
