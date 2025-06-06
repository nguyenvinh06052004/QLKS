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
    public partial class frmPhieuDat : Form
    {
        DataTable tbDP = new DataTable(); // Tạo DataTable để lưu dữ liệu phiếu đặt
        string maDP = ""; // Biến để lưu mã phiếu đặt
        private Form frm; // Biến để lưu tham chiếu đến form cha
        public frmPhieuDat(Form fromGoi)
        {
            InitializeComponent();
            this.frm = fromGoi; // Gán form cha vào biến
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maDP = dgvDS.CurrentRow.Cells["Ma_phieudat"].Value.ToString().Trim(); // Lấy mã phiếu đặt từ dòng hiện tại
            frmChiTiet frmChiTiet = new frmChiTiet(this, maDP, ChiTietMode.Sua); // Tạo form chi tiết với chế độ sửa
            this.Hide(); // Ẩn form hiện tại
            frmChiTiet.Show(); // Hiển thị form chi tiết
        }

        private void dgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataGridView()
        {
            // string sql = "SELECT * FROM Phieu_datphong";
            //tbDP = Class.Function.GetDataToTable(sql);
            tbDP = Class.Function.ThuTucTraDL("LAYDSPDP");
            dgvDS.DataSource = tbDP; // Gán DataTable vào DataGridView
            dgvDS.Columns[0].HeaderText = "Mã phiếu đặt";
            dgvDS.Columns[1].HeaderText = "Ngày dự kiến trả";
            dgvDS.Columns[2].HeaderText = "Ngày đặt";
            dgvDS.Columns[3].HeaderText = "Mã nhân viên";
            dgvDS.Columns[4].HeaderText = "Mã khách hàng";
            dgvDS.AllowUserToAddRows = false; // Không cho phép người dùng thêm dòng mới
            dgvDS.AllowUserToDeleteRows = false; // Không cho phép người dùng xóa dòng
            dgvDS.ReadOnly = true; // Đặt DataGridView ở chế độ chỉ đọc
            dgvDS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDS.AllowUserToAddRows = false;
            dgvDS.EditMode = DataGridViewEditMode.EditProgrammatically;
            if (!string.IsNullOrEmpty(maDP))
            {
                foreach (DataGridViewRow row in dgvDS.Rows)
                {
                    if (row.IsNewRow) continue;

                    var value = row.Cells[0].Value?.ToString()?.Trim();
                    if (!string.IsNullOrEmpty(value) &&
                        value.Equals(maDP, StringComparison.OrdinalIgnoreCase))
                    {
                        dgvDS.ClearSelection();
                        row.Selected = true;
                        dgvDS.CurrentCell = row.Cells[0];
                        dgvDS.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }
        private void frmPhieuDat_Load(object sender, EventArgs e)
        {

            LoadDataGridView();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //int cs = 31;
        string maphieu = "";
        private void BtnThem_Click(object sender, EventArgs e)
        {
            //maphieu = "PD" + cs.ToString();
            maphieu = Class.Function.GoiHamTraVeGiaTri("SELECT dbo.ham_XuatMaPDP()").ToString();
            frmChiTiet frmChiTiet = new frmChiTiet(this, maphieu, ChiTietMode.Them);
            this.Hide();
            frmChiTiet.Show();

            //  cs++;
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Close();
        }

        private void BtnChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void frmPhieuDat_Activated(object sender, EventArgs e)
        {
            tbDP = Class.Function.ThuTucTraDL("LAYDSPDP");
            dgvDS.DataSource = tbDP;
        }
    }
}
