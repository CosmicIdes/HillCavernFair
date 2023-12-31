﻿using Microsoft.EntityFrameworkCore;
using HillCavernFair.Domain;

namespace HillCavernFair.Data;

public class HillCavernFairContext: DbContext
{
    public DbSet<Paragraph> Paragraph { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(
             "Data Source = Story.db;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Paragraph>().ToTable("Paragraph");
    }
}

