﻿namespace QuanlyChungcu
{
    partial class FormPhieuDV
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
            dgvPhieuDV = new DataGridView();
            groupBoxPDV2 = new GroupBox();
            groupBoxPDV1 = new GroupBox();
            dtpNgaySD = new DateTimePicker();
            txtMaHopDong = new TextBox();
            lblMaHopDong = new Label();
            lblNgaySD = new Label();
            txtMaPhieu = new TextBox();
            lblMaPhieuSDDV = new Label();
            txtMaHoaDon = new TextBox();
            lblMaHoaDon = new Label();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuDV).BeginInit();
            groupBoxPDV2.SuspendLayout();
            groupBoxPDV1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPhieuDV
            // 
            dgvPhieuDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuDV.Dock = DockStyle.Fill;
            dgvPhieuDV.Location = new Point(3, 27);
            dgvPhieuDV.Name = "dgvPhieuDV";
            dgvPhieuDV.RowHeadersWidth = 62;
            dgvPhieuDV.Size = new Size(902, 259);
            dgvPhieuDV.TabIndex = 0;
            dgvPhieuDV.CellClick += dgvPhieuDV_CellClick;
            dgvPhieuDV.CellContentClick += dgvPhieuDV_CellContentClick;
            // 
            // groupBoxPDV2
            // 
            groupBoxPDV2.Controls.Add(dgvPhieuDV);
            groupBoxPDV2.Dock = DockStyle.Bottom;
            groupBoxPDV2.Location = new Point(0, 361);
            groupBoxPDV2.Name = "groupBoxPDV2";
            groupBoxPDV2.Size = new Size(908, 289);
            groupBoxPDV2.TabIndex = 20;
            groupBoxPDV2.TabStop = false;
            groupBoxPDV2.Text = "GroupBoxPDV2";
            // 
            // groupBoxPDV1
            // 
            groupBoxPDV1.Controls.Add(dtpNgaySD);
            groupBoxPDV1.Controls.Add(txtMaHopDong);
            groupBoxPDV1.Controls.Add(lblMaHopDong);
            groupBoxPDV1.Controls.Add(lblNgaySD);
            groupBoxPDV1.Controls.Add(txtMaPhieu);
            groupBoxPDV1.Controls.Add(lblMaPhieuSDDV);
            groupBoxPDV1.Controls.Add(txtMaHoaDon);
            groupBoxPDV1.Controls.Add(lblMaHoaDon);
            groupBoxPDV1.Dock = DockStyle.Top;
            groupBoxPDV1.Location = new Point(0, 0);
            groupBoxPDV1.Name = "groupBoxPDV1";
            groupBoxPDV1.Size = new Size(908, 243);
            groupBoxPDV1.TabIndex = 19;
            groupBoxPDV1.TabStop = false;
            groupBoxPDV1.Text = "GroupBoxPDV1";
            // 
            // dtpNgaySD
            // 
            dtpNgaySD.Location = new Point(596, 73);
            dtpNgaySD.Name = "dtpNgaySD";
            dtpNgaySD.Size = new Size(300, 31);
            dtpNgaySD.TabIndex = 12;
            // 
            // txtMaHopDong
            // 
            txtMaHopDong.AcceptsReturn = true;
            txtMaHopDong.Location = new Point(250, 180);
            txtMaHopDong.Name = "txtMaHopDong";
            txtMaHopDong.Size = new Size(150, 31);
            txtMaHopDong.TabIndex = 11;
            // 
            // lblMaHopDong
            // 
            lblMaHopDong.AutoSize = true;
            lblMaHopDong.Location = new Point(87, 180);
            lblMaHopDong.Name = "lblMaHopDong";
            lblMaHopDong.Size = new Size(122, 25);
            lblMaHopDong.TabIndex = 10;
            lblMaHopDong.Text = "Mã hợp đồng";
            // 
            // lblNgaySD
            // 
            lblNgaySD.AutoSize = true;
            lblNgaySD.Location = new Point(465, 73);
            lblNgaySD.Name = "lblNgaySD";
            lblNgaySD.Size = new Size(125, 25);
            lblNgaySD.TabIndex = 6;
            lblNgaySD.Text = "Ngày sử dụng";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(250, 73);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(150, 31);
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
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(250, 127);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(150, 31);
            txtMaHoaDon.TabIndex = 1;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Location = new Point(87, 127);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(138, 25);
            lblMaHoaDon.TabIndex = 0;
            lblMaHoaDon.Text = "Mã hóa đơn DV";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(588, 283);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(118, 36);
            btnTimKiem.TabIndex = 24;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(402, 283);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 36);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(212, 283);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(118, 36);
            btnSua.TabIndex = 22;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(37, 283);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(118, 36);
            btnThem.TabIndex = 21;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(761, 283);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(118, 36);
            btnReset.TabIndex = 25;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // FormPhieuDV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 650);
            Controls.Add(btnReset);
            Controls.Add(groupBoxPDV2);
            Controls.Add(groupBoxPDV1);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "FormPhieuDV";
            Text = "FormPhieuDV";
            Load += FormPhieuDV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhieuDV).EndInit();
            groupBoxPDV2.ResumeLayout(false);
            groupBoxPDV1.ResumeLayout(false);
            groupBoxPDV1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPhieuDV;
        private GroupBox groupBoxPDV2;
        private GroupBox groupBoxPDV1;
        private Label lblNgaySD;
        private TextBox txtMaPhieu;
        private Label lblMaPhieuSDDV;
        private TextBox txtMaHoaDon;
        private Label lblMaHoaDon;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnReset;
        private TextBox txtMaHopDong;
        private Label lblMaHopDong;
        private DateTimePicker dtpNgaySD;
    }
}