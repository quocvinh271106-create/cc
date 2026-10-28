using Microsoft.EntityFrameworkCore;

namespace Covid19.DAL
{
    public class Covid19Context : DbContext
    {
        public DbSet<TinhTrang> TinhTrangs { get; set; }
        public DbSet<BenhNhan> BenhNhans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=localhost;Database=Covid19;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TinhTrang>().ToTable("TinhTrang");
            modelBuilder.Entity<BenhNhan>().ToTable("BenhNhan");

            modelBuilder.Entity<BenhNhan>()
                .HasOne(b => b.TinhTrang)
                .WithMany(t => t.BenhNhans)
                .HasForeignKey(b => b.MaTT)
                .OnDelete(DeleteBehavior.Restrict);

            // Dữ liệu mẫu tình trạng
            modelBuilder.Entity<TinhTrang>().HasData(
                new TinhTrang
                {
                    MaTT = 1,
                    TenTT = "Âm Tính"
                },
                new TinhTrang
                {
                    MaTT = 2,
                    TenTT = "Dương Tính"
                },
                new TinhTrang
                {
                    MaTT = 3,
                    TenTT = "Tái Nhiễm"
                });

            // Dữ liệu mẫu bệnh nhân
            modelBuilder.Entity<BenhNhan>().HasData(
                new BenhNhan
                {
                    MaBN = "BN1342",
                    TenBN = "Nguyễn Văn A",
                    MaTT = 2,
                    BNTXG = null,
                    GhiChu = "Sau khi trở về từ khu cách ly tập trung để cách ly tại nhà, bệnh nhân 1342 - nam tiếp viên Vietnam Airlines đã không tuân thủ quy định, dẫn đến việc lây nhiễm cho người khác và khiến cho nhiều người phải cách ly, nhiều cơ sở kinh doanh và trường học phải tạm đóng cửa."
                },
                new BenhNhan
                {
                    MaBN = "BN1347",
                    TenBN = "Nguyễn Văn B",
                    MaTT = 2,
                    BNTXG = "BN1342",
                    GhiChu = "-Nhập cảnh trên chuyến bay VN5301 từ Nhật – Cần Thơ – Sài Gòn\r\n-Cách ly tại khu cách ly của hãng hàng không Vietnam Airlines. Thành viên tổ bay được lấy mẫu xét nghiệm SARS-COV-2 lần 1 ngày 15/11/2020, lần 2 ngày 18/11/2020 và có kết quả xét nghiệm âm tính."
                },
                new BenhNhan
                {
                    MaBN = "BN1515",
                    TenBN = "Nguyễn Văn C",
                    MaTT = 2,
                    BNTXG = null,
                    GhiChu = "-Từ Qatar nhập cảnh Sân bay Tân Sơn Nhất trên chuyến bay QR970 ngày 9/1/2021\r\n- Cách ly ngay sau khi nhập cảnh tại TP. Hồ Chí Minh"
                },
                new BenhNhan
                {
                    MaBN = "BN2222",
                    TenBN = "Nguyễn Văn D",
                    MaTT = 3,
                    BNTXG = "BN1347",
                    GhiChu = "- Tiếp xúc gần với bệnh nhân 1347"
                });
        }
    }
}