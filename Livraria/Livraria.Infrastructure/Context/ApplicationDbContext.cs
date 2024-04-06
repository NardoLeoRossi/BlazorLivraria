
using Livraria.Domain.Entities;
using Livraria.Infrastructure.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Livraria.Infrastructure.Context;

public class ApplicationDbContext : DbContext
{


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }

    public DbSet<Livro>? Livros { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LivroConfiguration).Assembly);
    }
}
