namespace QuanlyChungcu
{
    partial class FormDichVu
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
            groupBoxDV1 = new GroupBox();
            txtDonGia = new TextBox();
            lblDonGia = new Label();
            txtTenDV = new TextBox();
            lblTenDV = new Label();
            txtMaDV = new TextBox();
            lblMaDV = new Label();
            groupBoxDV2 = new GroupBox();
            dgvDichVu = new DataGridView();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnReset = new Button();
            groupBoxDV1.SuspendLayout();
            groupBoxDV2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).BeginInit();
            SuspendLayout();
            // 
            // groupBoxDV1
            // 
            groupBoxDV1.Controls.Add(txtDonGia);
            groupBoxDV1.Controls.Add(lblDonGia);
            groupBoxDV1.Controls.Add(txtTenDV);
            groupBoxDV1.Controls.Add(lblTenDV);
            groupBoxDV1.Controls.Add(txtMaDV);
            groupBoxDV1.Controls.Add(lblMaDV);
            groupBoxDV1.Dock = DockStyle.Top;
            groupBoxDV1.Location = new Point(0, 0);
            groupBoxDV1.Name = "groupBoxDV1";
            groupBoxDV1.Size = new Size(908, 224);
            groupBoxDV1.TabIndex = 7;
            groupBoxDV1.TabStop = false;
            groupBoxDV1.Text = "GroupBoxDV1";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(168, 153);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(150, 31);
            txtDonGia.TabIndex = 5;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(51, 153);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(75, 25);
            lblDonGia.TabIndex = 4;
            lblDonGia.Text = "Đơn giá";
            // 
            // txtTenDV
            // 
            txtTenDV.Location = new Point(168, 99);
            txtTenDV.Name = "txtTenDV";
            txtTenDV.Size = new Size(150, 31);
            txtTenDV.TabIndex = 3;
            // 
            // lblTenDV
            // 
            lblTenDV.AutoSize = true;
            lblTenDV.Location = new Point(51, 99);
            lblTenDV.Name = "lblTenDV";
            lblTenDV.Size = new Size(100, 25);
            lblTenDV.TabIndex = 2;
            lblTenDV.Text = "Tên dịch vụ";
            // 
            // txtMaDV
            // 
            txtMaDV.Location = new Point(168, 45);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.Size = new Size(150, 31);
            txtMaDV.TabIndex = 1;
            // 
            // lblMaDV
            // 
            lblMaDV.AutoSize = true;
            lblMaDV.Location = new Point(51, 45);
            lblMaDV.Name = "lblMaDV";
            lblMaDV.Size = new Size(99, 25);
            lblMaDV.TabIndex = 0;
            lblMaDV.Text = "Mã dịch vụ";
            // 
            // groupBoxDV2
            // 
            groupBoxDV2.Controls.Add(dgvDichVu);
            groupBoxDV2.Dock = DockStyle.Bottom;
            groupBoxDV2.Location = new Point(0, 361);
            groupBoxDV2.Name = "groupBoxDV2";
            groupBoxDV2.Size = new Size(908, 289);
            groupBoxDV2.TabIndex = 8;
            groupBoxDV2.TabStop = false;
            groupBoxDV2.Text = "GroupBoxDV2";
            // 
            // dgvDichVu
            // 
            dgvDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDichVu.Location = new Point(53, 39);
            dgvDichVu.Name = "dgvDichVu";
            dgvDichVu.RowHeadersWidth = 62;
            dgvDichVu.Size = new Size(789, 225);
            dgvDichVu.TabIndex = 0;
            dgvDichVu.CellClick += dgvDichVu_CellClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(560, 283);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(118, 36);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(385, 283);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 36);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(200, 283);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(118, 36);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(32, 283);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(118, 36);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(724, 283);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(118, 36);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // FormDichVu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 650);
            Controls.Add(btnReset);
            Controls.Add(groupBoxDV1);
            Controls.Add(groupBoxDV2);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "FormDichVu";
            Text = "FormDichVu";
            Load += FormDichVu_Load;
            groupBoxDV1.ResumeLayout(false);
            groupBoxDV1.PerformLayout();
            groupBoxDV2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDV1;
        private TextBox txtDonGia;
        private Label lblDonGia;
        private TextBox txtTenDV;
        private Label lblTenDV;
        private TextBox txtMaDV;
        private Label lblMaDV;
        private GroupBox groupBoxDV2;
        private DataGridView dgvDichVu;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnReset;
    }
}