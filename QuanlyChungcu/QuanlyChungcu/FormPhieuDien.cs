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
    public partial class FormPhieuDien : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QUANLYCHUNGCUMINI;Integrated Security=True;TrustServerCertificate=True";
        public FormPhieuDien()
        {
            InitializeComponent();
        }

        private void LoadPhieuDien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PHIEUSDDIEN";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDien.DataSource = dt;
            }
        }

        private void FormPhieuDien_Load(object sender, EventArgs e)
        {
            LoadPhieuDien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemPhieuDien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPhieuDien", txtMaPhieuDien.Text);
                cmd.Parameters.AddWithValue("@CSCu", float.Parse(txtCSCu.Text));
                cmd.Parameters.AddWithValue("@CSMoi", float.Parse(txtCSMoi.Text));
                cmd.Parameters.AddWithValue("@DonGia", float.Parse(txtDonGia.Text));
                cmd.Parameters.AddWithValue("@ThangSD", DateTime.Parse(txtThangSD.Text));
                cmd.Parameters.AddWithValue("@MaHoaDonDV", txtMaHoaDonDV.Text);
                cmd.Parameters.AddWithValue("@MaHopDong", txtMaHopDong.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadPhieuDien();
                MessageBox.Show("Đã thêm phiếu điện.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_SuaPhieuDien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPhieuDien", txtMaPhieuDien.Text);
                cmd.Parameters.AddWithValue("@CSCu", float.Parse(txtCSCu.Text));
                cmd.Parameters.AddWithValue("@CSMoi", float.Parse(txtCSMoi.Text));
                cmd.Parameters.AddWithValue("@DonGia", float.Parse(txtDonGia.Text));
                cmd.Parameters.AddWithValue("@ThangSD", DateTime.Parse(txtThangSD.Text));
                cmd.Parameters.AddWithValue("@MaHoaDonDV", txtMaHoaDonDV.Text);
                cmd.Parameters.AddWithValue("@MaHopDong", txtMaHopDong.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadPhieuDien();
                MessageBox.Show("Đã cập nhật phiếu điện.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_XoaPhieuDien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPhieuDien", txtMaPhieuDien.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadPhieuDien();
                MessageBox.Show("Đã xóa phiếu điện.");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_TimKiemPhieuDien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TuKhoa", txtMaPhieuDien.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDien.DataSource = dt;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaPhieuDien.Clear();
            txtMaHopDong.Clear();
            txtMaHoaDonDV.Clear();
            txtCSCu.Clear();
            txtCSMoi.Clear();
            txtDonGia.Clear();
            txtThangSD.Clear();
            LoadPhieuDien();
        }

        private void dgvDien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDien.Rows[e.RowIndex];
                txtMaPhieuDien.Text = row.Cells["MaPhieuSDDien"].Value.ToString();
                txtMaHopDong.Text = row.Cells["MaHopDong"].Value.ToString();
                txtMaHoaDonDV.Text = row.Cells["MaHoaDonDV"].Value.ToString();
                txtCSCu.Text = row.Cells["CSCu"].Value.ToString();
                txtCSMoi.Text = row.Cells["CSMoi"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtThangSD.Text = Convert.ToDateTime(row.Cells["ThangSD"].Value).ToString("yyyy-MM-dd");
                // Hoặc tùy định dạng ngày bạn muốn hiển thị
            }
        }
    }
}
