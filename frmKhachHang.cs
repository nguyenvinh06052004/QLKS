using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS2.Class;

namespace QLKS2
{
    public partial class frmKhachHang : Form
    {
        private void LoadData()
        {
            DataTable dt = Function.GetDataToTable("SELECT * FROM Khach_Hang");
            dataGridView1.DataSource = dt;
        }

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();

                txtMaKH.ReadOnly = true;
            }
        }



        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (sdt.Length != 10 || !Regex.IsMatch(sdt, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải đúng 10 chữ số.");
                return;
            }

            try
            {
                string maKH = Function.AddCustomerAuto(tenKH, sdt, diaChi);
                if (!string.IsNullOrEmpty(maKH))
                {
                    MessageBox.Show($"Thêm thành công! Mã khách hàng: {maKH}");
                    LoadData(); // Load lại DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại chỉ được nhập tối đa 10 chữ số.");
                txtSDT.Text = txtSDT.Text.Substring(0, 10);
                txtSDT.SelectionStart = txtSDT.Text.Length; // Đưa con trỏ về cuối
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            try
            {
                Function.Connect(); // mở kết nối, dùng static SqlConnection trong Function

                using (SqlCommand cmd = new SqlCommand("sp_SuaKhachHang", Function.con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Ma_KH", maKH);
                    cmd.Parameters.AddWithValue("@Ten_KH", tenKH);
                    cmd.Parameters.AddWithValue("@SDT_KH", sdt);
                    cmd.Parameters.AddWithValue("@DiaChi_KH", diaChi);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int result = reader.GetInt32(0);
                            string message = reader.GetString(1);

                            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK,
                                result == 1 ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                            if (result == 1)
                            {
                                LoadData();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Function.Disconnect(); // đóng kết nối
            }
        }


       private void btnXoa_Click(object sender, EventArgs e)
{
    string maKH = txtMaKH.Text.Trim(); // Lấy mã KH từ TextBox, loại bỏ khoảng trắng thừa

    if (string.IsNullOrEmpty(maKH))
    {
        MessageBox.Show("Vui lòng nhập mã khách hàng cần xóa!");
        return;
    }

    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

    if (result == DialogResult.Yes)
    {
        if (Function.DeleteCustomer(maKH))
        {
            MessageBox.Show("Xóa khách hàng thành công!");

            // Gợi ý: Gọi lại hàm load dữ liệu để cập nhật bảng hiển thị
            LoadData(); // <-- Hàm này bạn cần định nghĩa để load lại DataGridView
        }
        else
        {
            MessageBox.Show("Xóa khách hàng thất bại hoặc mã khách hàng không tồn tại!");
        }
    }
}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn làm mới không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f= new frmMain();
            f.ShowDialog();
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            SqlParameter[] pr = {
        new SqlParameter("@keyword", keyword)
    };

            dataGridView1.DataSource = Function.GetDataUsingStoredProc("sp_TimKiemKhachHang", pr);
        }


    }
}
