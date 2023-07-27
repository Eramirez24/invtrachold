using InvoiceTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceTracker.Data;

public class InvoicesDbContext : DbContext
{
    public DbSet<Invoice> Invoices { get; set; }  


    public InvoicesDbContext(DbContextOptions options): base (options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=./Data/DataBase/Invoices.db;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Invoice>().ToTable("Invoice");
    }


}
