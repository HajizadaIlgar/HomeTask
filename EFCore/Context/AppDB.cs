using EFCore.Tables;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Context;

public class AppDB : DbContext
{
    public DbSet<Users> Users { get; set; }
    public DbSet<Products> Products { get; set; }
    public DbSet<Baskets> Baskets { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=EFProject;Trusted_Connection=True;TrustServerCertificate=True");

        base.OnConfiguring(optionsBuilder);
    }
}

