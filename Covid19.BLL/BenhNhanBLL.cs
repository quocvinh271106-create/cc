using Covid19.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Covid19.BLL
{
    public class BenhNhanDong
    {
        public string MaBN { get; set; } = "";
        public string TenBN { get; set; } = "";
        public string TenTT { get; set; } = "";
        public string F { get; set; } = "";
    }

    public class BenhNhanBLL
    {
        private readonly BenhNhanDAL dal = new BenhNhanDAL();

        public List<string> GetDanhSachNguonLayNhiem()
        {
            var danhSach = new List<string> { "" };
            danhSach.AddRange(dal.GetAll().Select(b => b.MaBN));
            return danhSach;
        }

        public List<BenhNhanDong> GetDanhSachHienThi()
        {
            var danhSach = dal.GetAll();

            var map = danhSach.ToDictionary(
                b => b.MaBN,
                b => b.BNTXG);

            return danhSach.Select(b => new BenhNhanDong
            {
                MaBN = b.MaBN,
                TenBN = b.TenBN,
                TenTT = b.TinhTrang?.TenTT ?? "",
                F = TinhF(b.MaBN, map)
            }).ToList();
        }

        public string TinhF(
            string maBN,
            Dictionary<string, string?> map)
        {
            int f = 0;
            var daDi = new HashSet<string>();
            string? hienTai = maBN;

            while (true)
            {
                if (hienTai == null ||
                    !map.TryGetValue(hienTai, out var nguon))
                    return "";

                if (!daDi.Add(hienTai))
                    return "";

                if (string.IsNullOrWhiteSpace(nguon))
                    return "F" + f;

                f++;
                hienTai = nguon;
            }
        }

        public string CapNhat(
            string maBN,
            string tenBN,
            int maTT,
            string? ghiChu,
            string? bnTXG)
        {
            if (string.IsNullOrWhiteSpace(maBN) ||
                string.IsNullOrWhiteSpace(tenBN))
            {
                return "Vui lòng nhập đầy đủ thông tin bệnh nhân!";
            }

            maBN = maBN.Trim();
            tenBN = tenBN.Trim();

            if (maBN.Length != 6)
            {
                return "Mã bệnh nhân phải có 6 kí tự!";
            }

            if (bnTXG != null)
            {
                bnTXG = bnTXG.Trim();

                if (bnTXG == "")
                    bnTXG = null;
            }

            if (bnTXG == maBN)
            {
                return "Bệnh nhân không thể lây nhiễm từ chính mình!";
            }

            var danhSach = dal.GetAll();

            if (!danhSach.Any(b => b.MaBN == maBN) &&
                danhSach.Any(b => b.MaBN == bnTXG))
            {
                // Nguồn lây phải là bệnh nhân đã tồn tại.
            }

            try
            {
                var benhNhan = new BenhNhan
                {
                    MaBN = maBN,
                    TenBN = tenBN,
                    MaTT = maTT,
                    GhiChu = ghiChu,
                    BNTXG = bnTXG
                };

                dal.Luu(benhNhan);

                return "Cập nhật dữ liệu thành công!";
            }
            catch (Exception ex)
            {
                return "Không thể cập nhật dữ liệu: " + ex.Message;
            }
        }
    }
}