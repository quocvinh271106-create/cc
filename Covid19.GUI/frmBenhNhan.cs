using Covid19.BLL;
using Covid19.DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Covid19.GUI
{
    public partial class frmBenhNhan : Form
    {
        private readonly TinhTrangBLL ttBLL = new TinhTrangBLL();
        private readonly BenhNhanBLL bnBLL = new BenhNhanBLL();

        public frmBenhNhan()
        {
            InitializeComponent();
            this.Load += frmBenhNhan_Load;
        }

        private void frmBenhNhan_Load(object? sender, EventArgs e)
        {
            try
            {
                dgvBenhNhan.AutoGenerateColumns = false;
                dgvBenhNhan.Columns[0].DataPropertyName = "MaBN";
                dgvBenhNhan.Columns[1].DataPropertyName = "TenBN";
                dgvBenhNhan.Columns[2].DataPropertyName = "TenTT";
                dgvBenhNhan.Columns[3].DataPropertyName = "F";

                LoadDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void LoadDuLieu()
        {
            // ComboBox Tình Trạng
            cboTinhTrang.DataSource = null;
            cboTinhTrang.DataSource = ttBLL.GetAll();
            cboTinhTrang.DisplayMember = "TenTT";
            cboTinhTrang.ValueMember = "MaTT";
            cboTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;

            // ComboBox Lây Nhiễm Từ
            cboLayNhiemTu.DataSource = null;
            cboLayNhiemTu.DataSource = bnBLL.GetDanhSachNguonLayNhiem();
            cboLayNhiemTu.DropDownStyle = ComboBoxStyle.DropDownList;

            // DataGridView
            dgvBenhNhan.DataSource = null;
            dgvBenhNhan.DataSource = bnBLL.GetDanhSachHienThi();

            DatLaiGiaTriMacDinh();
        }

        private void DatLaiGiaTriMacDinh()
        {
            txtMaBN.Clear();
            txtTenBN.Clear();
            txtGhiChu.Clear();

            if (cboTinhTrang.Items.Count > 0)
                cboTinhTrang.SelectedIndex = 0;

            if (cboLayNhiemTu.Items.Count > 0)
                cboLayNhiemTu.SelectedIndex = 0;

            txtMaBN.Focus();
        }

        private void txtMaBN_TextChanged(object sender, EventArgs e) { }
        private void txtTenBN_TextChanged(object sender, EventArgs e) { }
        private void cboTinhTrang_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtGhiChu_TextChanged(object sender, EventArgs e) { }
        private void cboLayNhiemTu_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (cboTinhTrang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tình trạng!");
                return;
            }

            if (!int.TryParse(
                cboTinhTrang.SelectedValue.ToString(),
                out int maTT))
            {
                MessageBox.Show("Tình trạng không hợp lệ!");
                return;
            }

            string maBN = txtMaBN.Text.Trim();
            string tenBN = txtTenBN.Text.Trim();
            string ghiChu = txtGhiChu.Text;

            string? bnTXG = cboLayNhiemTu.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(bnTXG))
                bnTXG = null;

            string ketQua = bnBLL.CapNhat(
                maBN,
                tenBN,
                maTT,
                ghiChu,
                bnTXG);

            if (ketQua == "Cập nhật dữ liệu thành công!")
            {
                MessageBox.Show(ketQua);

                LoadDuLieu();
                DatLaiGiaTriMacDinh();
            }
            else
            {
                MessageBox.Show(ketQua, "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvBenhNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string maBN = Convert.ToString(
                dgvBenhNhan.Rows[e.RowIndex].Cells[0].Value) ?? "";

            var bn = new BenhNhanDAL().GetAll()
                .FirstOrDefault(x => x.MaBN == maBN);

            if (bn == null)
                return;

            txtMaBN.Text = bn.MaBN;
            txtTenBN.Text = bn.TenBN;
            txtGhiChu.Text = bn.GhiChu;

            cboTinhTrang.SelectedValue = bn.MaTT;
            cboLayNhiemTu.SelectedItem = bn.BNTXG ?? "";
        }

        private void mnuChucNang_Click(object sender, EventArgs e) { }

        private void mnuThongKe_Click(object sender, EventArgs e)
        {
            using (frmThongKe f = new frmThongKe())
                f.ShowDialog();
        }

        private void mnuBieuDo_Click(object sender, EventArgs e)
        {
            // Mở form biểu đồ khi anh đã có frmBieuDo.
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBenhNhan_Load_1(object sender, EventArgs e)
        {

        }
    }
}