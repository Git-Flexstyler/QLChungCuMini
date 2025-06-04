namespace QuanlyChungcu
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
            txtChiPhi = new TextBox();
            lblChiPhi = new Label();
            txtSoLuong = new TextBox();
            lblSoLuong = new Label();
            txtMaPhieuDV = new TextBox();
            lblMaPhieuSDDV = new Label();
            txtMaDV = new TextBox();
            lblMaDV = new Label();
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
            dgvPhieuDV.Location = new Point(53, 39);
            dgvPhieuDV.Name = "dgvPhieuDV";
            dgvPhieuDV.RowHeadersWidth = 62;
            dgvPhieuDV.Size = new Size(789, 225);
            dgvPhieuDV.TabIndex = 0;
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
            groupBoxPDV1.Controls.Add(txtChiPhi);
            groupBoxPDV1.Controls.Add(lblChiPhi);
            groupBoxPDV1.Controls.Add(txtSoLuong);
            groupBoxPDV1.Controls.Add(lblSoLuong);
            groupBoxPDV1.Controls.Add(txtMaPhieuDV);
            groupBoxPDV1.Controls.Add(lblMaPhieuSDDV);
            groupBoxPDV1.Controls.Add(txtMaDV);
            groupBoxPDV1.Controls.Add(lblMaDV);
            groupBoxPDV1.Dock = DockStyle.Top;
            groupBoxPDV1.Location = new Point(0, 0);
            groupBoxPDV1.Name = "groupBoxPDV1";
            groupBoxPDV1.Size = new Size(908, 224);
            groupBoxPDV1.TabIndex = 19;
            groupBoxPDV1.TabStop = false;
            groupBoxPDV1.Text = "GroupBoxPDV1";
            // 
            // txtChiPhi
            // 
            txtChiPhi.Location = new Point(599, 127);
            txtChiPhi.Name = "txtChiPhi";
            txtChiPhi.Size = new Size(150, 31);
            txtChiPhi.TabIndex = 9;
            // 
            // lblChiPhi
            // 
            lblChiPhi.AutoSize = true;
            lblChiPhi.Location = new Point(482, 127);
            lblChiPhi.Name = "lblChiPhi";
            lblChiPhi.Size = new Size(67, 25);
            lblChiPhi.TabIndex = 8;
            lblChiPhi.Text = "Chi phí";
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
            // txtMaPhieuDV
            // 
            txtMaPhieuDV.Location = new Point(250, 73);
            txtMaPhieuDV.Name = "txtMaPhieuDV";
            txtMaPhieuDV.Size = new Size(150, 31);
            txtMaPhieuDV.TabIndex = 3;
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
            // txtMaDV
            // 
            txtMaDV.Location = new Point(250, 127);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.Size = new Size(150, 31);
            txtMaDV.TabIndex = 1;
            // 
            // lblMaDV
            // 
            lblMaDV.AutoSize = true;
            lblMaDV.Location = new Point(87, 127);
            lblMaDV.Name = "lblMaDV";
            lblMaDV.Size = new Size(99, 25);
            lblMaDV.TabIndex = 0;
            lblMaDV.Text = "Mã dịch vụ";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(588, 283);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(118, 36);
            btnTimKiem.TabIndex = 24;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(402, 283);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 36);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(212, 283);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(118, 36);
            btnSua.TabIndex = 22;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(37, 283);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(118, 36);
            btnThem.TabIndex = 21;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(761, 283);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(118, 36);
            btnReset.TabIndex = 25;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
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
        private TextBox txtChiPhi;
        private Label lblChiPhi;
        private TextBox txtSoLuong;
        private Label lblSoLuong;
        private TextBox txtMaPhieuDV;
        private Label lblMaPhieuSDDV;
        private TextBox txtMaDV;
        private Label lblMaDV;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnReset;
    }
}