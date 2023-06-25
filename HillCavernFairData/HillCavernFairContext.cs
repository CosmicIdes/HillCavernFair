using Microsoft.EntityFrameworkCore;
using HillCavernFair.Domain;

namespace HillCavernFair.Data;

public class HillCavernFairContext: DbContext
{
    public DbSet<Paragraph> Paragraphs { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(
             "Data Source = Story.db;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Paragraph>()
            .HasKey(s => new { s.Id });

        // base.OnModelCreating(modelBuilder);
    }
}

