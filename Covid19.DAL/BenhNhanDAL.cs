using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Covid19.DAL
{
    public class BenhNhanDAL
    {
        public List<BenhNhan> GetAll()
        {
            using (var context = new Covid19Context())
            {
                return context.BenhNhans
                    .Include(b => b.TinhTrang)
                    .AsNoTracking()
                    .ToList();
            }
        }

        public BenhNhan? GetById(string maBN)
        {
            using (var context = new Covid19Context())
            {
                return context.BenhNhans
                    .FirstOrDefault(b => b.MaBN == maBN);
            }
        }

        public void Luu(BenhNhan benhNhan)
        {
            using (var context = new Covid19Context())
            {
                var benhNhanCu = context.BenhNhans
                    .FirstOrDefault(b => b.MaBN == benhNhan.MaBN);

                if (benhNhanCu == null)
                {
                    context.BenhNhans.Add(benhNhan);
                }
                else
                {
                    benhNhanCu.TenBN = benhNhan.TenBN;
                    benhNhanCu.MaTT = benhNhan.MaTT;
                    benhNhanCu.GhiChu = benhNhan.GhiChu;
                    benhNhanCu.BNTXG = benhNhan.BNTXG;
                }

                context.SaveChanges();
            }
        }
    }
}