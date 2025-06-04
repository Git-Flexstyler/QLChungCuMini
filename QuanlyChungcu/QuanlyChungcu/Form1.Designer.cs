//using DataConnect;

namespace QuanlyChungcu
{
    partial class Form1
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
        /// 
        //DataConnect.DataConnect conn;
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel3 = new Panel();
            qlTPhong = new Button();
            panel4 = new Panel();
            KhachHang = new Button();
            panel5 = new Panel();
            Phòng = new Button();
            panel6 = new Panel();
            HopDong = new Button();
            menuTPhong = new FlowLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuThietBi = new FlowLayoutPanel();
            panel2 = new Panel();
            qlThietBi = new Button();
            panel7 = new Panel();
            ThietBi = new Button();
            panel8 = new Panel();
            PhieuPhat = new Button();
            menuDichVu = new FlowLayoutPanel();
            panel9 = new Panel();
            qlDichVu = new Button();
            panel10 = new Panel();
            DichVu = new Button();
            panel11 = new Panel();
            PhieuDichVu = new Button();
            panel12 = new Panel();
            PhieuDien = new Button();
            panel13 = new Panel();
            PhieuNuoc = new Button();
            menuHoaDon = new FlowLayoutPanel();
            panel14 = new Panel();
            qlHoaDon = new Button();
            panel15 = new Panel();
            HoaDonTPhong = new Button();
            panel16 = new Panel();
            HoaDonDV = new Button();
            menuBaoCao = new FlowLayoutPanel();
            panel18 = new Panel();
            BaoCao = new Button();
            panel19 = new Panel();
            DoanhThu = new Button();
            panel20 = new Panel();
            ThongKe = new Button();
            panel17 = new Panel();
            inBaoCao = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            panelMain = new Panel();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            menuTPhong.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            menuThietBi.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            menuDichVu.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            menuHoaDon.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            menuBaoCao.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel17.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 68);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(qlTPhong);
            panel3.Location = new Point(4, 4);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 79);
            panel3.TabIndex = 2;
            // 
            // qlTPhong
            // 
            qlTPhong.Location = new Point(19, 18);
            qlTPhong.Margin = new Padding(4);
            qlTPhong.Name = "qlTPhong";
            qlTPhong.Size = new Size(209, 36);
            qlTPhong.TabIndex = 3;
            qlTPhong.Text = "Quản lý thuê phòng";
            qlTPhong.UseVisualStyleBackColor = true;
            qlTPhong.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(KhachHang);
            panel4.Location = new Point(4, 91);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(248, 79);
            panel4.TabIndex = 3;
            // 
            // KhachHang
            // 
            KhachHang.Location = new Point(26, 20);
            KhachHang.Margin = new Padding(4);
            KhachHang.Name = "KhachHang";
            KhachHang.Size = new Size(201, 36);
            KhachHang.TabIndex = 3;
            KhachHang.Text = "Khách hàng";
            KhachHang.UseVisualStyleBackColor = true;
            KhachHang.Click += KhachHang_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(Phòng);
            panel5.Location = new Point(4, 178);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(248, 79);
            panel5.TabIndex = 4;
            // 
            // Phòng
            // 
            Phòng.Location = new Point(26, 20);
            Phòng.Margin = new Padding(4);
            Phòng.Name = "Phòng";
            Phòng.Size = new Size(201, 36);
            Phòng.TabIndex = 3;
            Phòng.Text = "Phòng";
            Phòng.UseVisualStyleBackColor = true;
            Phòng.Click += Phòng_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(HopDong);
            panel6.Location = new Point(4, 265);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(248, 79);
            panel6.TabIndex = 4;
            // 
            // HopDong
            // 
            HopDong.Location = new Point(26, 20);
            HopDong.Margin = new Padding(4);
            HopDong.Name = "HopDong";
            HopDong.Size = new Size(201, 36);
            HopDong.TabIndex = 3;
            HopDong.Text = "Hợp Đồng";
            HopDong.UseVisualStyleBackColor = true;
            HopDong.Click += HopDong_Click;
            // 
            // menuTPhong
            // 
            menuTPhong.Controls.Add(panel3);
            menuTPhong.Controls.Add(panel4);
            menuTPhong.Controls.Add(panel5);
            menuTPhong.Controls.Add(panel6);
            menuTPhong.Location = new Point(4, 4);
            menuTPhong.Margin = new Padding(4);
            menuTPhong.Name = "menuTPhong";
            menuTPhong.Size = new Size(255, 86);
            menuTPhong.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Interval = 5;
            timer1.Tick += timer1_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(menuTPhong);
            flowLayoutPanel1.Controls.Add(menuThietBi);
            flowLayoutPanel1.Controls.Add(menuDichVu);
            flowLayoutPanel1.Controls.Add(menuHoaDon);
            flowLayoutPanel1.Controls.Add(menuBaoCao);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 68);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(288, 843);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // menuThietBi
            // 
            menuThietBi.Controls.Add(panel2);
            menuThietBi.Controls.Add(panel7);
            menuThietBi.Controls.Add(panel8);
            menuThietBi.Location = new Point(4, 98);
            menuThietBi.Margin = new Padding(4);
            menuThietBi.Name = "menuThietBi";
            menuThietBi.Size = new Size(255, 86);
            menuThietBi.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(qlThietBi);
            panel2.Location = new Point(4, 4);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 79);
            panel2.TabIndex = 2;
            // 
            // qlThietBi
            // 
            qlThietBi.Location = new Point(19, 18);
            qlThietBi.Margin = new Padding(4);
            qlThietBi.Name = "qlThietBi";
            qlThietBi.Size = new Size(209, 36);
            qlThietBi.TabIndex = 3;
            qlThietBi.Text = "Quản lý thiết bị";
            qlThietBi.UseVisualStyleBackColor = true;
            qlThietBi.Click += QlThietBi_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(ThietBi);
            panel7.Location = new Point(4, 91);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(248, 79);
            panel7.TabIndex = 3;
            // 
            // ThietBi
            // 
            ThietBi.Location = new Point(26, 20);
            ThietBi.Margin = new Padding(4);
            ThietBi.Name = "ThietBi";
            ThietBi.Size = new Size(201, 36);
            ThietBi.TabIndex = 3;
            ThietBi.Text = "Thiết bị";
            ThietBi.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(PhieuPhat);
            panel8.Location = new Point(4, 178);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(248, 79);
            panel8.TabIndex = 4;
            // 
            // PhieuPhat
            // 
            PhieuPhat.Location = new Point(26, 20);
            PhieuPhat.Margin = new Padding(4);
            PhieuPhat.Name = "PhieuPhat";
            PhieuPhat.Size = new Size(201, 36);
            PhieuPhat.TabIndex = 3;
            PhieuPhat.Text = "Phiếu Phạt";
            PhieuPhat.UseVisualStyleBackColor = true;
            // 
            // menuDichVu
            // 
            menuDichVu.Controls.Add(panel9);
            menuDichVu.Controls.Add(panel10);
            menuDichVu.Controls.Add(panel11);
            menuDichVu.Controls.Add(panel12);
            menuDichVu.Controls.Add(panel13);
            menuDichVu.Location = new Point(4, 192);
            menuDichVu.Margin = new Padding(4);
            menuDichVu.Name = "menuDichVu";
            menuDichVu.Size = new Size(255, 432);
            menuDichVu.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.Controls.Add(qlDichVu);
            panel9.Location = new Point(4, 4);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(248, 79);
            panel9.TabIndex = 2;
            // 
            // qlDichVu
            // 
            qlDichVu.Location = new Point(19, 18);
            qlDichVu.Margin = new Padding(4);
            qlDichVu.Name = "qlDichVu";
            qlDichVu.Size = new Size(209, 36);
            qlDichVu.TabIndex = 3;
            qlDichVu.Text = "Quản lý dịch vụ";
            qlDichVu.UseVisualStyleBackColor = true;
            qlDichVu.Click += qlDichVu_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(DichVu);
            panel10.Location = new Point(4, 91);
            panel10.Margin = new Padding(4);
            panel10.Name = "panel10";
            panel10.Size = new Size(248, 79);
            panel10.TabIndex = 3;
            // 
            // DichVu
            // 
            DichVu.Location = new Point(26, 20);
            DichVu.Margin = new Padding(4);
            DichVu.Name = "DichVu";
            DichVu.Size = new Size(201, 36);
            DichVu.TabIndex = 3;
            DichVu.Text = "Dịch Vụ";
            DichVu.UseVisualStyleBackColor = true;
            DichVu.Click += DichVu_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(PhieuDichVu);
            panel11.Location = new Point(4, 178);
            panel11.Margin = new Padding(4);
            panel11.Name = "panel11";
            panel11.Size = new Size(248, 79);
            panel11.TabIndex = 4;
            // 
            // PhieuDichVu
            // 
            PhieuDichVu.Location = new Point(26, 20);
            PhieuDichVu.Margin = new Padding(4);
            PhieuDichVu.Name = "PhieuDichVu";
            PhieuDichVu.Size = new Size(201, 36);
            PhieuDichVu.TabIndex = 3;
            PhieuDichVu.Text = "Phiếu dịch vụ";
            PhieuDichVu.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(PhieuDien);
            panel12.Location = new Point(4, 265);
            panel12.Margin = new Padding(4);
            panel12.Name = "panel12";
            panel12.Size = new Size(248, 79);
            panel12.TabIndex = 4;
            // 
            // PhieuDien
            // 
            PhieuDien.Location = new Point(26, 20);
            PhieuDien.Margin = new Padding(4);
            PhieuDien.Name = "PhieuDien";
            PhieuDien.Size = new Size(201, 36);
            PhieuDien.TabIndex = 3;
            PhieuDien.Text = "Phiếu điện";
            PhieuDien.UseVisualStyleBackColor = true;
            PhieuDien.Click += PhieuDien_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(PhieuNuoc);
            panel13.Location = new Point(4, 352);
            panel13.Margin = new Padding(4);
            panel13.Name = "panel13";
            panel13.Size = new Size(248, 79);
            panel13.TabIndex = 9;
            // 
            // PhieuNuoc
            // 
            PhieuNuoc.Location = new Point(26, 20);
            PhieuNuoc.Margin = new Padding(4);
            PhieuNuoc.Name = "PhieuNuoc";
            PhieuNuoc.Size = new Size(201, 36);
            PhieuNuoc.TabIndex = 3;
            PhieuNuoc.Text = "Phiếu nước";
            PhieuNuoc.UseVisualStyleBackColor = true;
            PhieuNuoc.Click += PhieuNuoc_Click;
            // 
            // menuHoaDon
            // 
            menuHoaDon.Controls.Add(panel14);
            menuHoaDon.Controls.Add(panel15);
            menuHoaDon.Controls.Add(panel16);
            menuHoaDon.Location = new Point(4, 632);
            menuHoaDon.Margin = new Padding(4);
            menuHoaDon.Name = "menuHoaDon";
            menuHoaDon.Size = new Size(255, 86);
            menuHoaDon.TabIndex = 9;
            // 
            // panel14
            // 
            panel14.Controls.Add(qlHoaDon);
            panel14.Location = new Point(4, 4);
            panel14.Margin = new Padding(4);
            panel14.Name = "panel14";
            panel14.Size = new Size(248, 79);
            panel14.TabIndex = 2;
            // 
            // qlHoaDon
            // 
            qlHoaDon.Location = new Point(19, 18);
            qlHoaDon.Margin = new Padding(4);
            qlHoaDon.Name = "qlHoaDon";
            qlHoaDon.Size = new Size(209, 36);
            qlHoaDon.TabIndex = 3;
            qlHoaDon.Text = "Quản lý hóa đơn";
            qlHoaDon.UseVisualStyleBackColor = true;
            qlHoaDon.Click += qlHoaDon_Click;
            // 
            // panel15
            // 
            panel15.Controls.Add(HoaDonTPhong);
            panel15.Location = new Point(4, 91);
            panel15.Margin = new Padding(4);
            panel15.Name = "panel15";
            panel15.Size = new Size(248, 79);
            panel15.TabIndex = 3;
            // 
            // HoaDonTPhong
            // 
            HoaDonTPhong.Location = new Point(26, 20);
            HoaDonTPhong.Margin = new Padding(4);
            HoaDonTPhong.Name = "HoaDonTPhong";
            HoaDonTPhong.Size = new Size(201, 36);
            HoaDonTPhong.TabIndex = 3;
            HoaDonTPhong.Text = "Hóa đơn thuê phòng";
            HoaDonTPhong.UseVisualStyleBackColor = true;
            HoaDonTPhong.Click += HoaDonTPhong_Click;
            // 
            // panel16
            // 
            panel16.Controls.Add(HoaDonDV);
            panel16.Location = new Point(4, 178);
            panel16.Margin = new Padding(4);
            panel16.Name = "panel16";
            panel16.Size = new Size(248, 79);
            panel16.TabIndex = 4;
            // 
            // HoaDonDV
            // 
            HoaDonDV.Location = new Point(26, 20);
            HoaDonDV.Margin = new Padding(4);
            HoaDonDV.Name = "HoaDonDV";
            HoaDonDV.Size = new Size(201, 36);
            HoaDonDV.TabIndex = 3;
            HoaDonDV.Text = "Hóa đơn dịch vụ";
            HoaDonDV.UseVisualStyleBackColor = true;
            HoaDonDV.Click += HoaDonDV_Click;
            // 
            // menuBaoCao
            // 
            menuBaoCao.Controls.Add(panel18);
            menuBaoCao.Controls.Add(panel19);
            menuBaoCao.Controls.Add(panel20);
            menuBaoCao.Controls.Add(panel17);
            menuBaoCao.Location = new Point(4, 726);
            menuBaoCao.Margin = new Padding(4);
            menuBaoCao.Name = "menuBaoCao";
            menuBaoCao.Size = new Size(255, 86);
            menuBaoCao.TabIndex = 10;
            // 
            // panel18
            // 
            panel18.Controls.Add(BaoCao);
            panel18.Location = new Point(4, 4);
            panel18.Margin = new Padding(4);
            panel18.Name = "panel18";
            panel18.Size = new Size(248, 79);
            panel18.TabIndex = 2;
            // 
            // BaoCao
            // 
            BaoCao.Location = new Point(19, 18);
            BaoCao.Margin = new Padding(4);
            BaoCao.Name = "BaoCao";
            BaoCao.Size = new Size(209, 36);
            BaoCao.TabIndex = 3;
            BaoCao.Text = "Báo cáo";
            BaoCao.UseVisualStyleBackColor = true;
            BaoCao.Click += BaoCao_Click;
            // 
            // panel19
            // 
            panel19.Controls.Add(DoanhThu);
            panel19.Location = new Point(4, 91);
            panel19.Margin = new Padding(4);
            panel19.Name = "panel19";
            panel19.Size = new Size(248, 79);
            panel19.TabIndex = 3;
            // 
            // DoanhThu
            // 
            DoanhThu.Location = new Point(26, 20);
            DoanhThu.Margin = new Padding(4);
            DoanhThu.Name = "DoanhThu";
            DoanhThu.Size = new Size(201, 36);
            DoanhThu.TabIndex = 3;
            DoanhThu.Text = "DoanhThu";
            DoanhThu.UseVisualStyleBackColor = true;
            // 
            // panel20
            // 
            panel20.Controls.Add(ThongKe);
            panel20.Location = new Point(4, 178);
            panel20.Margin = new Padding(4);
            panel20.Name = "panel20";
            panel20.Size = new Size(248, 79);
            panel20.TabIndex = 4;
            // 
            // ThongKe
            // 
            ThongKe.Location = new Point(26, 20);
            ThongKe.Margin = new Padding(4);
            ThongKe.Name = "ThongKe";
            ThongKe.Size = new Size(201, 36);
            ThongKe.TabIndex = 3;
            ThongKe.Text = "Thống kê";
            ThongKe.UseVisualStyleBackColor = true;
            // 
            // panel17
            // 
            panel17.Controls.Add(inBaoCao);
            panel17.Location = new Point(4, 265);
            panel17.Margin = new Padding(4);
            panel17.Name = "panel17";
            panel17.Size = new Size(248, 79);
            panel17.TabIndex = 4;
            // 
            // inBaoCao
            // 
            inBaoCao.Location = new Point(26, 20);
            inBaoCao.Margin = new Padding(4);
            inBaoCao.Name = "inBaoCao";
            inBaoCao.Size = new Size(201, 36);
            inBaoCao.TabIndex = 3;
            inBaoCao.Text = "In báo cáo";
            inBaoCao.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            timer2.Interval = 5;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 5;
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Interval = 5;
            timer4.Tick += timer4_Tick;
            // 
            // timer5
            // 
            timer5.Interval = 5;
            timer5.Tick += timer5_Tick;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(288, 68);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(841, 843);
            panelMain.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 911);
            Controls.Add(panelMain);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            menuTPhong.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            menuThietBi.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            menuDichVu.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            menuHoaDon.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            menuBaoCao.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel17.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button qlTPhong;
        private Panel panel4;
        private Button KhachHang;
        private Panel panel5;
        private Button Phòng;
        private Panel panel6;
        private Button HopDong;
        private FlowLayoutPanel menuTPhong;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel menuThietBi;
        private Panel panel2;
        private Button qlThietBi;
        private Panel panel7;
        private Button ThietBi;
        private Panel panel8;
        private Button PhieuPhat;
        private System.Windows.Forms.Timer timer2;
        private FlowLayoutPanel menuDichVu;
        private Panel panel9;
        private Button qlDichVu;
        private Panel panel10;
        private Button DichVu;
        private Panel panel11;
        private Button PhieuDichVu;
        private Panel panel12;
        private Button PhieuDien;
        private Panel panel13;
        private Button PhieuNuoc;
        private System.Windows.Forms.Timer timer3;
        private FlowLayoutPanel menuHoaDon;
        private Panel panel14;
        private Button qlHoaDon;
        private Panel panel15;
        private Button HoaDonTPhong;
        private Panel panel16;
        private Button HoaDonDV;
        private Panel panel17;
        private Button inBaoCao;
        private FlowLayoutPanel menuBaoCao;
        private Panel panel18;
        private Button BaoCao;
        private Panel panel19;
        private Button DoanhThu;
        private Panel panel20;
        private Button ThongKe;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private Panel panelMain;
    }
}
