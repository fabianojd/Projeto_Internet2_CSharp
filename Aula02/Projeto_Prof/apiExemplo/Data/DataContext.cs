using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    public DbSet<TipoCurso> TipoCursos { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}
