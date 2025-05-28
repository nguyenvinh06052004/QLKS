using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Thêm thư viện SqlClient để sử dụng SqlConnection
using qlksss.Class;
//using Microsoft.Data.SqlClient; // Thêm thư viện SqlClient để sử dụng SqlConnection

namespace qlksss
{

    public partial class frmDMNhanVien : Form
    {
        DataTable tblNV = new DataTable();
        string manv_td = ""; // Biến toàn cục để lưu mã nhân viên tạm thời
        public frmDMNhanVien()
        {
            InitializeComponent();
        }
        private void LoadDataGridView()//SELECT ́ GIAOVIEN
        {
            string sql;
            sql = "SELECT * FROM Nhan_vien";
            tblNV = Class.Function.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            dgvNhanVien.DataSource = tblNV; //Gán dữ liệu cho DataGridView
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên"; //Tên cột
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên"; //Tên cột
            dgvNhanVien.Columns[2].HeaderText = "Chức vụ "; //Tên cột
            dgvNhanVien.Columns[3].HeaderText = "Số điện thoại"; //Tên cột
            dgvNhanVien.Columns[4].HeaderText = "Địa chỉ"; //Tên cột
            dgvNhanVien.AllowUserToAddRows = false; // cho phép thêm dòng mới
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.ReadOnly = true; 

            if (!string.IsNullOrEmpty(manv_td))
            {
                foreach (DataGridViewRow row in dgvNhanVien.Rows)
                {
                    if (row.IsNewRow) continue;

                    var value = row.Cells[0].Value?.ToString()?.Trim();
                    if (!string.IsNullOrEmpty(value) &&
                        value.Equals(manv_td, StringComparison.OrdinalIgnoreCase))
                    {
                        dgvNhanVien.ClearSelection();
                        row.Selected = true;
                        dgvNhanVien.CurrentCell = row.Cells[0];
                        dgvNhanVien.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }


        }
        private void frmDMNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblNV.Rows.Count == 0) //Nếu không có dữ liệu trong DataGridView
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNhanVien.Text = dgvNhanVien.CurrentRow.Cells["Ma_NV"].Value.ToString(); //Lấy giá trị ô hiện tại
            txtTenNhanVien.Text = dgvNhanVien.CurrentRow.Cells["Ten_NV"].Value.ToString();
            txtChucVu.Text = dgvNhanVien.CurrentRow.Cells["Chuc_vu"].Value.ToString();
            txtSDT.Text = dgvNhanVien.CurrentRow.Cells["SDT_NV"].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["DiaChi_NV"].Value.ToString();
            
        }

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

            txtMaNhanVien.Enabled = true;
            BtnTimKiem.Enabled = true;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = Color.White;

            BtnThem.Enabled = false;
            BtnThem.BackColor = Color.Gold;
            BtnThem.ForeColor = Color.Red;


            txtMaNhanVien.Enabled = true;
            txtTenNhanVien.Enabled = true;
            txtChucVu.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;

