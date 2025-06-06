using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlksss.Class;

namespace qlksss
{
    public partial class frmPhong : Form
    {
        DataTable tblP;
        string map_td = "";
        public frmPhong()
        {
            InitializeComponent();
        }
        bool isChanged = false;
        private void BtnSua_Click(object sender, EventArgs e)
        {
            isChanged = true;
            BtnSua.Enabled = false;
            BtnSua.BackColor = Color.Gold;
            BtnSua.ForeColor = Color.Red;
            if (txtMaPhong.Text == "" && txtTT.Text == "" && cboMaLP.Text.Trim().Length == 0)
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
                txtMaPhong.Focus();
                if (tblP.Rows.Count == 0) //Nếu không có dữ liệu trong DataGridView
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                txtMaPhong.Enabled = false; // k dc sua ma nhan vien
                if (txtMaPhong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn phòng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPhong.Focus();
                    return;
                }

                if (txtTT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập trạng thái phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTT.Focus();
                    return;
                }

                if (cboMaLP.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập loại phòng  địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaLP.Focus();
                    return;
                }

            }
        }

        private void lable_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            string sql;
            //sql = "SELECT * FROM Loai_phong";
            LoadDataGridView();
            //Class.Function.FillCombo(sql, cboMaLP, "Ma_loaiphong", "Chat_luong");

