using ComputerClub.Model.Entitys;
using Microsoft.EntityFrameworkCore;

namespace ComputerClub.Model;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Player> Players { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }
    public DbSet<Session> Sessions { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.Id).ValueGeneratedOnAdd();
            
            entity.Property(p => p.Name).IsRequired();
            entity.Property(p => p.Year).IsRequired();
            
            entity.HasMany(p => p.PlayerSessions)
                  .WithOne()
                  .HasForeignKey(s => s.PlayerId);
            
            entity.Property(p => p.GamesName)
                  .HasConversion(
                      v => string.Join(',', v),
                      v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.HasKey(s => s.Id);
            entity.Property(s => s.Id).ValueGeneratedOnAdd();
            
            entity.HasOne<Player>()
                  .WithOne()
                  .HasForeignKey<Subscription>(s => s.PlayerId);
            
            entity.Property(s => s.StartDate).IsRequired();
            entity.Property(s => s.EndDate).IsRequired();
            entity.Property(s => s.Balance).IsRequired();
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.HasKey(s => s.Id);
            entity.Property(s => s.Id).ValueGeneratedOnAdd();
            
            entity.Property(s => s.GameName).IsRequired();
            entity.Property(s => s.StartTime).IsRequired();
            entity.Property(s => s.DurationMinutes).IsRequired();
            entity.Property(s => s.PlayerId).IsRequired();
        });
    }
}