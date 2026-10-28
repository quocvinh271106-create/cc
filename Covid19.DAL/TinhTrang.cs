using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Covid19.DAL
{
    public class TinhTrang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]   // không tự tăng
        public int MaTT { get; set; }

        [Required, MaxLength(150)]
        public string TenTT { get; set; } = null!;

        public virtual ICollection<BenhNhan> BenhNhans { get; set; } = new List<BenhNhan>();
    }
}