using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Covid19.DAL
{
    public class BenhNhan
    {
        [Key, MaxLength(6)]
        public string MaBN { get; set; } = null!;

        [Required, MaxLength(150)]
        public string TenBN { get; set; } = null!;

        [Required]
        public int MaTT { get; set; }

        public string? GhiChu { get; set; }          // nvarchar(max), null được

        [MaxLength(6)]
        public string? BNTXG { get; set; }           // null được

        [ForeignKey(nameof(MaTT))]
        public virtual TinhTrang TinhTrang { get; set; } = null!;
    }
}