            cboMaLP.DataSource = Function.ThuTucTraDL("LAYMALP");
            cboMaLP.DisplayMember = "Ma_loaiphong"; // Hiển thị cột Chat_luong
            cboMaLP.ValueMember = "Ma_loaiphong"; // Giá trị của cột Ma_loaiphong
            cboMaLP.SelectedIndex = -1;
            Reset();
        }
        private void Reset()
        {
            txtMaPhong.Text = "";
            txtTT.Text = "";
            cboMaLP.Text = "";
        }
        private void LoadDataGridView()
        {
            //string sql;
            //sql = "SELECT * FROM Phong";
            //tblP = Class.Function.GetDataToTable(sql);
            tblP = Class.Function.GoiHamTraVeBang("LAYDSP");
            dgvP.DataSource = tblP;
            dgvP.Columns[0].HeaderText = "Mã phòng";
            dgvP.Columns[1].HeaderText = "Trạng thái";
            dgvP.Columns[2].HeaderText = "Mã loại phòng";

            dgvP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvP.AllowUserToAddRows = false;
            dgvP.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvP.AllowUserToAddRows = false;
            dgvP.AllowUserToDeleteRows = false;
            dgvP.ReadOnly = true;
            if (!string.IsNullOrEmpty(map_td))
            {
                foreach (DataGridViewRow row in dgvP.Rows)
                {
                    if (row.IsNewRow) continue;

                    var value = row.Cells[0].Value?.ToString()?.Trim();
                    if (!string.IsNullOrEmpty(value) &&
                        value.Equals(map_td, StringComparison.OrdinalIgnoreCase))
                    {
                        dgvP.ClearSelection();
                        row.Selected = true;
                        dgvP.CurrentCell = row.Cells[0];
                        dgvP.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }

        private void dgvP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaLP;
            string sql;
            if (tblP.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaPhong.Text = dgvP.CurrentRow.Cells["Ma_phong"].Value.ToString();
            txtTT.Text = dgvP.CurrentRow.Cells["Trang_thai"].Value.ToString();
            MaLP = dgvP.CurrentRow.Cells["Ma_loaiphong"].Value.ToString();

            sql = "SELECT Ma_loaiphong FROM Loai_phong  WHERE Ma_loaiphong = N'" + MaLP + "'";
            cboMaLP.Text = Class.Function.GetFieldValues(sql);



            BtnSua.Enabled = true;
            BtnXoa.Enabled = true;
            BtnBo.Enabled = true;

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

            txtMaPhong.Enabled = true;
            BtnTimKiem.Enabled = true;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = Color.White;

            BtnThem.Enabled = false;
            BtnThem.BackColor = Color.Gold;
            BtnThem.ForeColor = Color.Red;


            txtMaPhong.Enabled = true;
            txtTT.Enabled = true;

            Reset();
            txtMaPhong.Focus();
            if (isBoClicked == true)
            {
                BtnBo_Click(sender, e);
            }
        }

        bool isSaveClicked = false;
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            isSaveClicked = true;
            BtnLuu.Enabled = false;
            BtnLuu.BackColor = Color.Gold;
            BtnLuu.ForeColor = Color.Red;
            string sql;
            string map = txtMaPhong.Text.Trim();
            if (txtMaPhong.Text == "" && txtTT.Text == "" && cboMaLP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa có phòng để lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnLuu.Enabled = true;
                BtnLuu.BackColor = Color.SteelBlue;
                BtnLuu.ForeColor = Color.White;
                return;
            }
            DialogResult r1 = MessageBox.Show("Bạn chắc chắn muốn lưu?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r1 == DialogResult.Yes)
            {
                if (txtMaPhong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPhong.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;

                    return;
                }
                if (txtTT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập trạng thái phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTT.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;

                    return;
                }

                if (cboMaLP.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập loại phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaLP.Focus();
                    BtnLuu.Enabled = true;
                    BtnLuu.BackColor = Color.SteelBlue;
                    BtnLuu.ForeColor = Color.White;
                    return;
                }


                if (isAddingNew == true)
                {
                    //sql = "SELECT Ma_phong FROM Phong WHERE Ma_phong = '" + txtMaPhong.Text.Trim() + "'";
                    var thamso = new Dictionary<string, object>
                    {
                        { "@MAP", map }
                    };
                    while (Class.Function.GoiHamTraVeGiaTri("SELECT dbo.CHECKP(@MAP)", thamso) == "1")
                    {
                        MessageBox.Show("Mã phòng đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaPhong.Focus();
                        txtMaPhong.Text = "";
                        BtnLuu.Enabled = true;
                        BtnLuu.BackColor = Color.SteelBlue;
                        BtnLuu.ForeColor = Color.White;
                        return;
                    }
                    //sql = "INSERT INTO Phong(Ma_phong, Trang_thai, Ma_loaiphong) VALUES ('" + txtMaPhong.Text.Trim() + "',N'" + txtTT.Text.Trim() + "',N'" + cboMaLP.SelectedValue.ToString() + "')";
                    //Class.Function.RunSQL(sql);
                    Function.ThuTucKhongTraDL("INSERTP", new Dictionary<string, object>
                    {
                        { "@MAP", txtMaPhong.Text.Trim() },
                        { "@TT", txtTT.Text.Trim() },
                        { "@MALP", cboMaLP.SelectedValue.ToString() }
                    });
                    map_td = txtMaPhong.Text.Trim(); // Lưu mã nhân viên tạm thời
                    LoadDataGridView();
                    MessageBox.Show("Đã thêm thành công ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAddingNew = false;
                    BtnThem.Enabled = true;
                    BtnThem.BackColor = Color.SteelBlue;
                    BtnThem.ForeColor = Color.White;



                }
                if (isChanged == true)
                {
                    //sql = "UPDATE Phong SET Trang_thai = N'" + txtTT.Text.Trim() + "', Ma_loaiphong = N'" + cboMaLP.SelectedValue.ToString() + "' WHERE Ma_phong = '" + txtMaPhong.Text.Trim() + "'";

                    //Class.Function.RunSQL(sql);
                    Function.ThuTucKhongTraDL("UPDATEP", new Dictionary<string, object>
                    {
                        { "@MP", txtMaPhong.Text.Trim() },
                        { "@TT", txtTT.Text.Trim() },
                        { "@MALP", cboMaLP.SelectedValue.ToString() }
                    });
                    map_td = txtMaPhong.Text.Trim(); // Lưu mã nhân viên tạm thời
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
            txtMaPhong.Enabled = true;
            BtnTimKiem.Enabled = true;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = Color.White;
            map_td = "";


        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {

            //LoadDataGridView();
        }
        bool isDeleteClicked = false;
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            isDeleteClicked = true;
            BtnXoa.Enabled = false;
            BtnXoa.BackColor = Color.Gold;
            BtnXoa.ForeColor = Color.Red;
            if (txtMaPhong.Text == "" && txtTT.Text == "" && cboMaLP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn phòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnXoa.Enabled = true;
                BtnXoa.BackColor = Color.SteelBlue;
                BtnXoa.ForeColor = Color.White;
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                if (tblP.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dgvP.CurrentRow == null)
                {
                    MessageBox.Show("Bạn phải chọn phòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;//dung if chua chon
                }
                else
                {
                    //string sql;
                    //sql = "DELETE FROM Phong WHERE Ma_phong = '" + txtMaPhong.Text.Trim() + "'";
                    //Class.Function.RunSQL(sql);
                    var thamso = new Dictionary<string, object>
                    {
                        { "@MAP", txtMaPhong.Text.Trim() }
                    };
                    object rs= Function.GoiHamTraVeGiaTri("SELECT dbo.KTR_SD(@MAP)", thamso);
                    if( rs != null && rs.ToString() == "1")
                    {
                        MessageBox.Show("Không thể xóa phòng này vì nó đang được sử dụng" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        BtnXoa.Enabled = true;
                        BtnXoa.BackColor = Color.SteelBlue;
                        BtnXoa.ForeColor = Color.White;
                        isDeleteClicked = false;
                        return;
                    }
                    else
                    {
                        Function.ThuTucKhongTraDL("XOAP", thamso);
                    }


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

        bool isBoClicked = false;
        private void BtnBo_Click(object sender, EventArgs e)
        {
            map_td = "";
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
            txtMaPhong.Enabled = true;
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            BtnTimKiem.Enabled = false;
            BtnTimKiem.BackColor = Color.Gold;
            BtnTimKiem.ForeColor = Color.Red;
            string maLoaiPhong = "";
            if (cboMaLP.SelectedValue != null)
            {
                maLoaiPhong = cboMaLP.SelectedValue.ToString().Trim();
            }
            //string trangThai = comboBoxTrangThai.SelectedItem != null ? comboBoxTrangThai.SelectedItem.ToString().Trim() : "";
            //MessageBox.Show("Bạn hãy nhập thông tin tìm kiếm phòng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaPhong.Focus();
            if (txtMaPhong.Text.Trim() != "" || txtTT.Text.Trim() != "" || !string.IsNullOrEmpty(maLoaiPhong))
            {
                /*
                string sql;
                string where = "WHERE ";
                string sl = "SELECT * ";
                if (txtMaPhong.Text.Trim() != "")
                {

                    if (where == "WHERE ")
                    {
                        where += "Ma_phong LIKE '%" + txtMaPhong.Text.Trim() + "%'";
                    }
                    else where += "AND Ma_phong LIKE '%" + txtMaPhong.Text.Trim() + "%'";
                }
                if (txtTT.Text.Trim() != "")
                {
                    if (where == "WHERE ")
                        where += "Trang_thai LIKE '%" + txtTT.Text.Trim() + "%'";
                    else
                        where += " AND Trang_thai LIKE '%" + txtTT.Text.Trim() + "%'";
                }
                if (cboMaLP.SelectedValue.ToString().Trim() != "")
                {
                    if (where == "WHERE ")
                        where += " Ma_loaiphong  LIKE  '%" + cboMaLP.SelectedValue.ToString().Trim() + "%'";
                    else
                        where += " AND Ma_loaiphong  LIKE  '%" + cboMaLP.SelectedValue.ToString().Trim() + "%'";
                }

                sql = sl + " FROM Phong " + where;

                */
                DataTable dt = Function.GoiHamTraVeBang("SELECT * FROM dbo.TKP(@MAP, @TT, @MALP)", new Dictionary<string, object>
                {
                    { "@MAP", txtMaPhong.Text.Trim() },
                    { "@TT", txtTT.Text.Trim() },
                    { "@MALP", maLoaiPhong }
                });
                dgvP.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đã tìm thấy phòng bạn tìm kiếm!", "KẾT QUẢ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng bạn tìm kiếm!", "KẾT QUẢ", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                txtMaPhong.Focus();
            }
        }

        private void txtMaPhong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void cboMaLP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void dgvP_SelectionChanged(object sender, EventArgs e)
        {
            if (tblP.Rows.Count == 0) //Nếu không có dữ liệu trong DataGridView
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaPhong.Text = dgvP.CurrentRow.Cells["Ma_phong"].Value.ToString(); //Lấy giá trị ô hiện tại
            txtTT.Text = dgvP.CurrentRow.Cells["Trang_thai"].Value.ToString();
            cboMaLP.SelectedValue = dgvP.CurrentRow.Cells["Ma_loaiphong"].Value.ToString();

        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
        }

        private void frmPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit(); // Đóng ứng dụng khi form Phong đóng
        }
    }


}
