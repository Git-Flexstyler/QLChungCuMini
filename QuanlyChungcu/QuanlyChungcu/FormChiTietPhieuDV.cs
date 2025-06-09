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
    public partial class FormChiTietPhieuDV : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QUANLYCHUNGCUMINI;Integrated Security=True;TrustServerCertificate=True";
        private string maPhieu;
        private Action reloadParentCallback;

        public FormChiTietPhieuDV(string maPhieu, Action reloadCallback)
        {
            InitializeComponent();
            this.maPhieu = maPhieu;
            this.reloadParentCallback = reloadCallback;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormChiTietPhieuDV_Load(object sender, EventArgs e)
        {
            txtMaPhieu.Text = maPhieu;
            txtMaPhieu.ReadOnly = true;

            LoadDichVuToComboBox();
            LoadChiTietPhieu(); // Tải dữ liệu chi tiết dựa vào mã phiếu
        }
        private void LoadDichVuToComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TenDichVu FROM DichVu", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                cboTenDV.Items.Clear();
                while (reader.Read())
                {
                    cboTenDV.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
        }
        private void LoadChiTietPhieu()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Lấy dữ liệu chi tiết
                SqlCommand cmd = new SqlCommand("sp_GetChiTietPhieuDV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieuSDDV", maPhieu);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvChiTietPhieu.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemChiTietPhieuDV_Ten", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieuSDDV", txtMaPhieu.Text.Trim());
                cmd.Parameters.AddWithValue("@TenDichVu", cboTenDV.Text.Trim());
                cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text));
                cmd.ExecuteNonQuery();
                LoadChiTietPhieu();
                reloadParentCallback?.Invoke();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaChiTietPhieuDV_Ten", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieuSDDV", txtMaPhieu.Text.Trim());
                cmd.Parameters.AddWithValue("@TenDichVu", cboTenDV.Text.Trim());
                cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text));
                cmd.ExecuteNonQuery();
                LoadChiTietPhieu();
                reloadParentCallback?.Invoke();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaChiTietPhieuDV_Ten", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieuSDDV", txtMaPhieu.Text.Trim());
                cmd.Parameters.AddWithValue("@TenDichVu", cboTenDV.Text.Trim());
                cmd.ExecuteNonQuery();
                LoadChiTietPhieu();
                reloadParentCallback?.Invoke();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimKiemChiTietPhieuDV_Ten", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieuSDDV", txtMaPhieu.Text.Trim());
                cmd.Parameters.AddWithValue("@TenDichVu", cboTenDV.Text.Trim());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvChiTietPhieu.DataSource = dt;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboTenDV.SelectedIndex = -1;
            txtSoLuong.Text = "";
        }

        private void dgvChiTietPhieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvChiTietPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTietPhieu.Rows[e.RowIndex];

                txtMaPhieu.Text = row.Cells["MaPhieuSDDV"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();

                // Gán MaDV tương ứng để combo hiển thị đúng TenDV
                string maDV = row.Cells["MaDV"].Value.ToString();
                cboTenDV.SelectedValue = maDV;
            }
        }

        private void FormChiTietPhieuDV_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
