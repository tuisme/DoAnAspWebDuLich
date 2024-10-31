using dulichaspnet.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Admin> Admins { get; set; }
    public DbSet<NguoiDung> NguoiDungs { get; set; }
    public DbSet<DiaDiemDuLich> DiaDiemDuLiches { get; set; }
    public DbSet<DichVuDuLich> DichVuDuLiches { get; set; }
    public DbSet<CongTyVanTai> CongTyVanTais { get; set; }
    public DbSet<CongTyDuLich> CongTyDuLiches { get; set; }
    public DbSet<TuyenDuong> TuyenDuongs { get; set; }
    public DbSet<DatVe> DatVes { get; set; }
}