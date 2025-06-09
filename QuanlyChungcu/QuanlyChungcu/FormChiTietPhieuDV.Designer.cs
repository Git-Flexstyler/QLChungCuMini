namespace QuanlyChungcu
{
    partial class FormChiTietPhieuDV
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
            dgvChiTietPhieu = new DataGridView();
            groupBoxPDV2 = new GroupBox();
            groupBoxPDV1 = new GroupBox();
            cboTenDV = new ComboBox();
            txtSoLuong = new TextBox();
            lblSoLuong = new Label();
            txtMaPhieu = new TextBox();
            lblMaPhieuSDDV = new Label();
            lblTenDV = new Label();
            btnReset = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).BeginInit();
            groupBoxPDV2.SuspendLayout();
            groupBoxPDV1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvChiTietPhieu
            // 
            dgvChiTietPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPhieu.Dock = DockStyle.Fill;
            dgvChiTietPhieu.Location = new Point(3, 27);
            dgvChiTietPhieu.Name = "dgvChiTietPhieu";
            dgvChiTietPhieu.RowHeadersWidth = 62;
            dgvChiTietPhieu.Size = new Size(902, 259);
            dgvChiTietPhieu.TabIndex = 0;
            dgvChiTietPhieu.CellClick += dgvChiTietPhieu_CellClick;
            dgvChiTietPhieu.CellContentClick += dgvChiTietPhieu_CellContentClick;
            // 
            // groupBoxPDV2
            // 
            groupBoxPDV2.Controls.Add(dgvChiTietPhieu);
            groupBoxPDV2.Dock = DockStyle.Bottom;
            groupBoxPDV2.Location = new Point(0, 361);
            groupBoxPDV2.Name = "groupBoxPDV2";
            groupBoxPDV2.Size = new Size(908, 289);
            groupBoxPDV2.TabIndex = 27;
            groupBoxPDV2.TabStop = false;
            groupBoxPDV2.Text = "GroupBoxPDV2";
            // 
            // groupBoxPDV1
            // 
            groupBoxPDV1.Controls.Add(cboTenDV);
            groupBoxPDV1.Controls.Add(txtSoLuong);
            groupBoxPDV1.Controls.Add(lblSoLuong);
            groupBoxPDV1.Controls.Add(txtMaPhieu);
            groupBoxPDV1.Controls.Add(lblMaPhieuSDDV);
            groupBoxPDV1.Controls.Add(lblTenDV);
            groupBoxPDV1.Dock = DockStyle.Top;
            groupBoxPDV1.Location = new Point(0, 0);
            groupBoxPDV1.Name = "groupBoxPDV1";
            groupBoxPDV1.Size = new Size(908, 224);
            groupBoxPDV1.TabIndex = 26;
            groupBoxPDV1.TabStop = false;
            groupBoxPDV1.Text = "GroupBoxPDV1";
            // 
            // cboTenDV
            // 
            cboTenDV.FormattingEnabled = true;
            cboTenDV.Location = new Point(250, 124);
            cboTenDV.Name = "cboTenDV";
            cboTenDV.Size = new Size(182, 33);
            cboTenDV.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(599, 73);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(150, 31);
            txtSoLuong.TabIndex = 7;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(482, 73);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(85, 25);
            lblSoLuong.TabIndex = 6;
            lblSoLuong.Text = "Số lượng";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(250, 73);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(182, 31);
            txtMaPhieu.TabIndex = 3;
            // 
            // lblMaPhieuSDDV
            // 
            lblMaPhieuSDDV.AutoSize = true;
            lblMaPhieuSDDV.Location = new Point(87, 73);
            lblMaPhieuSDDV.Name = "lblMaPhieuSDDV";
            lblMaPhieuSDDV.Size = new Size(148, 25);
            lblMaPhieuSDDV.TabIndex = 2;
            lblMaPhieuSDDV.Text = "Mã phiếu dịch vụ";
            // 
            // lblTenDV
            // 
            lblTenDV.AutoSize = true;
            lblTenDV.Location = new Point(87, 127);
            lblTenDV.Name = "lblTenDV";
            lblTenDV.Size = new Size(100, 25);
            lblTenDV.TabIndex = 0;
            lblTenDV.Text = "Tên dịch vụ";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(761, 283);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(118, 36);
            btnReset.TabIndex = 32;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(588, 283);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(118, 36);
            btnTimKiem.TabIndex = 31;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(402, 283);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 36);
            btnXoa.TabIndex = 30;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(212, 283);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(118, 36);
            btnSua.TabIndex = 29;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(37, 283);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(118, 36);
            btnThem.TabIndex = 28;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // FormChiTietPhieuDV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 650);
            Controls.Add(groupBoxPDV2);
            Controls.Add(groupBoxPDV1);
            Controls.Add(btnReset);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "FormChiTietPhieuDV";
            Text = "FormChiTietPhieuDV";
            FormClosed += FormChiTietPhieuDV_FormClosed;
            Load += FormChiTietPhieuDV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).EndInit();
            groupBoxPDV2.ResumeLayout(false);
            groupBoxPDV1.ResumeLayout(false);
            groupBoxPDV1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvChiTietPhieu;
        private GroupBox groupBoxPDV2;
        private GroupBox groupBoxPDV1;
        private TextBox txtSoLuong;
        private Label lblSoLuong;
        private TextBox txtMaPhieu;
        private Label lblMaPhieuSDDV;
        private TextBox txtMaDV;
        private Label lblTenDV;
        private Button btnReset;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboTenDV;
    }
}