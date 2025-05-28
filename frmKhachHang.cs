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

    public partial class frmKhachHang : Form
    {
        DataTable tblKH = new DataTable();
        string makh_td = "";
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblKH.Rows.Count == 0) //Nếu không có dữ liệu trong DataGridView
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKH.Text = dgvKH.CurrentRow.Cells["Ma_KH"].Value.ToString(); //Lấy giá trị ô hiện tại
            txtTenKH.Text = dgvKH.CurrentRow.Cells["Ten_KH"].Value.ToString();
            txtSDT.Text = dgvKH.CurrentRow.Cells["SDT_KH"].Value.ToString();
            txtDiaChi.Text = dgvKH.CurrentRow.Cells["DiaChi_KH"].Value.ToString();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM Khach_Hang";
            tblKH = Class.Function.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            dgvKH.DataSource = tblKH; //Gán dữ liệu cho DataGridView
            dgvKH.Columns[0].HeaderText = "Mã khách hàng"; //Tên cột
            dgvKH.Columns[1].HeaderText = "Tên khách hàng"; //Tên cột
            dgvKH.Columns[2].HeaderText = "Số điện thoại "; //Tên cột
            dgvKH.Columns[3].HeaderText = "Địa chỉ"; //Tên cột
            dgvKH.AllowUserToAddRows = false; // cho phép thêm dòng mới
            dgvKH.AllowUserToDeleteRows = false;
            dgvKH.ReadOnly = true;
            if (!string.IsNullOrEmpty(makh_td))
            {
                foreach (DataGridViewRow row in dgvKH.Rows)
                {
                    if (row.IsNewRow) continue;

                    var value = row.Cells[0].Value?.ToString()?.Trim();
                    if (!string.IsNullOrEmpty(value) &&
                        value.Equals(makh_td, StringComparison.OrdinalIgnoreCase))
                    {
                        dgvKH.ClearSelection();
                        row.Selected = true;
                        dgvKH.CurrentCell = row.Cells[0];
                        dgvKH.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        bool isAddingNew = false;
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

            txtMaKH.Enabled = true;
            BtnTimKiem.Enabled = true;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = Color.White;

            BtnThem.Enabled = false;
            BtnThem.BackColor = Color.Gold;
            BtnThem.ForeColor = Color.Red;


            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;

            Reset();
            txtMaKH.Focus();
            if (isBoClicked == true)
            {
                BtnBo_Click(sender, e);
            }
        }
        public void Reset()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
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
            if (txtMaKH.Text == "" && txtTenKH.Text == "" && txtSDT.Text == "" && txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa có  khách hàng  để lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnLuu.Enabled = true;
                BtnLuu.BackColor = Color.SteelBlue;
                BtnLuu.ForeColor = Color.White;
                return;
            }
            DialogResult r1 = MessageBox.Show("Bạn chắc chắn muốn lưu?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r1 == DialogResult.Yes)
            {
                if (txtMaKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaKH.Focus();
                    BtnLuu.Enabled = true;
                    return;
                }
                if (txtTenKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenKH.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;

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
                    sql = "SELECT Ma_KH FROM Khach_Hang WHERE Ma_KH = '" + txtMaKH.Text.Trim() + "'";
                    while (Class.Function.CheckKey(sql))
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaKH.Focus();
                        txtMaKH.Text = "";
                        BtnLuu.Enabled = true;
                        BtnLuu.BackColor = Color.SteelBlue;
                        BtnLuu.ForeColor = Color.White;
                        return;
                    }
                    sql = "INSERT INTO Khach_Hang(Ma_KH, Ten_KH,  SDT_KH, DiaChi_KH) VALUES ('" + txtMaKH.Text.Trim() + "',N'" + txtTenKH.Text.Trim() + "','" + txtSDT.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "')";
                    Class.Function.RunSQL(sql);
                    makh_td = txtMaKH.Text.Trim(); // Lưu mã nhân viên tạm thời
                    LoadDataGridView();
                    MessageBox.Show("Đã thêm thành công ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAddingNew = false;
                    BtnThem.Enabled = true;
                    BtnThem.BackColor = Color.SteelBlue;
                    BtnThem.ForeColor = Color.White;



                }
                if (isChanged == true)
                {
                    sql = "UPDATE Khach_Hang SET Ten_KH = N'" + txtTenKH.Text.Trim() + "', SDT_KH = '" + txtSDT.Text.Trim() + "', DiaChi_KH = N'" + txtDiaChi.Text.Trim() + "' WHERE Ma_KH = '" + txtMaKH.Text.Trim() + "'";

                    Class.Function.RunSQL(sql);
                    makh_td = txtMaKH.Text.Trim(); // Lưu mã nhân viên tạm thời
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
            txtMaKH.Enabled = true;
            BtnTimKiem.Enabled = true;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = Color.White;
            makh_td = "";


        }

        private void dgvKH_SelectionChanged(object sender, EventArgs e)
        {
            if (tblKH.Rows.Count == 0) //Nếu không có dữ liệu trong DataGridView
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKH.Text = dgvKH.CurrentRow.Cells["Ma_KH"].Value.ToString(); //Lấy giá trị ô hiện tại
            txtTenKH.Text = dgvKH.CurrentRow.Cells["Ten_KH"].Value.ToString();
            txtSDT.Text = dgvKH.CurrentRow.Cells["SDT_KH"].Value.ToString();
            txtDiaChi.Text = dgvKH.CurrentRow.Cells["DiaChi_KH"].Value.ToString();

        }
        private void BtnSua_Click(object sender, EventArgs e)
        {
            isChanged = true;
            BtnSua.Enabled = false;
            BtnSua.BackColor = Color.Gold;
            BtnSua.ForeColor = Color.Red;
            if (txtMaKH.Text == "" && txtTenKH.Text == "" && txtSDT.Text == "" && txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnSua.Enabled = true;
                BtnSua.BackColor = Color.SteelBlue;
                BtnSua.ForeColor = Color.White;
                return;
            }


            DialogResult result = MessageBox.Show("Bạn muốn sửa thông tin của khách hàng này?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                txtTenKH.Focus();
                if (tblKH.Rows.Count == 0) //Nếu không có dữ liệu trong DataGridView
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                txtMaKH.Enabled = false; // k dc sua ma nhan vien
                if (txtMaKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn khách hàng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaKH.Focus();
                    return;
                }
                if (txtTenKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenKH.Focus();
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
            makh_td = "";
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
            txtMaKH.Enabled = true;
        }

        bool isDeleteClicked = false;
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            isDeleteClicked = true;
            BtnXoa.Enabled = false;
            BtnXoa.BackColor = Color.Gold;
            BtnXoa.ForeColor = Color.Red;
            if (txtMaKH.Text == "" && txtTenKH.Text == "" && txtSDT.Text == "" && txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnXoa.Enabled = true;
                BtnXoa.BackColor = Color.SteelBlue;
                BtnXoa.ForeColor = Color.White;
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                if (tblKH.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dgvKH.CurrentRow == null)
                {
                    MessageBox.Show("Bạn phải chọn khách hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;//dung if chua chon
                }
                else
                {
                    string sql;
                    sql = "DELETE FROM Khach_Hang WHERE Ma_KH = '" + txtMaKH.Text.Trim() + "'";
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
            txtMaKH.Focus();
            if (txtMaKH.Text.Trim() != "" || txtTenKH.Text.Trim() != "" || txtSDT.Text.Trim() != "" || txtDiaChi.Text.Trim() != "")
            {

                string sql;
                string where = "WHERE ";
                string sl = "SELECT * ";
                if (txtMaKH.Text.Trim() != "")
                {

                    if (where == "WHERE ")
                    {
                        where += "Ma_KH = '" + txtMaKH.Text.Trim() + "'";
                    }
                    else where += "AND Ma_KH = '" + txtMaKH.Text.Trim() + "'";
                }
                if (txtTenKH.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += "Ten_KH = N'" + txtTenKH.Text.Trim() + "'";
                    else
                        where += " AND Ten_KH = N'" + txtTenKH.Text.Trim() + "'";
                }
                if (txtSDT.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += " SDT_KH = '" + txtSDT.Text.Trim() + "'";
                    else
                        where += " AND SDT_KH = '" + txtSDT.Text.Trim() + "'";
                }
                if (txtDiaChi.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += " DiaChi_KH = '" + txtDiaChi.Text + "'";
                    else
                        where += " AND DiaChi_KH = '" + txtDiaChi.Text + "'";
                }
                sql = sl + " FROM Khach_Hang " + where;

                DataTable dt = Class.Function.GetDataToTable(sql);
                dgvKH.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đã tìm thấy khách hàng bạn tìm kiếm!", "KẾT QUẢ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng bạn tìm kiếm!", "KẾT QUẢ", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                txtMaKH.Focus();
            }
        }

        private void BtnLuu_Click_1(object sender, EventArgs e)

        {
            isSaveClicked = true;
            BtnLuu.Enabled = false;
            BtnLuu.BackColor = Color.Gold;
            BtnLuu.ForeColor = Color.Red;
            string sql;
            if (txtMaKH.Text == "" && txtTenKH.Text == "" && txtSDT.Text == "" && txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa có  khách hàng  để lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnLuu.Enabled = true;
                BtnLuu.BackColor = Color.SteelBlue;
                BtnLuu.ForeColor = Color.White;
                return;
            }
            DialogResult r1 = MessageBox.Show("Bạn chắc chắn muốn lưu?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r1 == DialogResult.Yes)
            {
                if (txtMaKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaKH.Focus();
                    BtnLuu.Enabled = true;
                    return;
                }
                if (txtTenKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenKH.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;

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
                    sql = "SELECT Ma_KH FROM Khach_Hang WHERE Ma_KH = '" + txtMaKH.Text.Trim() + "'";
                    while (Class.Function.CheckKey(sql))
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaKH.Focus();
                        txtMaKH.Text = "";
                        BtnLuu.Enabled = true;
                        BtnLuu.BackColor = Color.SteelBlue;
                        BtnLuu.ForeColor = Color.White;
                        return;
                    }
                    sql = "INSERT INTO Khach_Hang(Ma_KH, Ten_KH,  SDT_KH, DiaChi_KH) VALUES ('" + txtMaKH.Text.Trim() + "',N'" + txtTenKH.Text.Trim() + "','" + txtSDT.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "')";
                    Class.Function.RunSQL(sql);
                    makh_td = txtMaKH.Text.Trim(); // Lưu mã nhân viên tạm thời
                    LoadDataGridView();
                    MessageBox.Show("Đã thêm thành công ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAddingNew = false;
                    BtnThem.Enabled = true;
                    BtnThem.BackColor = Color.SteelBlue;
                    BtnThem.ForeColor = Color.White;



                }
                if (isChanged == true)
                {
                    sql = "UPDATE Khach_Hang SET Ten_KH = N'" + txtTenKH.Text.Trim() + "', SDT_KH = '" + txtSDT.Text.Trim() + "', DiaChi_KH = N'" + txtDiaChi.Text.Trim() + "' WHERE Ma_KH = '" + txtMaKH.Text.Trim() + "'";

                    Class.Function.RunSQL(sql);
                    makh_td = txtMaKH.Text.Trim(); // Lưu mã nhân viên tạm thời
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
            txtMaKH.Enabled = true;
            BtnTimKiem.Enabled = true;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = Color.White;
            makh_td = "";


        }

        private void BtnSua_Click_1(object sender, EventArgs e)
        {
            isChanged = true;
            BtnSua.Enabled = false;
            BtnSua.BackColor = Color.Gold;
            BtnSua.ForeColor = Color.Red;
            if (txtMaKH.Text == "" && txtTenKH.Text == "" && txtSDT.Text == "" && txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnSua.Enabled = true;
                BtnSua.BackColor = Color.SteelBlue;
                BtnSua.ForeColor = Color.White;
                return;
            }


            DialogResult result = MessageBox.Show("Bạn muốn sửa thông tin của khách hàng này?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                txtTenKH.Focus();
                if (tblKH.Rows.Count == 0) //Nếu không có dữ liệu trong DataGridView
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                txtMaKH.Enabled = false; // k dc sua ma nhan vien
                if (txtMaKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn khách hàng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaKH.Focus();
                    return;
                }
                if (txtTenKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenKH.Focus();
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

        private void BtnBo_Click_1(object sender, EventArgs e)
        {
            makh_td = "";
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
            txtMaKH.Enabled = true;
        }

        private void BtnXoa_Click_1(object sender, EventArgs e)
        {
            isDeleteClicked = true;
            BtnXoa.Enabled = false;
            BtnXoa.BackColor = Color.Gold;
            BtnXoa.ForeColor = Color.Red;
            if (txtMaKH.Text == "" && txtTenKH.Text == "" && txtSDT.Text == "" && txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnXoa.Enabled = true;
                BtnXoa.BackColor = Color.SteelBlue;
                BtnXoa.ForeColor = Color.White;
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                if (tblKH.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dgvKH.CurrentRow == null)
                {
                    MessageBox.Show("Bạn phải chọn khách hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;//dung if chua chon
                }
                else
                {
                    string sql;
                    sql = "DELETE FROM Khach_Hang WHERE Ma_KH = '" + txtMaKH.Text.Trim() + "'";
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

        private void BtnTimKiem_Click_1(object sender, EventArgs e)

        {
            BtnTimKiem.Enabled = false;
            BtnTimKiem.BackColor = Color.Gold;
            BtnTimKiem.ForeColor = Color.Red;
            txtMaKH.Focus();
            if (txtMaKH.Text.Trim() != "" || txtTenKH.Text.Trim() != "" || txtSDT.Text.Trim() != "" || txtDiaChi.Text.Trim() != "")
            {

                string sql;
                string where = "WHERE ";
                string sl = "SELECT * ";
                if (txtMaKH.Text.Trim() != "")
                {

                    if (where == "WHERE ")
                    {
                        where += "Ma_KH = '" + txtMaKH.Text.Trim() + "'";
                    }
                    else where += "AND Ma_KH = '" + txtMaKH.Text.Trim() + "'";
                }
                if (txtTenKH.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += "Ten_KH = N'" + txtTenKH.Text.Trim() + "'";
                    else
                        where += " AND Ten_KH = N'" + txtTenKH.Text.Trim() + "'";
                }
                if (txtSDT.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += " SDT_KH = '" + txtSDT.Text.Trim() + "'";
                    else
                        where += " AND SDT_KH = '" + txtSDT.Text.Trim() + "'";
                }
                if (txtDiaChi.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += " DiaChi_KH = '" + txtDiaChi.Text + "'";
                    else
                        where += " AND DiaChi_KH = '" + txtDiaChi.Text + "'";
                }
                sql = sl + " FROM Khach_Hang " + where;

                DataTable dt = Class.Function.GetDataToTable(sql);
                dgvKH.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đã tìm thấy khách hàng bạn tìm kiếm!", "KẾT QUẢ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng bạn tìm kiếm!", "KẾT QUẢ", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                txtMaKH.Focus();
            }
        }


    }
}