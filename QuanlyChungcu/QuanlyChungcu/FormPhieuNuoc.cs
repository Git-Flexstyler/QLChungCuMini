using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 

namespace QuanlyChungcu
{
    public partial class FormPhieuNuoc : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QUANLYCHUNGCUMINI;Integrated Security=True;TrustServerCertificate=True";

        public FormPhieuNuoc()
        {
            InitializeComponent();
        }

        private void LoadPhieuNuoc()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PhieuSDNUoc";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNuoc.DataSource = dt;
            }
        }

        private void FormPhieuNuoc_Load(object sender, EventArgs e)
        {
            LoadPhieuNuoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemPhieuNuoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPhieuNuoc", txtMaPhieuNuoc.Text);
                cmd.Parameters.AddWithValue("@CSCu", float.Parse(txtCSCu.Text));
                cmd.Parameters.AddWithValue("@CSMoi", float.Parse(txtCSMoi.Text));
                cmd.Parameters.AddWithValue("@DonGia", float.Parse(txtDonGia.Text));
                cmd.Parameters.AddWithValue("@ThangSD", DateTime.Parse(txtThangSD.Text));
                cmd.Parameters.AddWithValue("@MaHoaDonDV", txtMaHoaDonDV.Text);
                cmd.Parameters.AddWithValue("@MaHopDong", txtMaHopDong.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadPhieuNuoc();
                MessageBox.Show("Đã thêm phiếu nước.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_SuaPhieuNuoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPhieuNuoc", txtMaPhieuNuoc.Text);
                cmd.Parameters.AddWithValue("@CSCu", float.Parse(txtCSCu.Text));
                cmd.Parameters.AddWithValue("@CSMoi", float.Parse(txtCSMoi.Text));
                cmd.Parameters.AddWithValue("@DonGia", float.Parse(txtDonGia.Text));
                cmd.Parameters.AddWithValue("@ThangSD", DateTime.Parse(txtThangSD.Text));
                cmd.Parameters.AddWithValue("@MaHoaDonDV", txtMaHoaDonDV.Text);
                cmd.Parameters.AddWithValue("@MaHopDong", txtMaHopDong.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadPhieuNuoc();
                MessageBox.Show("Đã cập nhật phiếu nước.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_XoaPhieuNuoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPhieuNuoc", txtMaPhieuNuoc.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadPhieuNuoc();
                MessageBox.Show("Đã xóa phiếu nước.");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_TimKiemPhieuNuoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TuKhoa", txtMaPhieuNuoc.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNuoc.DataSource = dt;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaPhieuNuoc.Clear();
            txtMaHopDong.Clear();
            txtMaHoaDonDV.Clear();
            txtCSCu.Clear();
            txtCSMoi.Clear();
            txtDonGia.Clear();
            txtThangSD.Clear();
            LoadPhieuNuoc();
        }

        private void dgvNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // tránh trường hợp click vào header
            {
                DataGridViewRow row = dgvNuoc.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cell và đổ vào textbox tương ứng
                txtMaPhieuNuoc.Text = row.Cells["MaPhieuSDNuoc"].Value?.ToString();
                txtMaHopDong.Text = row.Cells["MaHopDong"].Value?.ToString();
                txtMaHoaDonDV.Text = row.Cells["MaHoaDonDV"].Value?.ToString();
                txtCSCu.Text = row.Cells["CSCu"].Value?.ToString();
                txtCSMoi.Text = row.Cells["CSMoi"].Value?.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value?.ToString();

                // Với trường ngày tháng, convert sang string định dạng yyyy-MM-dd hoặc phù hợp
                if (row.Cells["ThangSD"].Value != DBNull.Value)
                {
                    DateTime thangSD = Convert.ToDateTime(row.Cells["ThangSD"].Value);
                    txtThangSD.Text = thangSD.ToString("yyyy-MM-dd");
                }
                else
                {
                    txtThangSD.Clear();
                }
            }
        }
    }
}
