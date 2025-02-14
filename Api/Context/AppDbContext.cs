using Api.Models;
using Microsoft.EntityFrameworkCore;


namespace Api.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Atleta> atletas { get; set; }
        public DbSet<AtletasPartida> atletasPartidas { get; set; }
        public DbSet<Partidas> partidas { get; set; }   
        public DbSet<PartidasGames> partidasGames { get; set; }
        public DbSet<Ranking> ranking { get; set; }

    }
}
