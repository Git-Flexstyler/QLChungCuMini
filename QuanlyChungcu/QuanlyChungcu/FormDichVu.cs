using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace QuanlyChungcu
{
    public partial class FormDichVu : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QUANLYCHUNGCUMINI;Integrated Security=True;TrustServerCertificate=True";

        public FormDichVu()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM DICHVU";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDichVu.DataSource = dt;
            }
        }

        private void FormDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_ThemDichVu", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaDV", txtMaDV.Text);
                cmd.Parameters.AddWithValue("@TenDV", txtTenDV.Text);
                cmd.Parameters.AddWithValue("@DonGia", float.Parse(txtDonGia.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
        }

        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtDonGia.Text, out float donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ hoặc bị trống!");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_SuaDichVu", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaDV", txtMaDV.Text);
                cmd.Parameters.AddWithValue("@TenDV", txtTenDV.Text);
                cmd.Parameters.AddWithValue("@DonGia", float.Parse(txtDonGia.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDV.Text))
            {
                MessageBox.Show("Chưa chọn mã dịch vụ cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_XoaDichVu", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDV", txtMaDV.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_TimKiemDichVu", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaDV", txtMaDV.Text);
                cmd.Parameters.AddWithValue("@TenDV", txtTenDV.Text);

                float donGia;
                if (float.TryParse(txtDonGia.Text, out donGia))
                    cmd.Parameters.AddWithValue("@DonGia", donGia);
                else
                    cmd.Parameters.AddWithValue("@DonGia", -1);  // Không tìm theo giá

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDichVu.DataSource = dt;
            }
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];
                txtMaDV.Text = row.Cells["MaDV"].Value.ToString();
                txtTenDV.Text = row.Cells["TenDichVu"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtDonGia.Clear();
            txtMaDV.Focus();
        }
    }
}
