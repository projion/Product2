using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Product2.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }


    public virtual DbSet<ProductInfo> ProductInfo { get; set; }
    public virtual DbSet<StatusInfo> StatusInfo { get; set; }
    public virtual DbSet<UnitInfo> UnitInfo { get; set; }
    public DbSet<SupplierInfo> SupplierInfo { get; set; }

    public DbSet<StockDetails> StockDetails { get; set; }
    public DbSet<StockMaster> StockMaster { get; set; }


}