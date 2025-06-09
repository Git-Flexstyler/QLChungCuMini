namespace QuanlyChungcu
{
    partial class FormPhieuDien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDonGia = new Label();
            groupBoxPD2 = new GroupBox();
            dgvDien = new DataGridView();
            lblThangSD = new Label();
            groupBoxPD1 = new GroupBox();
            txtDonGia = new TextBox();
            txtThangSD = new TextBox();
            txtCSMoi = new TextBox();
            lblCSMoi = new Label();
            txtCSCu = new TextBox();
            lblCSCu = new Label();
            txtMaHoaDonDV = new TextBox();
            lblMaHoaDonDV = new Label();
            txtMaHopDong = new TextBox();
            lblMaHopDong = new Label();
            txtMaPhieuDien = new TextBox();
            lblMaPhieuDien = new Label();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnReset = new Button();
            groupBoxPD2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDien).BeginInit();
            groupBoxPD1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(33, 207);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(75, 25);
            lblDonGia.TabIndex = 14;
            lblDonGia.Text = "Đơn giá";
            // 
            // groupBoxPD2
            // 
            groupBoxPD2.Controls.Add(dgvDien);
            groupBoxPD2.Dock = DockStyle.Bottom;
            groupBoxPD2.Location = new Point(0, 361);
            groupBoxPD2.Name = "groupBoxPD2";
            groupBoxPD2.Size = new Size(908, 289);
            groupBoxPD2.TabIndex = 14;
            groupBoxPD2.TabStop = false;
            groupBoxPD2.Text = "GroupBoxPD2";
            // 
            // dgvDien
            // 
            dgvDien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDien.Dock = DockStyle.Fill;
            dgvDien.Location = new Point(3, 27);
            dgvDien.Name = "dgvDien";
            dgvDien.RowHeadersWidth = 62;
            dgvDien.Size = new Size(902, 259);
            dgvDien.TabIndex = 0;
            dgvDien.CellClick += dgvDien_CellClick;
            // 
            // lblThangSD
            // 
            lblThangSD.AutoSize = true;
            lblThangSD.Location = new Point(499, 153);
            lblThangSD.Name = "lblThangSD";
            lblThangSD.Size = new Size(132, 25);
            lblThangSD.TabIndex = 10;
            lblThangSD.Text = "Tháng sử dụng";
            // 
            // groupBoxPD1
            // 
            groupBoxPD1.Controls.Add(txtDonGia);
            groupBoxPD1.Controls.Add(lblDonGia);
            groupBoxPD1.Controls.Add(txtThangSD);
            groupBoxPD1.Controls.Add(lblThangSD);
            groupBoxPD1.Controls.Add(txtCSMoi);
            groupBoxPD1.Controls.Add(lblCSMoi);
            groupBoxPD1.Controls.Add(txtCSCu);
            groupBoxPD1.Controls.Add(lblCSCu);
            groupBoxPD1.Controls.Add(txtMaHoaDonDV);
            groupBoxPD1.Controls.Add(lblMaHoaDonDV);
            groupBoxPD1.Controls.Add(txtMaHopDong);
            groupBoxPD1.Controls.Add(lblMaHopDong);
            groupBoxPD1.Controls.Add(txtMaPhieuDien);
            groupBoxPD1.Controls.Add(lblMaPhieuDien);
            groupBoxPD1.Dock = DockStyle.Top;
            groupBoxPD1.Location = new Point(0, 0);
            groupBoxPD1.Name = "groupBoxPD1";
            groupBoxPD1.Size = new Size(908, 277);
            groupBoxPD1.TabIndex = 13;
            groupBoxPD1.TabStop = false;
            groupBoxPD1.Text = "GroupBoxPD1";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(161, 207);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(150, 31);
            txtDonGia.TabIndex = 15;
            // 
            // txtThangSD
            // 
            txtThangSD.Location = new Point(627, 153);
            txtThangSD.Name = "txtThangSD";
            txtThangSD.Size = new Size(150, 31);
            txtThangSD.TabIndex = 11;
            // 
            // txtCSMoi
            // 
            txtCSMoi.Location = new Point(627, 96);
            txtCSMoi.Name = "txtCSMoi";
            txtCSMoi.Size = new Size(150, 31);
            txtCSMoi.TabIndex = 9;
            // 
            // lblCSMoi
            // 
            lblCSMoi.AutoSize = true;
            lblCSMoi.Location = new Point(499, 96);
            lblCSMoi.Name = "lblCSMoi";
            lblCSMoi.Size = new Size(97, 25);
            lblCSMoi.TabIndex = 8;
            lblCSMoi.Text = "Chỉ số mới";
            // 
            // txtCSCu
            // 
            txtCSCu.Location = new Point(627, 42);
            txtCSCu.Name = "txtCSCu";
            txtCSCu.Size = new Size(150, 31);
            txtCSCu.TabIndex = 7;
            // 
            // lblCSCu
            // 
            lblCSCu.AutoSize = true;
            lblCSCu.Location = new Point(499, 42);
            lblCSCu.Name = "lblCSCu";
            lblCSCu.Size = new Size(84, 25);
            lblCSCu.TabIndex = 6;
            lblCSCu.Text = "Chỉ số cũ";
            // 
            // txtMaHoaDonDV
            // 
            txtMaHoaDonDV.Location = new Point(161, 153);
            txtMaHoaDonDV.Name = "txtMaHoaDonDV";
            txtMaHoaDonDV.Size = new Size(150, 31);
            txtMaHoaDonDV.TabIndex = 5;
            // 
            // lblMaHoaDonDV
            // 
            lblMaHoaDonDV.AutoSize = true;
            lblMaHoaDonDV.Location = new Point(33, 153);
            lblMaHoaDonDV.Name = "lblMaHoaDonDV";
            lblMaHoaDonDV.Size = new Size(114, 25);
            lblMaHoaDonDV.TabIndex = 4;
            lblMaHoaDonDV.Text = "Mã hóa đơn ";
            // 
            // txtMaHopDong
            // 
            txtMaHopDong.Location = new Point(161, 99);
            txtMaHopDong.Name = "txtMaHopDong";
            txtMaHopDong.Size = new Size(150, 31);
            txtMaHopDong.TabIndex = 3;
            // 
            // lblMaHopDong
            // 
            lblMaHopDong.AutoSize = true;
            lblMaHopDong.Location = new Point(33, 99);
            lblMaHopDong.Name = "lblMaHopDong";
            lblMaHopDong.Size = new Size(122, 25);
            lblMaHopDong.TabIndex = 2;
            lblMaHopDong.Text = "Mã hợp đồng";
            // 
            // txtMaPhieuDien
            // 
            txtMaPhieuDien.Location = new Point(161, 45);
            txtMaPhieuDien.Name = "txtMaPhieuDien";
            txtMaPhieuDien.Size = new Size(150, 31);
            txtMaPhieuDien.TabIndex = 1;
            // 
            // lblMaPhieuDien
            // 
            lblMaPhieuDien.AutoSize = true;
            lblMaPhieuDien.Location = new Point(33, 45);
            lblMaPhieuDien.Name = "lblMaPhieuDien";
            lblMaPhieuDien.Size = new Size(125, 25);
            lblMaPhieuDien.TabIndex = 0;
            lblMaPhieuDien.Text = "Mã phiếu điện";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(545, 305);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(118, 36);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(385, 305);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 36);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(221, 305);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(118, 36);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(63, 305);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(118, 36);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(724, 305);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(118, 36);
            btnReset.TabIndex = 26;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // FormPhieuDien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 650);
            Controls.Add(btnReset);
            Controls.Add(groupBoxPD2);
            Controls.Add(groupBoxPD1);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "FormPhieuDien";
            Text = "FormPhieuDien";
            Load += FormPhieuDien_Load;
            groupBoxPD2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDien).EndInit();
            groupBoxPD1.ResumeLayout(false);
            groupBoxPD1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDonGia;
        private GroupBox groupBoxPD2;
        private DataGridView dgvDien;
        private Label lblThangSD;
        private GroupBox groupBoxPD1;
        private TextBox txtDonGia;
        private TextBox txtThangSD;
        private TextBox txtCSMoi;
        private Label lblCSMoi;
        private TextBox txtCSCu;
        private Label lblCSCu;
        private TextBox txtMaHoaDonDV;
        private Label lblMaHoaDonDV;
        private TextBox txtMaHopDong;
        private Label lblMaHopDong;
        private TextBox txtMaPhieuDien;
        private Label lblMaPhieuDien;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnReset;
    }
}