            Reset();
            txtMaNhanVien.Focus();
            if (isBoClicked == true)
            {
                BtnBo_Click(sender, e);
            }
        }
        public void Reset()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtChucVu.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }
        bool isAddingNew = false;
        private void BtnThem_Click_1(object sender, EventArgs e)
        {
            isAddingNew = true;
            //BtnSua.Enabled = true;
            //BtnXoa.Enabled = true;
            //BtnBo.Enabled = true;
            //BtnLuu.Enabled = true;
            //BtnThem.Enabled = false;

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

            txtMaNhanVien.Enabled = true;
            BtnTimKiem.Enabled = true;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = Color.White;

            BtnThem.Enabled = false;
            BtnThem.BackColor = Color.Gold;
            BtnThem.ForeColor = Color.Red;


            txtMaNhanVien.Enabled = true;
            txtTenNhanVien.Enabled = true;
            txtChucVu.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;

            Reset();
            txtMaNhanVien.Focus();
            if (isBoClicked == true)
            {
                BtnBo_Click(sender, e);
            }
        }
        bool isSaveClicked = false;
        bool isChanged = false;
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            isSaveClicked = true;
            BtnLuu.Enabled = false;
            BtnLuu.BackColor = Color.Gold;
            BtnLuu.ForeColor = Color.Red;
            string sql;
            if (txtMaNhanVien.Text == "" && txtTenNhanVien.Text == "" && txtChucVu.Text == "" && txtSDT.Text == "" && txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa có  nhân  viên để lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnLuu.Enabled = true;
                BtnLuu.BackColor = Color.SteelBlue;
                BtnLuu.ForeColor = Color.White;
                return;
            }
            DialogResult r1 = MessageBox.Show("Bạn chắc chắn muốn lưu?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r1 == DialogResult.Yes)
            {
                if (txtMaNhanVien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNhanVien.Focus();
                    BtnLuu.Enabled = true;
                    return;
                }
                if (txtTenNhanVien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenNhanVien.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;

                    return;
                }
                if (txtChucVu.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChucVu.Focus();
                    BtnLuu.Enabled = true;
                    return;
                }
                if (txtSDT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDT.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;
                    return;
                }
                if (txtDiaChi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiaChi.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;
                    return;
                }


                if (isAddingNew == true)
                {
                    sql = "SELECT Ma_NV FROM Nhan_vien WHERE Ma_NV = '" + txtMaNhanVien.Text.Trim() + "'";
                    while (Class.Function.CheckKey(sql))
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNhanVien.Focus();
                        txtMaNhanVien.Text = "";
                        BtnLuu.Enabled = true;
                        BtnLuu.BackColor = Color.SteelBlue;
                        BtnLuu.ForeColor = Color.White;
                        return;
                    }
                    sql = "INSERT INTO Nhan_vien(Ma_NV, Ten_NV, Chuc_Vu, SDT_NV, DiaChi_NV) VALUES ('" + txtMaNhanVien.Text.Trim() + "',N'" + txtTenNhanVien.Text.Trim() + "',N'" + txtChucVu.Text.Trim() + "','" + txtSDT.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "')";
                    Class.Function.RunSQL(sql);
                    manv_td = txtMaNhanVien.Text.Trim(); // Lưu mã nhân viên tạm thời
                    LoadDataGridView();
                    MessageBox.Show("Đã thêm thành công ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAddingNew = false;
                    BtnThem.Enabled = true;
                    BtnThem.BackColor = Color.SteelBlue;
                    BtnThem.ForeColor = Color.White;



                }
                if (isChanged == true)
                {
                    sql = "UPDATE Nhan_vien SET Ten_NV = N'" + txtTenNhanVien.Text.Trim() + "', Chuc_Vu = N'" + txtChucVu.Text.Trim() + "', SDT_NV = '" + txtSDT.Text.Trim() + "', DiaChi_NV = N'" + txtDiaChi.Text.Trim() + "' WHERE Ma_NV = '" + txtMaNhanVien.Text.Trim() + "'";

                    Class.Function.RunSQL(sql);
                    manv_td = txtMaNhanVien.Text.Trim(); // Lưu mã nhân viên tạm thời
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
            txtMaNhanVien.Enabled = true;
            BtnTimKiem.Enabled = true;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = Color.White;
            manv_td = "";


        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
           
            if (tblNV.Rows.Count == 0) //Nếu không có dữ liệu trong DataGridView
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNhanVien.Text = dgvNhanVien.CurrentRow.Cells["Ma_NV"].Value.ToString(); //Lấy giá trị ô hiện tại
            txtTenNhanVien.Text = dgvNhanVien.CurrentRow.Cells["Ten_NV"].Value.ToString();
            txtChucVu.Text = dgvNhanVien.CurrentRow.Cells["Chuc_vu"].Value.ToString();
            txtSDT.Text = dgvNhanVien.CurrentRow.Cells["SDT_NV"].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["DiaChi_NV"].Value.ToString();
           
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            isChanged = true;
            BtnSua.Enabled = false;
            BtnSua.BackColor = Color.Gold;
            BtnSua.ForeColor = Color.Red;
            if (txtMaNhanVien.Text == "" && txtTenNhanVien.Text == "" && txtChucVu.Text == "" && txtSDT.Text == "" && txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sinh viên để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnSua.Enabled = true;
                BtnSua.BackColor = Color.SteelBlue;
                BtnSua.ForeColor = Color.White;
                return;
            }


            DialogResult result = MessageBox.Show("Bạn muốn sửa thông tin của nhân viên này?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                txtTenNhanVien.Focus();
                if (tblNV.Rows.Count == 0) //Nếu không có dữ liệu trong DataGridView
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                txtMaNhanVien.Enabled = false; // k dc sua ma nhan vien
                if (txtMaNhanVien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn nhân viên để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNhanVien.Focus();
                    return;
                }
                //while( Class.Function.CheckKey("SELECT Ma_NV FROM Nhan_vien WHERE Ma_NV = '" + txtMaNhanVien.Text.Trim() + "'"))
                //{
                //    MessageBox.Show("Mã nhân viên đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtMaNhanVien.Focus();
                //    txtMaNhanVien.Text = "";
                //    return;
                //}  -- bên button lưu đã xử lý
                if (txtTenNhanVien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenNhanVien.Focus();
                    return;
                }
                if (txtChucVu.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChucVu.Focus();
                    return;
                }
                if (txtSDT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDT.Focus();
                    return;
                }
                if (txtDiaChi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiaChi.Focus();
                    return;
                }

            }
        }

        bool isBoClicked = false;
        private void BtnBo_Click(object sender, EventArgs e)
        {
            manv_td = "";
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
            txtMaNhanVien.Enabled = true;
        }

        bool isDeleteClicked = false;
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            isDeleteClicked = true;
            BtnXoa.Enabled = false;
            BtnXoa.BackColor = Color.Gold;
            BtnXoa.ForeColor = Color.Red;
            if (txtMaNhanVien.Text == "" && txtTenNhanVien.Text == "" && txtChucVu.Text == "" && txtSDT.Text == "" && txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnXoa.Enabled = true;
                BtnXoa.BackColor = Color.SteelBlue;
                BtnXoa.ForeColor = Color.White;
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                if (tblNV.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dgvNhanVien.CurrentRow == null)
                {
                    MessageBox.Show("Bạn phải chọn nhân viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;//dung if chua chon
                }
                else
                {
                    string sql;
                    sql = "DELETE FROM Nhan_vien WHERE Ma_NV = '" + txtMaNhanVien.Text.Trim() + "'";
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

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            BtnTimKiem.Enabled = false;
            BtnTimKiem.BackColor = Color.Gold;
            BtnTimKiem.ForeColor = Color.Red;
            txtMaNhanVien.Focus();
            if (txtMaNhanVien.Text.Trim() != "" || txtTenNhanVien.Text.Trim() != "" || txtSDT.Text.Trim() != "" || txtDiaChi.Text.Trim() != "" || txtChucVu.Text.Trim() != "")
            {

                string sql;
                string where = "WHERE ";
                string sl = "SELECT * ";
                if (txtMaNhanVien.Text.Trim() != "")
                {

                    if (where == "WHERE ")
                    {
                        where += "Ma_NV = '" + txtMaNhanVien.Text.Trim() + "'";
                    }
                    else where += "AND Ma_NV = '" + txtMaNhanVien.Text.Trim() + "'";
                }
                if (txtTenNhanVien.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += "Ten_NV = N'" + txtTenNhanVien.Text.Trim() + "'";
                    else
                        where += " AND Ten_NV = N'" + txtTenNhanVien.Text.Trim() + "'";
                }
                if (txtChucVu.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += " Chuc_vu = N'" + txtChucVu.Text.Trim() + "'";
                    else
                        where += " AND Chuc_vu = N'" + txtChucVu.Text.Trim() + "'";
                }
                if (txtSDT.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += " SDT_NV = '" + txtSDT.Text.Trim() + "'";
                    else
                        where += " AND SDT_NV = '" + txtSDT.Text.Trim() + "'";
                }
                if (txtDiaChi.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += " DiaChi_NV = '" + txtDiaChi.Text + "'";
                    else
                        where += " AND DiaChi_NV = '" + txtDiaChi.Text + "'";
                }
                sql = sl + " FROM Nhan_vien " + where;

                DataTable dt = Class.Function.GetDataToTable(sql);
                dgvNhanVien.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đã tìm thấy nhân viên bạn tìm kiếm!", "KẾT QUẢ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên bạn tìm kiếm!", "KẾT QUẢ", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                txtMaNhanVien.Focus();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
