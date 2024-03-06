using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infraestructure.Data.Context;

public partial class BdcompanyContext : DbContext
{
    public BdcompanyContext()
    {
    }

    public BdcompanyContext(DbContextOptions<BdcompanyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = DESKTOP-PH3EQBP\\SQLEXPRESS; initial catalog = BDCompany; user id = sa; password = 12345;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC0732F7D597");

            entity.Property(e => e.ProductName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProductType)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
