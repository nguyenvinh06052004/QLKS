using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlksss
{
    public partial class frmDV : Form
    {
        DataTable tblDV = new DataTable();
        string madv_lp = "";
        bool isChanged = false;
        bool isAddingNew = false;
        bool isBoClicked = false;
        bool isDeleteClicked = false;
        bool isSaveClicked = false;
        public frmDV()
        {
            InitializeComponent();
        }



        private void BtnHienThi_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
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

            txtMaDichVu.Enabled = true;
            BtnTimKiem.Enabled = true;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = Color.White;

            BtnThem.Enabled = false;
            BtnThem.BackColor = Color.Gold;
            BtnThem.ForeColor = Color.Red;


            txtMaDichVu.Enabled = true;
            txtDonGia.Enabled = true;
            txtTenDichVu.Enabled = true;
            txtTrangThai.Enabled = true;
            txtDonViTinh.Enabled = true;
            txtSoLuong.Enabled = true;
            cboMaNhanVien.Enabled = true;

            Reset();
            txtMaDichVu.Focus();
            if (isBoClicked == true)
            {
                BtnBo_Click(sender, e);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            isDeleteClicked = true;
            BtnXoa.Enabled = false;
            BtnXoa.BackColor = Color.Gold;
            BtnXoa.ForeColor = Color.Red;
            if (txtMaDichVu.Text == "" && txtTenDichVu.Text == "" && txtTrangThai.Text == "" && txtDonGia.Text == "" && txtDonViTinh.Text == "" && txtSoLuong.Text == "" && cboMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn dịch vụ để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnXoa.Enabled = true;
                BtnXoa.BackColor = Color.SteelBlue;
                BtnXoa.ForeColor = Color.White;
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                if (tblDV.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dgvDV.CurrentRow == null)
                {
                    MessageBox.Show("Bạn phải chọn dịch vụ để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;//dung if chua chon
                }
                else
                {
                    string sql;
                    sql = "DELETE FROM Dich_vu WHERE Ma_DV = '" + txtMaDichVu.Text.Trim() + "'";
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
            if (txtMaDichVu.Text == "" && txtTenDichVu.Text == "" && txtTrangThai.Text == "" && txtDonGia.Text == "" && txtDonViTinh.Text == "" && txtSoLuong.Text == "" && cboMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn phòng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnSua.Enabled = true;
                BtnSua.BackColor = Color.SteelBlue;
                BtnSua.ForeColor = Color.White;
                return;
            }


            DialogResult result = MessageBox.Show("Bạn muốn sửa thông tin của phòng này?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                txtMaDichVu.Focus();
                if (tblDV.Rows.Count == 0) //Nếu không có dữ liệu trong DataGridView
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                txtMaDichVu.Enabled = false; // k dc sua ma nhan vien
                if (txtMaDichVu.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn dịch vụ để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaDichVu.Focus();
                    return;
                }

                if (txtTenDichVu.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenDichVu.Focus();
                    return;
                }

                if (txtTrangThai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTrangThai.Focus();
                    return;
                }

                if (txtDonGia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đơn giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDonGia.Focus();
                    return;
                }

                if (txtDonViTinh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đơn vị tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDonViTinh.Focus();
                    return;
                }

                if (txtSoLuong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoLuong.Focus();
                    return;
                }

                if (cboMaNhanVien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaNhanVien.Focus();
                    return;
                }
            }
        }

        private void BtnBo_Click(object sender, EventArgs e)
        {
            madv_lp = "";
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
            txtMaDichVu.Enabled = true;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            isSaveClicked = true;
            BtnLuu.Enabled = false;
            BtnLuu.BackColor = Color.Gold;
            BtnLuu.ForeColor = Color.Red;
            string sql;
            if (txtMaDichVu.Text == "" && txtTenDichVu.Text == "" && txtTrangThai.Text == "" && txtDonGia.Text == "" && txtDonViTinh.Text == "" && txtSoLuong.Text == "" && cboMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa có dịch vụ để lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnLuu.Enabled = true;
                BtnLuu.BackColor = Color.SteelBlue;
                BtnLuu.ForeColor = Color.White;
                return;
            }
            DialogResult r1 = MessageBox.Show("Bạn chắc chắn muốn lưu?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r1 == DialogResult.Yes)
            {
                if (txtMaDichVu.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaDichVu.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;
                    return;
                }
                if (txtTenDichVu.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập trạng thái phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenDichVu.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;
                    return;
                }

                if (txtTrangThai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập trạng thái phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTrangThai.Focus();
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

                if (txtDonViTinh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDonViTinh.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;
                    return;
                }

                if (txtSoLuong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoLuong.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;
                    return;
                }

                if (cboMaNhanVien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaNhanVien.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;
                    return;
                }

                if (isAddingNew == true)
                {
                    sql = "SELECT Ma_DV FROM Dich_vu WHERE Ma_DV = '" + txtMaDichVu.Text.Trim() + "'";
                    while (Class.Function.CheckKey(sql))
                    {
                        MessageBox.Show("Mã phòng đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaDichVu.Focus();
                        txtMaDichVu.Text = "";
                        BtnLuu.Enabled = true;
                        BtnLuu.BackColor = Color.SteelBlue;
                        BtnLuu.ForeColor = Color.White;
                        return;
                    }
                    sql = "INSERT INTO Dich_vu(Ma_DV, Ten_DV, Trangthai_DV, Don_gia, Donvi_tinh, Soluong, Ma_NV) VALUES ('" + txtMaDichVu.Text.Trim() + "',N'" + txtTenDichVu.Text.Trim() + "',N'" + txtTrangThai.Text.Trim() + "','" + txtDonGia.Text.Trim() + "',N'" + txtDonViTinh.Text.Trim() +"','" + txtSoLuong.Text.Trim() + "','" + cboMaNhanVien.SelectedValue.ToString() + "')";
                    Class.Function.RunSQL(sql);
                    madv_lp = txtMaDichVu.Text.Trim(); // Lưu mã nhân viên tạm thời
                    LoadDataGridView();
                    MessageBox.Show("Đã thêm thành công ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAddingNew = false;
                    BtnThem.Enabled = true;
                    BtnThem.BackColor = Color.SteelBlue;
                    BtnThem.ForeColor = Color.White;



                }
                if (isChanged == true)
                {
                    sql = "UPDATE Dich_vu SET Ten_DV = N'" + txtTenDichVu.Text.Trim() + "', Trangthai_DV = N'" + txtTrangThai.Text.Trim() + "', Don_gia = '" + txtDonGia.Text.Trim() +"', Donvi_tinh = '" + txtDonViTinh.Text.Trim() + "', Soluong = '" + txtSoLuong.Text.Trim() + "', Ma_NV = N'" + cboMaNhanVien.SelectedValue.ToString()+ "' WHERE Ma_DV = '" + txtMaDichVu.Text.Trim() + "'";

                    Class.Function.RunSQL(sql);
                    madv_lp = txtMaDichVu.Text.Trim(); // Lưu mã nhân viên tạm thời
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
            txtMaDichVu.Enabled = true;
            BtnTimKiem.Enabled = true;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = Color.White;
            madv_lp = "";
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            BtnTimKiem.Enabled = false;
            BtnTimKiem.BackColor = Color.Gold;
            BtnTimKiem.ForeColor = Color.Red;
            txtMaDichVu.Focus();
            if (txtMaDichVu.Text != "" && txtTenDichVu.Text != "" || txtTrangThai.Text != "" || txtDonGia.Text != "" || txtDonViTinh.Text != "" || txtSoLuong.Text != "" || cboMaNhanVien.SelectedValue.ToString() != "")
            {
                string sql;
                string where = "WHERE ";
                string sl = "SELECT * ";
                if (txtMaDichVu.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                    {
                        where += "Ma_DV LIKE '%" + txtMaDichVu.Text.Trim() + "%'";
                    }
                    else where += "AND Ma_DV LIKE '%" + txtMaDichVu.Text.Trim() + "%'";
                }
                if (txtTrangThai.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += "Trangthai_DV LIKE '%" + txtTrangThai.Text.Trim() + "%'";
                    else
                        where += " AND Trangthai_DV LIKE '%" + txtTrangThai.Text.Trim() + "%'";
                }
                if(txtTenDichVu.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += "Ten_DV LIKE '%" + txtTenDichVu.Text.Trim() + "%'";
                    else
                        where += " AND Ten_DV LIKE '%" + txtTenDichVu.Text.Trim() + "%'";
                }
                if (txtDonGia.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += "Don_gia LIKE '%" + txtDonGia.Text.Trim() + "%'";
                    else
                        where += " AND Don_gia LIKE '%" + txtDonGia.Text.Trim() + "%'";
                }
                if (txtDonViTinh.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += "Donvi_tinh LIKE '%" + txtDonViTinh.Text.Trim() + "%'";
                    else
                        where += " AND Donvi_tinh LIKE '%" + txtDonViTinh.Text.Trim() + "%'";
                }
                if (txtSoLuong.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += "Soluong LIKE '%" + txtSoLuong.Text.Trim() + "%'";
                    else
                        where += " AND Soluong LIKE '%" + txtSoLuong.Text.Trim() + "%'";
                }
                if (cboMaNhanVien.SelectedValue != null && cboMaNhanVien.SelectedValue.ToString().Trim() != "")
                {
                    if (where == "WHERE ")
                        where += " Ma_NV LIKE '%" + cboMaNhanVien.SelectedValue.ToString().Trim() + "%'";
                    else
                        where += " AND Ma_NV LIKE '%" + cboMaNhanVien.SelectedValue.ToString().Trim() + "%'";
                }

                sql = sl + " FROM Dich_vu " + where;

                DataTable dt = Class.Function.GetDataToTable(sql);
                dgvDV.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đã tìm thấy dịch vụ mà bạn tìm kiếm!", "KẾT QUẢ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dịch vụ mà bạn tìm kiếm!", "KẾT QUẢ", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                txtMaDichVu.Focus();
            }
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
        }

        private void Reset()
        {
            txtMaDichVu.Text = "";
            txtTenDichVu.Text = "";
            txtTrangThai.Text = "";
            txtDonGia.Text = "";
            txtDonViTinh.Text = "";
            txtSoLuong.Text = "";
            cboMaNhanVien.SelectedIndex = -1;
            BtnSua.Enabled = true;
            BtnSua.BackColor = Color.SteelBlue;
            BtnSua.ForeColor = Color.White;
            BtnLuu.Enabled = false;
            BtnLuu.BackColor = Color.SteelBlue;
            BtnLuu.ForeColor = Color.White;
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM Dich_vu";
            tblDV = Class.Function.GetDataToTable(sql);
            dgvDV.DataSource = tblDV;
            dgvDV.Columns[0].HeaderText = "Mã dịch vụ";
            dgvDV.Columns[1].HeaderText = "Tên dịch vụ";
            dgvDV.Columns[2].HeaderText = "Trạng thái";
            dgvDV.Columns[3].HeaderText = "Đơn giá";
            dgvDV.Columns[4].HeaderText = "Đơn vị tính";
            dgvDV.Columns[5].HeaderText = "Số lượng";
            dgvDV.Columns[6].HeaderText = "Mã nhân viên";
            dgvDV.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvDV.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho phép chỉnh sửa trực tiếp
            dgvDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDV.AllowUserToAddRows = false;
            dgvDV.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDV.AllowUserToAddRows = false;
            dgvDV.AllowUserToDeleteRows = false;
            dgvDV.ReadOnly = true;
            if (!string.IsNullOrEmpty(madv_lp))
            {
                foreach (DataGridViewRow row in dgvDV.Rows)
                {
                    if (row.IsNewRow) continue;

                    var value = row.Cells[0].Value?.ToString()?.Trim();
                    if (!string.IsNullOrEmpty(value) &&
                        value.Equals(madv_lp, StringComparison.OrdinalIgnoreCase))
                    {
                        dgvDV.ClearSelection();
                        row.Selected = true;
                        dgvDV.CurrentCell = row.Cells[0];
                        dgvDV.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }

        private void frmDV_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * FROM Nhan_vien";
            //txtMaPhong.Enabled = false;
            LoadDataGridView();
            Class.Function.FillCombo(sql, cboMaNhanVien, "Ma_NV", "Ten_NV");
            cboMaNhanVien.SelectedIndex = -1;
            Reset();
        }

        private void dgvDV_SelectionChanged(object sender, EventArgs e)
        {
            if(tblDV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                txtMaDichVu.Text = dgvDV.CurrentRow.Cells["Ma_DV"].Value.ToString();
                txtTenDichVu.Text = dgvDV.CurrentRow.Cells["Ten_DV"].Value.ToString();
                txtTrangThai.Text = dgvDV.CurrentRow.Cells["Trangthai_DV"].Value.ToString();
                txtDonGia.Text = dgvDV.CurrentRow.Cells["Don_gia"].Value.ToString();
                txtDonViTinh.Text = dgvDV.CurrentRow.Cells["Donvi_tinh"].Value.ToString();
                txtSoLuong.Text = dgvDV.CurrentRow.Cells["Soluong"].Value.ToString();
                cboMaNhanVien.Text = dgvDV.CurrentRow.Cells["Ma_NV"].Value.ToString();
            }
        }
    }
}
