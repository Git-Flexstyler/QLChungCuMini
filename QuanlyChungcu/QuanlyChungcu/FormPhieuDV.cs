using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class FormPhieuDV : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QUANLYCHUNGCUMINI;Integrated Security=True;TrustServerCertificate=True";

        public FormPhieuDV()
        {
            InitializeComponent();
        }

        private void LoadPhieuDV()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetAllPhieuDV", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPhieuDV.DataSource = dt;

                    // Gọi hàm thêm nút "Xem" sau khi load xong
                    AddViewButtonColumn();
                }
            }
        }

        private void FormPhieuDV_Load(object sender, EventArgs e)
        {
            LoadPhieuDV();
        }
        FormChiTietPhieuDV formChiTiet = null;
        private void dgvPhieuDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemPhieuSDDV", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPhieuSDDV", txtMaPhieu.Text.Trim());
                cmd.Parameters.AddWithValue("@NgaySD", dtpNgaySD.Value.Date);
                cmd.Parameters.AddWithValue("@MaHoaDonDV", txtMaHoaDon.Text.Trim());
                cmd.Parameters.AddWithValue("@MaHopDong", txtMaHopDong.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm phiếu sử dụng dịch vụ thành công!");
                LoadPhieuDV();
                ResetForm();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaPhieuSDDV", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPhieuSDDV", txtMaPhieu.Text.Trim());
                cmd.Parameters.AddWithValue("@NgaySD", dtpNgaySD.Value.Date);
                cmd.Parameters.AddWithValue("@MaHoaDonDV", txtMaHoaDon.Text.Trim());
                cmd.Parameters.AddWithValue("@MaHopDong", txtMaHopDong.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật phiếu sử dụng dịch vụ thành công!");
                LoadPhieuDV();
                ResetForm();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn mã phiếu cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_XoaPhieuSDDV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuSDDV", txtMaPhieu.Text.Trim());

                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                            LoadPhieuDV();       // 👉 TẢI LẠI DỮ LIỆU
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phiếu để xóa.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimKiemPhieuSDDV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Keyword", txtMaPhieu.Text.Trim());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvPhieuDV.DataSource = dt;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadPhieuDV();
        }
        private void ResetForm()
        {
            txtMaPhieu.Clear();
            txtMaHoaDon.Clear();
            txtMaHopDong.Clear();
            dtpNgaySD.Value = DateTime.Today;
        }
        private void AddViewButtonColumn()
        {
            if (!dgvPhieuDV.Columns.Contains("Xem"))
            {
                DataGridViewButtonColumn btnXem = new DataGridViewButtonColumn();
                btnXem.Name = "Xem";
                btnXem.HeaderText = "Chi tiết";
                btnXem.Text = "Xem";
                btnXem.UseColumnTextForButtonValue = true;
                dgvPhieuDV.Columns.Add(btnXem);
            }
        }

        private void dgvPhieuDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo chỉ số dòng và cột hợp lệ
            if (e.RowIndex >= 0 && e.RowIndex < dgvPhieuDV.Rows.Count &&
                e.ColumnIndex >= 0 && e.ColumnIndex < dgvPhieuDV.Columns.Count)
            {
                DataGridViewRow row = dgvPhieuDV.Rows[e.RowIndex];

                if (dgvPhieuDV.Columns[e.ColumnIndex].Name == "Xem")
                {
                    string maPhieu = row.Cells["MaPhieuSDDV"].Value?.ToString();
                    if (!string.IsNullOrEmpty(maPhieu))
                    {
                        if (formChiTiet == null || formChiTiet.IsDisposed)
                        {
                            formChiTiet = new FormChiTietPhieuDV(maPhieu, LoadPhieuDV); // truyền callback LoadPhieuDV

                            formChiTiet.StartPosition = FormStartPosition.Manual;
                            formChiTiet.Location = new Point(this.Right, this.Top);
                            formChiTiet.Owner = this;

                            formChiTiet.FormClosed += (s, args) =>
                            {
                                LoadPhieuDV();
                                formChiTiet = null;  // giải phóng biến khi form đóng
                            };

                            formChiTiet.Show();
                        }
                        else
                        {
                            formChiTiet.Focus();
                        }

                    }
                }
                else
                {
                    // Gán thông tin phiếu vào các TextBox
                    txtMaPhieu.Text = row.Cells["MaPhieuSDDV"].Value?.ToString();
                    txtMaHoaDon.Text = row.Cells["MaHoaDonDV"].Value?.ToString();
                    txtMaHopDong.Text = row.Cells["MaHopDong"].Value?.ToString();

                    if (DateTime.TryParse(row.Cells["NgaySD"].Value?.ToString(), out DateTime ngaySD))
                    {
                        dtpNgaySD.Value = ngaySD;
                    }
                }
            }
        }
    }
}
