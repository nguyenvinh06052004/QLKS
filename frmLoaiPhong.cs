using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS2.Class;

namespace QLKS2
{
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            try
            {
                Function.Connect();

                string sql = "SELECT * FROM Loai_phong";  
                SqlDataAdapter adapter = new SqlDataAdapter(sql, Function.con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);  
                dataGridView1.DataSource = dt;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                Function.Disconnect();  
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Function.CheckDuplicateMaLoaiPhong(txtMaLP.Text))
            {
                MessageBox.Show("Mã loại phòng đã tồn tại!");
                return;
            }

            SqlCommand cmd = new SqlCommand("sp_ThemLoaiPhong", Function.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ma_loaiphong", txtMaLP.Text);
            cmd.Parameters.AddWithValue("@SoLuong_phong", Convert.ToInt32(txtSL.Text));
            cmd.Parameters.AddWithValue("@Chat_luong", txtChatLuong.Text);
            cmd.Parameters.AddWithValue("@Don_gia", float.Parse(txtGia.Text));


            try
            {
                Function.Connect();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
            finally
            {
                Function.Disconnect();
            }
        }


        private string maLoaiPhongCu;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaLP.Text = row.Cells["Ma_loaiphong"].Value.ToString();
                txtSL.Text = row.Cells["Soluong_phong"].Value.ToString();
                txtChatLuong.Text = row.Cells["Chat_luong"].Value.ToString();
                txtGia.Text = row.Cells["Don_gia"].Value.ToString();
                maLoaiPhongCu = row.Cells["Ma_loaiphong"].Value.ToString().Trim();

            }
        }



        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {

            LoadData();


        }

        private void frmLoaiPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //frmMain frm = new frmMain();
            //frm.Show();
            Application.Exit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maMoi = txtMaLP.Text.Trim();          // mã mới người dùng nhập
            string maCu = maLoaiPhongCu.Trim();          // mã gốc đã chọn từ DataGridView

            // Nếu người dùng cố tình đổi mã loại phòng
            if (maMoi != maCu)
            {
                try
                {
                    Function.Connect();
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Loai_phong WHERE Ma_loaiphong = @MaMoi", Function.con);
                    checkCmd.Parameters.AddWithValue("@MaMoi", maMoi);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã loại phòng mới đã tồn tại. Vui lòng chọn mã khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi kiểm tra mã: " + ex.Message);
                    return;
                }
                finally
                {
                    Function.Disconnect();
                }
            }

            // Cập nhật thông tin (nếu mã hợp lệ hoặc không bị đổi)
            SqlCommand cmd = new SqlCommand("sp_SuaLoaiPhong", Function.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaCu", maCu);                  // mã cũ để tìm
            cmd.Parameters.AddWithValue("@Ma_loaiphong", maMoi);         // mã mới hoặc giữ nguyên
            cmd.Parameters.AddWithValue("@SoLuong_phong", Convert.ToInt32(txtSL.Text));
            cmd.Parameters.AddWithValue("@Chat_luong", txtChatLuong.Text);
            cmd.Parameters.AddWithValue("@Don_gia", float.Parse(txtGia.Text));

            try
            {
                Function.Connect();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
                LoadData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
            finally
            {
                Function.Disconnect();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn làm mới không?", "Xác nhận",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                txtMaLP.Clear();
                txtSL.Clear();
                txtChatLuong.Clear();
                txtGia.Clear();
                LoadData();
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f = new frmMain();
            f.ShowDialog();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM Loai_phong WHERE Ma_loaiphong LIKE N'%{txtMaLP.Text}%'";
            dataGridView1.DataSource = Function.GetDataToTable(sql);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLP.Text))
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Function.CheckDuplicateMaLoaiPhong(txtMaLP.Text))
            {
                MessageBox.Show("Mã loại phòng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("sp_XoaLoaiPhong", Function.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ma_loaiphong", txtMaLP.Text);

                try
                {
                    Function.Connect();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                    txtMaLP.Clear();
                    txtSL.Clear();
                    txtChatLuong.Clear();
                    txtGia.Clear();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Foreign Key violation
                    {
                        MessageBox.Show("Không thể xóa loại phòng này vì nó đang được sử dụng trong dữ liệu khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                }
                finally
                {
                    Function.Disconnect();
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    

        }
    }
}
