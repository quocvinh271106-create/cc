using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Covid19.DAL.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TinhTrang",
                columns: table => new
                {
                    MaTT = table.Column<int>(type: "int", nullable: false),
                    TenTT = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhTrang", x => x.MaTT);
                });

            migrationBuilder.CreateTable(
                name: "BenhNhan",
                columns: table => new
                {
                    MaBN = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TenBN = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MaTT = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BNTXG = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenhNhan", x => x.MaBN);
                    table.ForeignKey(
                        name: "FK_BenhNhan_TinhTrang_MaTT",
                        column: x => x.MaTT,
                        principalTable: "TinhTrang",
                        principalColumn: "MaTT",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "TinhTrang",
                columns: new[] { "MaTT", "TenTT" },
                values: new object[,]
                {
                    { 1, "Âm Tính" },
                    { 2, "Dương Tính" },
                    { 3, "Tái Nhiễm" }
                });

            migrationBuilder.InsertData(
                table: "BenhNhan",
                columns: new[] { "MaBN", "BNTXG", "GhiChu", "MaTT", "TenBN" },
                values: new object[,]
                {
                    { "BN1342", null, "Sau khi trở về từ khu cách ly tập trung để cách ly tại nhà, bệnh nhân 1342 - nam tiếp viên Vietnam Airlines đã không tuân thủ quy định, dẫn đến việc lây nhiễm cho người khác và khiến cho nhiều người phải cách ly, nhiều cơ sở kinh doanh và trường học phải tạm đóng cửa.", 2, "Nguyễn Văn A" },
                    { "BN1347", "BN1342", "-Nhập cảnh trên chuyến bay VN5301 từ Nhật – Cần Thơ – Sài Gòn\r\n-Cách ly tại khu cách ly của hãng hàng không Vietnam Airlines. Thành viên tổ bay được lấy mẫu xét nghiệm SARS-COV-2 lần 1 ngày 15/11/2020, lần 2 ngày 18/11/2020 và có kết quả xét nghiệm âm tính.", 2, "Nguyễn Văn B" },
                    { "BN1515", null, "-Từ Qatar nhập cảnh Sân bay Tân Sơn Nhất trên chuyến bay QR970 ngày 9/1/2021\r\n- Cách ly ngay sau khi nhập cảnh tại TP. Hồ Chí Minh", 2, "Nguyễn Văn C" },
                    { "BN2222", "BN1347", "- Tiếp xúc gần với bệnh nhân 1347", 3, "Nguyễn Văn D" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BenhNhan_MaTT",
                table: "BenhNhan",
                column: "MaTT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BenhNhan");

            migrationBuilder.DropTable(
                name: "TinhTrang");
        }
    }
}
