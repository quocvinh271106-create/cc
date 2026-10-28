namespace Covid19.GUI
{
    partial class frmBenhNhan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuChucNang = new ToolStripMenuItem();
            mnuThongKe = new ToolStripMenuItem();
            mnuBieuDo = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTenBN = new TextBox();
            txtMaBN = new TextBox();
            cboTinhTrang = new ComboBox();
            txtGhiChu = new TextBox();
            cboLayNhiemTu = new ComboBox();
            btnCapNhat = new Button();
            btnThoat = new Button();
            dgvBenhNhan = new DataGridView();
            colMaBN = new DataGridViewTextBoxColumn();
            colTenBN = new DataGridViewTextBoxColumn();
            colTinhTrang = new DataGridViewTextBoxColumn();
            colF = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBenhNhan).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuChucNang });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(798, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuChucNang
            // 
            mnuChucNang.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKe, mnuBieuDo, mnuThoat });
            mnuChucNang.Name = "mnuChucNang";
            mnuChucNang.Size = new Size(93, 24);
            mnuChucNang.Text = "Chức năng";
            mnuChucNang.Click += mnuChucNang_Click;
            // 
            // mnuThongKe
            // 
            mnuThongKe.Name = "mnuThongKe";
            mnuThongKe.Size = new Size(205, 26);
            mnuThongKe.Text = "Thống kê";
            mnuThongKe.Click += mnuThongKe_Click;
            // 
            // mnuBieuDo
            // 
            mnuBieuDo.Name = "mnuBieuDo";
            mnuBieuDo.Size = new Size(205, 26);
            mnuBieuDo.Text = "Biểu đồ thống kê";
            mnuBieuDo.Click += mnuBieuDo_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(205, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(255, 28);
            label1.Name = "label1";
            label1.Size = new Size(290, 20);
            label1.TabIndex = 1;
            label1.Text = "Thông Tin Ca Bệnh COVID-19 tại Việt Nam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 1;
            label2.Text = "Thông tin bệnh nhân";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã BN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 161);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 1;
            label4.Text = "Tên BN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 193);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 1;
            label5.Text = "Tình trạng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 225);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 1;
            label6.Text = "Ghi chú";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 331);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 1;
            label7.Text = "Lây nhễm từ";
            // 
            // txtTenBN
            // 
            txtTenBN.Location = new Point(108, 154);
            txtTenBN.Name = "txtTenBN";
            txtTenBN.Size = new Size(151, 27);
            txtTenBN.TabIndex = 2;
            txtTenBN.TextChanged += txtTenBN_TextChanged;
            // 
            // txtMaBN
            // 
            txtMaBN.Location = new Point(108, 117);
            txtMaBN.Name = "txtMaBN";
            txtMaBN.Size = new Size(151, 27);
            txtMaBN.TabIndex = 2;
            txtMaBN.TextChanged += txtMaBN_TextChanged;
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.FormattingEnabled = true;
            cboTinhTrang.Location = new Point(108, 187);
            cboTinhTrang.Name = "cboTinhTrang";
            cboTinhTrang.Size = new Size(151, 28);
            cboTinhTrang.TabIndex = 3;
            cboTinhTrang.SelectedIndexChanged += cboTinhTrang_SelectedIndexChanged;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(108, 225);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.ScrollBars = ScrollBars.Vertical;
            txtGhiChu.Size = new Size(151, 91);
            txtGhiChu.TabIndex = 2;
            txtGhiChu.TextChanged += txtGhiChu_TextChanged;
            // 
            // cboLayNhiemTu
            // 
            cboLayNhiemTu.FormattingEnabled = true;
            cboLayNhiemTu.Location = new Point(108, 331);
            cboLayNhiemTu.Name = "cboLayNhiemTu";
            cboLayNhiemTu.Size = new Size(151, 28);
            cboLayNhiemTu.TabIndex = 3;
            cboLayNhiemTu.SelectedIndexChanged += cboLayNhiemTu_SelectedIndexChanged;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(29, 365);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 4;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(144, 365);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dgvBenhNhan
            // 
            dgvBenhNhan.AllowUserToAddRows = false;
            dgvBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBenhNhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBenhNhan.Columns.AddRange(new DataGridViewColumn[] { colMaBN, colTenBN, colTinhTrang, colF });
            dgvBenhNhan.Location = new Point(308, 83);
            dgvBenhNhan.MultiSelect = false;
            dgvBenhNhan.Name = "dgvBenhNhan";
            dgvBenhNhan.ReadOnly = true;
            dgvBenhNhan.RowHeadersWidth = 51;
            dgvBenhNhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBenhNhan.Size = new Size(492, 336);
            dgvBenhNhan.TabIndex = 5;
            dgvBenhNhan.CellContentClick += dgvBenhNhan_CellContentClick;
            // 
            // colMaBN
            // 
            colMaBN.HeaderText = "Mã BN";
            colMaBN.MinimumWidth = 6;
            colMaBN.Name = "colMaBN";
            colMaBN.ReadOnly = true;
            // 
            // colTenBN
            // 
            colTenBN.HeaderText = "Tên BN";
            colTenBN.MinimumWidth = 6;
            colTenBN.Name = "colTenBN";
            colTenBN.ReadOnly = true;
            // 
            // colTinhTrang
            // 
            colTinhTrang.HeaderText = "Tình Trạng";
            colTinhTrang.MinimumWidth = 6;
            colTinhTrang.Name = "colTinhTrang";
            colTinhTrang.ReadOnly = true;
            // 
            // colF
            // 
            colF.HeaderText = "F";
            colF.MinimumWidth = 6;
            colF.Name = "colF";
            colF.ReadOnly = true;
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 395);
            Controls.Add(dgvBenhNhan);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(cboLayNhiemTu);
            Controls.Add(cboTinhTrang);
            Controls.Add(txtMaBN);
            Controls.Add(txtGhiChu);
            Controls.Add(txtTenBN);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmBenhNhan";
            Text = "Quản lý thông tin bệnh nhân";
            Load += frmBenhNhan_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBenhNhan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuChucNang;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTenBN;
        private TextBox txtMaBN;
        private ComboBox cboTinhTrang;
        private TextBox txtGhiChu;
        private ComboBox cboLayNhiemTu;
        private Button btnCapNhat;
        private Button btnThoat;
        private DataGridView dgvBenhNhan;
        private DataGridViewTextBoxColumn colMaBN;
        private DataGridViewTextBoxColumn colTenBN;
        private DataGridViewTextBoxColumn colTinhTrang;
        private DataGridViewTextBoxColumn colF;
        private ToolStripMenuItem mnuThongKe;
        private ToolStripMenuItem mnuBieuDo;
        private ToolStripMenuItem mnuThoat;
    }
}
