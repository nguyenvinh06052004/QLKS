using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlksss.Class;
namespace qlksss
{
    public partial class frmChiTiet : Form
    {
        DataTable tbPhongTrong = new DataTable(); // Tạo DataTable để lưu dữ liệu phòng trống
        private string maPhietDat;
        private ChiTietMode mode; // Biến để lưu chế độ chi tiết (thêm, sửa, xóa)
        public frmChiTiet(string maPhieu, ChiTietMode mode)
        {
            InitializeComponent();
            this.maPhietDat = maPhieu; // Lưu mã phiếu đặt
            this.mode = mode; // Lưu chế độ chi tiết


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void TaoCotDSPD()
        {
            dgvDSPhongDat.AutoGenerateColumns = false; // Tắt tự động tạo cột
            dgvDSPhongDat.Columns.Clear(); // Xóa tất cả các cột hiện tại

            //cot stt
            DataGridViewTextBoxColumn colSTT1 = new DataGridViewTextBoxColumn();
            //  colMaPhong.DataPropertyName = "Ma_phong"; // Tên cột trong DataTable
            colSTT1.HeaderText = "STT"; // Tiêu đề cột
            colSTT1.Name = "STT"; // Tên cột để tham chiếu
            dgvDSPhongDat.Columns.Add(colSTT1); // Thêm cột vào DataGridView

            //cot ma phong
            DataGridViewTextBoxColumn colMaPhong = new DataGridViewTextBoxColumn();
            colMaPhong.DataPropertyName = "Ma_phong"; // Tên cột trong DataTable
            colMaPhong.HeaderText = "Mã phòng"; // Tiêu đề cột
            colMaPhong.Name = "Ma_phong"; // Tên cột để tham chiếu
            dgvDSPhongDat.Columns.Add(colMaPhong); // Thêm cột vào DataGridView

            //cot gia tien
            DataGridViewTextBoxColumn colGiaTien = new DataGridViewTextBoxColumn();
            colGiaTien.DataPropertyName = "Gia_tien"; // Tên cột trong DataTable
            colGiaTien.HeaderText = "Giá tiền"; // Tiêu đề cột
            colGiaTien.Name = "Gia_tien"; // Tên cột để tham chiếu
            dgvDSPhongDat.Columns.Add(colGiaTien); // Thêm cột vào DataGridView

            //dgvDVSD
            dgvDSDVSD.AutoGenerateColumns = false; // Tắt tự động tạo cột
            dgvDSDVSD.Columns.Clear(); // Xóa tất cả các cột hiện tại

            //cot stt2
            DataGridViewTextBoxColumn colSTT2 = new DataGridViewTextBoxColumn();
            //  colMaPhong.DataPropertyName = "Ma_phong"; // Tên cột trong DataTable
            colSTT2.HeaderText = "STT"; // Tiêu đề cột
            colSTT2.Name = "STT"; // Tên cột để tham chiếu
            dgvDSDVSD.Columns.Add(colSTT2); // Thêm cột vào DataGridView

            //cot ma phong
            DataGridViewTextBoxColumn colMaPhongDV = new DataGridViewTextBoxColumn();
            colMaPhongDV.DataPropertyName = "Ma_phong"; // Tên cột trong DataTable
            colMaPhongDV.HeaderText = "Mã phòng"; // Tiêu đề cột
            colMaPhongDV.Name = "Ma_phong"; // Tên cột để tham chiếu
            dgvDSDVSD.Columns.Add(colMaPhongDV); // Thêm cột vào DataGridView

            //cot tên dv
            DataGridViewTextBoxColumn colTenDV = new DataGridViewTextBoxColumn();
            colTenDV.DataPropertyName = "Ten_DV"; // Tên cột trong DataTable
            colTenDV.HeaderText = "Tên dịch vụ"; // Tiêu đề cột
            colTenDV.Name = "Ten_DV"; // Tên cột để tham chiếu
            dgvDSDVSD.Columns.Add(colTenDV); // Thêm cột vào DataGridView

            //cot số lượng
            DataGridViewTextBoxColumn colSLDV = new DataGridViewTextBoxColumn();
            //  colMaPhong.DataPropertyName = "Ten_DV"; // Tên cột trong DataTable
            colSLDV.HeaderText = "Số lượng DV"; // Tiêu đề cột
            colSLDV.Name = "SL_DV"; // Tên cột để tham chiếu
            dgvDSDVSD.Columns.Add(colSLDV); // Thêm cột vào DataGridView

            //cột thành tiền
            DataGridViewTextBoxColumn colThanhTien = new DataGridViewTextBoxColumn();
            //  colMaPhong.DataPropertyName = "Ten_DV"; // Tên cột trong DataTable
            colThanhTien.HeaderText = "Thành tiền"; // Tiêu đề cột
            colThanhTien.Name = "ThanhTien_DV"; // Tên cột để tham chiếu
            dgvDSDVSD.Columns.Add(colThanhTien); // Thêm cột vào DataGridView


            dgvDSDVSD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDSPhongDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
        private void frmChiTiet_Load(object sender, EventArgs e)
        {
            string sqp1;
            LoaddgvDSPhongTrong();
            LoaddgvDSDV();
            TaoCotDSPD();
            string sqlnv = "SELECT Ma_NV, Ten_NV FROM Nhan_vien "; // Lấy danh sách nhân viên
            Class.Function.FillCombo(sqlnv, cboMaNV, "Ten_NV", "Ma_NV");
            cboMaNV.SelectedIndex = -1; // Đặt giá trị mặc định cho ComboBox
            string sqlkh = "SELECT Ma_KH, Ten_KH FROM Khach_Hang "; // Lấy danh sách nhân viên
            Class.Function.FillCombo(sqlkh, cboMaKH, "Ten_KH", "Ma_KH");
            cboMaKH.SelectedIndex = -1; // Đặt giá trị mặc định cho ComboBox
            Reset();
            switch (mode)
            {
                case ChiTietMode.Them:
                    {
                        txtMaPhieuDat.Text = maPhietDat; // Hiển thị mã phiếu đặt
                        txtMaPhieuDat.ReadOnly = true; // Đặt ô mã phiếu đặt ở chế độ chỉ đọc
                        cboMaNV.Focus();
                        break;
                    }
            }

        }
        private void Reset()
        {
            txtMaPhieuDat.Text = ""; // Xóa ô mã phiếu đặt
            txtThanhToan.Text = "0"; // Đặt tổng thanh toán về 0
            txtTongTienDV.Text = "0"; // Đặt tổng tiền dịch vụ về 0
            txtTongTienPhong.Text = "0"; // Đặt tổng tiền phòng về 0

            dtNgayDat.Text = DateTime.Now.ToString("dd-MM-yyyy"); // Đặt ngày dự kiến trả là ngày hiện tại
            dtNgayDuKienTra.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
        DataTable tbDV = new DataTable(); // Tạo DataTable để lưu dữ liệu dịch vụ
        private void LoaddgvDSDV()
        {
            string sql = "select Ten_DV, Don_gia, Soluong  from Dich_vu where Trangthai_DV != 'Ngung hoat dong' and Soluong > 0";
            tbDV = Class.Function.GetDataToTable(sql);
            dgvDSDV.DataSource = tbDV; // Gán DataTable vào DataGridView
            dgvDSDV.Columns[0].HeaderText = "Tên dịch vụ";
            dgvDSDV.Columns[1].HeaderText = "Đơn giá DV";
            dgvDSDV.Columns[2].HeaderText = "Số lượng DV"; // Đặt tên cột để tham chiếu
            dgvDSDV.AllowUserToAddRows = false; // Không cho phép người dùng thêm dòng mới
            dgvDSDV.AllowUserToDeleteRows = false; // Không cho phép người dùng xóa dòng
            dgvDSDV.ReadOnly = true; // Đặt DataGridView ở chế độ chỉ đọc
            dgvDSDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSDV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoaddgvDSPhongTrong()
        {
            string sql = "\r\nSELECT P.Ma_phong, LP.Gia_tien\r\nFROM Phong P, Loai_phong LP\r\nWHERE P.Ma_loaiphong = LP.Ma_loaiphong AND P.Trang_thai = 'Trong' ";
            tbPhongTrong = Class.Function.GetDataToTable(sql);
            dgvDSPhongTrong.DataSource = tbPhongTrong; // Gán DataTable vào DataGridView
            dgvDSPhongTrong.Columns[0].HeaderText = "Mã phòng";
            dgvDSPhongTrong.Columns[1].HeaderText = "Giá tiền";
            dgvDSPhongTrong.AllowUserToAddRows = false; // Không cho phép người dùng thêm dòng mới
            dgvDSPhongTrong.AllowUserToDeleteRows = false; // Không cho phép người dùng xóa dòng
            dgvDSPhongTrong.ReadOnly = true; // Đặt DataGridView ở chế độ chỉ đọc
            dgvDSPhongTrong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSPhongTrong.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataTable tbPD = new DataTable();
        int sttp = 1, sttdv = 1;
        private void dgvDSPhongTrong_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSPhongTrong.CurrentRow == null) return;
            if (e.RowIndex >= 0) //k lay dong header
            {
                DataGridViewRow row = dgvDSPhongTrong.Rows[e.RowIndex];
                string maP = row.Cells["Ma_phong"].Value.ToString();
                string dG = row.Cells["Gia_tien"].Value.ToString();
                dgvDSPhongDat.Rows.Add(sttp, maP, dG);
                sttp = sttp + 1;
                string sql;
                sql = "UPDATE Phong SET Trang_thai = 'Da dat' WHERE Ma_phong = '" + maP + "'";
                Class.Function.RunSQL(sql); // Cập nhật trạng thái phòng thành "Đã đặt"
                LoaddgvDSPhongTrong(); // Tải lại DataGridView phòng trống để cập nhật trạng thái
            }
            tongtienphong(); // Cập nhật tổng tiền phòng sau khi thêm dòng mới
            Capnhattongthanhtoan(); // Cập nhật tổng thanh toán sau khi thêm phòng
        }

        private void dgvDSDV_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void tongtiendv()
        {
            decimal tongtien = 0;
            foreach (DataGridViewRow row in dgvDSDVSD.Rows)
            {
                if (row.IsNewRow) continue;
                decimal dongia = decimal.Parse(row.Cells["ThanhTien_DV"].Value.ToString());
                tongtien += dongia;
            }
            txtTongTienDV.Text = tongtien.ToString("N0"); // Hiển thị tổng tiền dịch vụ, dinh dang co dau phay ngan cach
        }
        private void tongtienphong()
        {
            decimal tongtien = 0;
            foreach (DataGridViewRow row in dgvDSPhongDat.Rows)
            {
                if (row.IsNewRow) continue; // Bỏ qua dòng mới
                decimal dongia = decimal.Parse(row.Cells["Gia_tien"].Value.ToString());
                tongtien += dongia;
            }
            txtTongTienPhong.Text = tongtien.ToString("N0"); // Hiển thị tổng tiền phòng, định dạng có dấu phẩy ngăn cách
        }
        private void Capnhattongthanhtoan()
        {
            decimal tienDV = 0, tienPhong = 0;
            if (decimal.TryParse(txtTongTienDV.Text, out tienDV) && decimal.TryParse(txtTongTienPhong.Text, out tienPhong))
            {
                decimal tongThanhToan = tienDV + tienPhong;
                txtThanhToan.Text = (tienDV + tienPhong).ToString("N0"); // Hiển thị tổng thanh toán, định dạng có dấu phẩy ngăn cách
            }
            else
            {
                txtThanhToan.Text = "0"; // Nếu không thể chuyển đổi, đặt về 0
            }
        }
        private void dgvDSDV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSDV.CurrentRow == null || dgvDSPhongDat.CurrentRow == null) return;
            string mp = dgvDSPhongDat.CurrentRow.Cells["Ma_phong"].Value.ToString();
            string tendv = dgvDSDV.CurrentRow.Cells["Ten_DV"].Value.ToString();
            string dongiadv = dgvDSDV.CurrentRow.Cells["Don_gia"].Value.ToString();
            string sql;
            sql = "UPDATE Dich_vu SET Soluong = Soluong - 1 WHERE Ten_DV = '" + tendv + "'"; // Giảm số lượng dịch vụ
            Class.Function.RunSQL(sql); // Cập nhật số lượng dịch vụ
            LoaddgvDSDV(); // Tải lại DataGridView dịch vụ để cập nhật số lượng
            bool daCo = false;
            foreach (DataGridViewRow row in dgvDSDVSD.Rows)
            {
                if (row.IsNewRow) continue; //bo qua dong trang cuoi
                if (row.Cells["Ten_DV"].Value.ToString() == tendv)
                {
                    int slcu = int.Parse(row.Cells["SL_DV"].Value.ToString());
                    row.Cells["SL_DV"].Value = slcu + 1; // Tăng số lượng dịch vụ
                    row.Cells["ThanhTien_DV"].Value = (slcu + 1) * decimal.Parse(dongiadv); // Cập nhật thành tiền
                    daCo = true;
                    break;
                }
            }
            if (!daCo)
            {
                dgvDSDVSD.Rows.Add(sttdv, mp, tendv, 1, decimal.Parse(dongiadv)); // Thêm dòng mới với số lượng 1
                sttdv = sttdv + 1;
            }
            tongtiendv();
            Capnhattongthanhtoan(); // Cập nhật tổng thanh toán sau khi thêm dịch vụ

        }

        private void txtThanhToan_ChangeUICues(object sender, UICuesEventArgs e)
        {
            Capnhattongthanhtoan();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog(); // Hiển thị form Khách hàng
        }
    }
}
