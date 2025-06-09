namespace QuanlyChungcu
{
    partial class FormPhieuNuoc
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
            groupBoxPN2 = new GroupBox();
            dgvNuoc = new DataGridView();
            lblThangSD = new Label();
            groupBoxPN1 = new GroupBox();
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
            txtMaPhieuNuoc = new TextBox();
            lblMaPhieuNuoc = new Label();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnReset = new Button();
            groupBoxPN2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNuoc).BeginInit();
            groupBoxPN1.SuspendLayout();
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
            // groupBoxPN2
            // 
            groupBoxPN2.Controls.Add(dgvNuoc);
            groupBoxPN2.Dock = DockStyle.Bottom;
            groupBoxPN2.Location = new Point(0, 361);
            groupBoxPN2.Name = "groupBoxPN2";
            groupBoxPN2.Size = new Size(908, 289);
            groupBoxPN2.TabIndex = 14;
            groupBoxPN2.TabStop = false;
            groupBoxPN2.Text = "GroupBoxPN2";
            // 
            // dgvNuoc
            // 
            dgvNuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNuoc.Dock = DockStyle.Fill;
            dgvNuoc.Location = new Point(3, 27);
            dgvNuoc.Name = "dgvNuoc";
            dgvNuoc.RowHeadersWidth = 62;
            dgvNuoc.Size = new Size(902, 259);
            dgvNuoc.TabIndex = 0;
            dgvNuoc.CellClick += dgvNuoc_CellClick;
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
            // groupBoxPN1
            // 
            groupBoxPN1.Controls.Add(txtDonGia);
            groupBoxPN1.Controls.Add(lblDonGia);
            groupBoxPN1.Controls.Add(txtThangSD);
            groupBoxPN1.Controls.Add(lblThangSD);
            groupBoxPN1.Controls.Add(txtCSMoi);
            groupBoxPN1.Controls.Add(lblCSMoi);
            groupBoxPN1.Controls.Add(txtCSCu);
            groupBoxPN1.Controls.Add(lblCSCu);
            groupBoxPN1.Controls.Add(txtMaHoaDonDV);
            groupBoxPN1.Controls.Add(lblMaHoaDonDV);
            groupBoxPN1.Controls.Add(txtMaHopDong);
            groupBoxPN1.Controls.Add(lblMaHopDong);
            groupBoxPN1.Controls.Add(txtMaPhieuNuoc);
            groupBoxPN1.Controls.Add(lblMaPhieuNuoc);
            groupBoxPN1.Dock = DockStyle.Top;
            groupBoxPN1.Location = new Point(0, 0);
            groupBoxPN1.Name = "groupBoxPN1";
            groupBoxPN1.Size = new Size(908, 277);
            groupBoxPN1.TabIndex = 13;
            groupBoxPN1.TabStop = false;
            groupBoxPN1.Text = "GroupBoxPN1";
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
            // txtMaPhieuNuoc
            // 
            txtMaPhieuNuoc.Location = new Point(161, 45);
            txtMaPhieuNuoc.Name = "txtMaPhieuNuoc";
            txtMaPhieuNuoc.Size = new Size(150, 31);
            txtMaPhieuNuoc.TabIndex = 1;
            // 
            // lblMaPhieuNuoc
            // 
            lblMaPhieuNuoc.AutoSize = true;
            lblMaPhieuNuoc.Location = new Point(33, 45);
            lblMaPhieuNuoc.Name = "lblMaPhieuNuoc";
            lblMaPhieuNuoc.Size = new Size(125, 25);
            lblMaPhieuNuoc.TabIndex = 0;
            lblMaPhieuNuoc.Text = "Mã phiếu điện";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(563, 305);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(118, 36);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(395, 305);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 36);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(232, 305);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(118, 36);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(59, 305);
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
            // FormPhieuNuoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 650);
            Controls.Add(btnReset);
            Controls.Add(groupBoxPN2);
            Controls.Add(groupBoxPN1);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "FormPhieuNuoc";
            Text = "FormPhieuNuoc";
            Load += FormPhieuNuoc_Load;
            groupBoxPN2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNuoc).EndInit();
            groupBoxPN1.ResumeLayout(false);
            groupBoxPN1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDonGia;
        private GroupBox groupBoxPN2;
        private DataGridView dgvNuoc;
        private Label lblThangSD;
        private GroupBox groupBoxPN1;
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
        private TextBox txtMaPhieuNuoc;
        private Label lblMaPhieuNuoc;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnReset;
    }
}