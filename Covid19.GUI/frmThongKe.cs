using Covid19.BLL;
using System;
using System.Windows.Forms;

namespace Covid19.GUI
{
    public partial class frmThongKe : Form
    {
        private readonly TinhTrangBLL ttBLL = new TinhTrangBLL();
        private readonly BenhNhanBLL bnBLL = new BenhNhanBLL();

        public frmThongKe()
        {
            InitializeComponent();
            this.Load += frmThongKe_Load;
        }

        private void frmThongKe_Load(object? sender, EventArgs e)
        {
            try
            {
                cboTinhTrang.DataSource = ttBLL.GetAll();
                cboTinhTrang.DisplayMember = "TenTT";
                cboTinhTrang.ValueMember = "MaTT";
                cboTinhTrang.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void cboTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboTinhTrang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tình trạng!");
                return;
            }

            int maTT;
            if (!int.TryParse(cboTinhTrang.SelectedValue.ToString(), out maTT))
                return;

            // Gọi BLL lấy bệnh nhân theo tình trạng đã chọn.
            // Sau đó đưa dữ liệu vào ReportViewer và hiển thị báo cáo RDLC.
            // Cần khớp tên hàm lấy dữ liệu và tên DataSet trong file RDLC.
        }
    }
}