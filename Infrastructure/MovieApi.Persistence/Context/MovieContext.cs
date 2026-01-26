using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entites;

namespace MovieApi.Persistence.Context;

public class MovieContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Cast> Casts { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Tag> Tags { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Port=3306;Database=MovieDb;Uid=root;Pwd=53535353;";
        
        var serverVersion = ServerVersion.AutoDetect(connectionString);
        
        optionsBuilder.UseMySql(connectionString, serverVersion);
    }
}