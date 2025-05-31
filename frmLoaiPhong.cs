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
using qlksss.Class;

namespace qlksss
{
    public partial class frmLoaiPhong : Form
    {
        DataTable tblLP = new DataTable(); // Khởi tạo đối tượng DateTable để quản lý dữ liệu loại phòng
        string malp_td = ""; // Biến để lưu mã loại phòng tạm thời

        public frmLoaiPhong()
        {
            InitializeComponent();
        }


        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dgvLoaiPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiPhong.CurrentRow == null || tblLP.Rows.Count == 0) //Nếu không có dữ liệu trong DataGridView
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaLoaiPhong.Text = dgvLoaiPhong.CurrentRow.Cells["Ma_loaiphong"].Value.ToString(); //Lấy giá trị ô hiện tại
            txtSoLuongPhong.Text = dgvLoaiPhong.CurrentRow.Cells["Soluong_phong"].Value.ToString();
            txtChatLuong.Text = dgvLoaiPhong.CurrentRow.Cells["Chat_luong"].Value.ToString();
            txtDonGia.Text = dgvLoaiPhong.CurrentRow.Cells["Don_gia"].Value.ToString();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM Loai_phong";
            tblLP = Class.Function.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            dgvLoaiPhong.DataSource = tblLP; //Gán dữ liệu cho DataGridView
            dgvLoaiPhong.Columns[0].HeaderText = "Mã loại phòng"; //Tên cột
            dgvLoaiPhong.Columns[1].HeaderText = "Số lượng phòng"; //Tên cột
            dgvLoaiPhong.Columns[2].HeaderText = "Chất lượng"; //Tên cột
            dgvLoaiPhong.Columns[3].HeaderText = "Đơn giá"; //Tên cột
            dgvLoaiPhong.AllowUserToAddRows = false; // cho phép thêm dòng mới
            dgvLoaiPhong.AllowUserToDeleteRows = false;
            dgvLoaiPhong.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho phép chỉnh sửa trực tiếp trên DataGridView
            dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Tự động điều chỉnh kích thước cột
            //dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //Tự động điều chỉnh kích thước cột
            dgvLoaiPhong.ReadOnly = true;
            if (!string.IsNullOrEmpty(malp_td))
            {
                foreach (DataGridViewRow row in dgvLoaiPhong.Rows)
                {
                    if (row.IsNewRow) continue;

                    var value = row.Cells[0].Value?.ToString()?.Trim();
                    if (!string.IsNullOrEmpty(value) &&
                        value.Equals(malp_td, StringComparison.OrdinalIgnoreCase))
                    {
                        dgvLoaiPhong.ClearSelection();
                        row.Selected = true;
                        dgvLoaiPhong.CurrentCell = row.Cells[0];
                        dgvLoaiPhong.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }

        bool isAddingNew = false;
        bool isBoClicked = false;
        bool isSaveClicked = false;
        bool isChanged = false;
        bool isDeleteClicked = false;

        private void BtnThem_Click(object sender, EventArgs e)
        {
            isAddingNew = true;

            BtnBo.Enabled = true;
            BtnBo.BackColor = Color.SteelBlue;
            BtnBo.ForeColor = Color.White;
            BtnLuu.Enabled = true;
            BtnLuu.BackColor = Color.SteelBlue;
            BtnLuu.ForeColor = Color.White;
            BtnSua.Enabled = true;
            BtnSua.BackColor = Color.SteelBlue;
            BtnSua.ForeColor = Color.White;
            BtnXoa.Enabled = true;
            BtnXoa.BackColor = Color.SteelBlue;
            BtnXoa.ForeColor = Color.White;

            txtMaLoaiPhong.Enabled = true;
            BtnTimKiem.Enabled = true;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = Color.White;

            BtnThem.Enabled = false;
            BtnThem.BackColor = Color.Gold;
            BtnThem.ForeColor = Color.Red;

            txtMaLoaiPhong.Enabled = true;
            txtChatLuong.Enabled = true;
            txtDonGia.Enabled = true;
            txtSoLuongPhong.Enabled = true;

            Reset();
            txtMaLoaiPhong.Focus(); // Đặt con trỏ vào ô mã loại phòng
            if (isBoClicked == true)
            {
                BtnBo_Click(sender, e);
            }
        }

        public void Reset()
        {
            txtMaLoaiPhong.Text = "";
            txtSoLuongPhong.Text = "";
            txtDonGia.Text = "";
            txtChatLuong.Text = "";
        }


        private void BtnXoa_Click(object sender, EventArgs e)
        {
            isDeleteClicked = true;
            BtnXoa.Enabled = false;
            BtnXoa.BackColor = Color.Gold;
            BtnXoa.ForeColor = Color.Red;
            if (txtMaLoaiPhong.Text == "" && txtSoLuongPhong.Text == "" && txtDonGia.Text == "" && txtChatLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn loại phòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnXoa.Enabled = true;
                BtnXoa.BackColor = Color.SteelBlue;
                BtnXoa.ForeColor = Color.White;
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa loại phòng này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                BtnXoa.Enabled = true;
                BtnXoa.BackColor = Color.SteelBlue;
                BtnXoa.ForeColor = Color.White;
                BtnBo_Click(sender, e);
                isDeleteClicked = false;
                return;
            }
            else
            {
                if (tblLP.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dgvLoaiPhong.CurrentRow == null)
                {
                    MessageBox.Show("Bạn phải chọn loại phòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;//dung if chua chon
                }
                else
                {
                    string sql;
                    sql = "DELETE FROM Loai_phong WHERE Ma_loaiphong = '" + txtMaLoaiPhong.Text.Trim() + "'";
                    Class.Function.RunSQL(sql);
                    LoadDataGridView();
                    Reset();
                    MessageBox.Show("Đã xóa thành công ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isDeleteClicked = false;
                    BtnXoa.Enabled = true;
                    BtnXoa.BackColor = Color.SteelBlue;
                    BtnXoa.ForeColor = Color.White;
                }

            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            isChanged = true;
            BtnSua.Enabled = false;
            BtnSua.BackColor = Color.Gold;
            BtnSua.ForeColor = Color.Red;
            if (txtMaLoaiPhong.Text == "" && txtSoLuongPhong.Text == "" && txtDonGia.Text == "" && txtChatLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa có loại phòng để lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnLuu.Enabled = true;
                BtnLuu.BackColor = Color.SteelBlue;
                BtnLuu.ForeColor = Color.White;
                return;
            }


            DialogResult result = MessageBox.Show("Bạn muốn sửa thông tin của loại phòng này?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                BtnLuu.Enabled = true;
                BtnLuu.BackColor = Color.SteelBlue;
                BtnLuu.ForeColor = Color.White;
                BtnBo_Click(sender, e);
                return;
            }
            else
            {
                txtMaLoaiPhong.Focus();
                if (tblLP.Rows.Count == 0) //Nếu không có dữ liệu trong DataGridView
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                txtMaLoaiPhong.Enabled = false; // k dc sua ma nhan vien
                if (txtMaLoaiPhong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn loại phòng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaLoaiPhong.Focus();
                    return;
                }
                if (txtSoLuongPhong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số lượng phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoLuongPhong.Focus();
                    return;
                }
                if (txtDonGia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDonGia.Focus();
                    return;
                }
                if (txtChatLuong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập chất lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChatLuong.Focus();
                    return;
                }
            }
        }

        private void BtnBo_Click(object sender, EventArgs e)
        {
            malp_td = "";
            isBoClicked = true;

            Reset();
            BtnBo.Enabled = false;
            BtnBo.BackColor = Color.Gold;
            BtnBo.ForeColor = Color.Red;
            MessageBox.Show("Bạn đã hủy thao tác", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView(); // cap nhat lai ds ban dau cho datagridview
            BtnBo.Enabled = true;
            BtnBo.BackColor = Color.SteelBlue;
            BtnBo.ForeColor = Color.White;
            BtnLuu.Enabled = true;
            BtnLuu.BackColor = Color.SteelBlue;
            BtnLuu.ForeColor = Color.White;
            BtnSua.Enabled = true;
            BtnSua.BackColor = Color.SteelBlue;
            BtnSua.ForeColor = Color.White;
            BtnThem.Enabled = true;
            BtnThem.BackColor = Color.SteelBlue;
            BtnThem.ForeColor = Color.White;
            BtnXoa.Enabled = true;
            BtnXoa.BackColor = Color.SteelBlue;
            BtnXoa.ForeColor = Color.White;
            BtnTimKiem.Enabled = true;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = Color.White;
            isAddingNew = false;
            isChanged = false;
            isDeleteClicked = false;
            isSaveClicked = false;
            isBoClicked = false;
            txtMaLoaiPhong.Enabled = true;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            isSaveClicked = true;
            BtnLuu.Enabled = false;
            BtnLuu.BackColor = Color.Gold;
            BtnLuu.ForeColor = Color.Red;
            string sql;
            if (txtMaLoaiPhong.Text == "" && txtSoLuongPhong.Text == "" && txtDonGia.Text == "" && txtChatLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa có loại phòng để lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnLuu.Enabled = true;
                BtnLuu.BackColor = Color.SteelBlue;
                BtnLuu.ForeColor = Color.White;
                return;
            }
            DialogResult r1 = MessageBox.Show("Bạn chắc chắn muốn lưu?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r1 == DialogResult.Yes)
            {
                if (txtMaLoaiPhong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã loại phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaLoaiPhong.Focus();
                    BtnLuu.Enabled = true;
                    return;
                }
                if (txtSoLuongPhong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số lượng phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoLuongPhong.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;

                    return;
                }
                if (txtDonGia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDonGia.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;
                    return;
                }
                if (txtChatLuong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập chất lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChatLuong.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;
                    return;
                }


                if (isAddingNew == true)
                {
                    sql = "SELECT Ma_loaiphong FROM Loai_phong WHERE Ma_loaiphong = '" + txtMaLoaiPhong.Text.Trim() + "'";
                    while (Class.Function.CheckKey(sql))
                    {
                        MessageBox.Show("Mã loại phòng đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaLoaiPhong.Focus();
                        txtMaLoaiPhong.Text = "";
                        BtnLuu.Enabled = true;
                        BtnLuu.BackColor = Color.SteelBlue;
                        BtnLuu.ForeColor = Color.White;
                        return;
                    }
                    sql = "INSERT INTO Loai_phong(Ma_loaiphong, Soluong_phong, Chat_luong, Don_gia) VALUES ('" + txtMaLoaiPhong.Text.Trim() + "',N'" + txtSoLuongPhong.Text.Trim() + "','" + txtChatLuong.Text.Trim() + "',N'" + txtDonGia.Text.Trim() + "')";
                    Class.Function.RunSQL(sql);
                    malp_td = txtMaLoaiPhong.Text.Trim(); // Lưu mã nhân viên tạm thời
                    LoadDataGridView();
                    MessageBox.Show("Đã thêm thành công ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAddingNew = false;
                    BtnThem.Enabled = true;
                    BtnThem.BackColor = Color.SteelBlue;
                    BtnThem.ForeColor = Color.White;



                }
                if (isChanged == true)
                {
                    sql = "UPDATE Loai_phong SET Soluong_phong = N'" + txtSoLuongPhong.Text.Trim() + "', Don_gia = '" + txtDonGia.Text.Trim() + "', Chat_luong = N'" + txtChatLuong.Text.Trim() + "' WHERE Ma_loaiphong = '" + txtMaLoaiPhong.Text.Trim() + "'";

                    Class.Function.RunSQL(sql);
                    malp_td = txtMaLoaiPhong.Text.Trim(); // Lưu mã nhân viên tạm thời
                    LoadDataGridView();


                    MessageBox.Show("Đã sửa thành công ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isChanged = false;
                    BtnSua.Enabled = true;
                    BtnSua.BackColor = Color.SteelBlue;
                    BtnSua.ForeColor = Color.White;

                    Reset();

                }

            }
            else
            {
                MessageBox.Show("Bạn đã hủy thao tác lưu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            Reset();
            isSaveClicked = false;
            BtnBo.Enabled = true;
            BtnBo.BackColor = Color.SteelBlue;
            BtnBo.ForeColor = Color.White;
            BtnLuu.Enabled = true;
            BtnLuu.BackColor = Color.SteelBlue;
            BtnLuu.ForeColor = Color.White;
            BtnSua.Enabled = true;
            BtnSua.BackColor = Color.SteelBlue;
            BtnSua.ForeColor = Color.White;
            BtnThem.Enabled = true;
            BtnThem.BackColor = Color.SteelBlue;
            BtnThem.ForeColor = Color.White;
            BtnXoa.Enabled = true;
            BtnXoa.BackColor = Color.SteelBlue;
            BtnXoa.ForeColor = Color.White;
            txtMaLoaiPhong.Enabled = true;
            BtnTimKiem.Enabled = true;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = Color.White;
            malp_td = "";
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            BtnTimKiem.Enabled = false;
            BtnTimKiem.BackColor = Color.Gold;
            BtnTimKiem.ForeColor = Color.Red;
            txtMaLoaiPhong.Focus();
            if (txtMaLoaiPhong.Text.Trim() != "" || txtSoLuongPhong.Text.Trim() != "" || txtDonGia.Text.Trim() != "" || txtChatLuong.Text.Trim() != "")
            {

                string sql;
                string where = "WHERE ";
                string sl = "SELECT * ";
                if (txtMaLoaiPhong.Text.Trim() != "")
                {

                    if (where == "WHERE ")
                    {
                        where += "Ma_loaiphong = '" + txtMaLoaiPhong.Text.Trim() + "'";
                    }
                    else where += "AND Ma_loaiphong = '" + txtMaLoaiPhong.Text.Trim() + "'";
                }
                if (txtSoLuongPhong.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += "Soluong_phong = N'" + txtSoLuongPhong.Text.Trim() + "'";
                    else
                        where += " AND Soluong_phong = N'" + txtSoLuongPhong.Text.Trim() + "'";
                }
                if (txtDonGia.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += " Don_gia = '" + txtDonGia.Text.Trim() + "'";
                    else
                        where += " AND Don_gia = '" + txtDonGia.Text.Trim() + "'";
                }
                if (txtChatLuong.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += " Chat_luong = '" + txtChatLuong.Text + "'";
                    else
                        where += " AND Chat_luong = '" + txtChatLuong.Text + "'";
                }
                sql = sl + " FROM Loai_phong " + where;

                DataTable dt = Class.Function.GetDataToTable(sql);
                dgvLoaiPhong.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đã tìm thấy loại phòng bạn tìm kiếm!", "KẾT QUẢ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy loại phòng bạn tìm kiếm!", "KẾT QUẢ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                BtnTimKiem.Enabled = true;
                BtnTimKiem.BackColor = Color.SteelBlue;
                BtnTimKiem.ForeColor = Color.White;

            }
            else
            {
                MessageBox.Show("Bạn phải nhập thông tin tìm kiếm!", "YÊU CẦU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnTimKiem.Enabled = true;
                BtnTimKiem.BackColor = Color.SteelBlue;
                BtnTimKiem.ForeColor = Color.White;
                txtMaLoaiPhong.Focus();
            }
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide(); // Đóng form loại phòng và quay lại form trước đó
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
        }

        private void BtnHienThi_Click(object sender, EventArgs e)
        {
            LoadDataGridView(); // Hiển thị lại toàn bộ dữ liệu loại phòng
        }

        private void frmLoaiPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Đóng toàn bộ ứng dụng khi form loại phòng đóng   
        }
    }
}
