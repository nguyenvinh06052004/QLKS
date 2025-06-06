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
        Form parentForm;
        DataTable tbPhongTrong = new DataTable(); // Tạo DataTable để lưu dữ liệu phòng trống
        private string maPhietDat;
        private ChiTietMode mode; // Biến để lưu chế độ chi tiết (thêm, sửa, xóa)
        public frmChiTiet(Form caller, string maPhieu, ChiTietMode mode)
        {
            InitializeComponent();
            this.parentForm = caller; // Lưu form gọi
            this.maPhietDat = maPhieu; // Lưu mã phiếu đặt
            this.mode = mode; // Lưu chế độ chi tiết

            //xóaDVSDToolStripMenuItem.Click += xóaDVSDToolStripMenuItem_Click; // Đăng ký sự kiện click cho menu xóa dịch vụ đã sử dụng
            mnuxoaPhongDat.Click += xóaToolStripMenuItem1_Click; // Đăng ký sự kiện click cho menu xóa phòng đặt
            dgvDSPhongDat.ContextMenuStrip = mnuxoaPhongDat;
            mnuXoaSuaDVSD.Click += xóaDVSDToolStripMenuItem_Click; // Đăng ký sự kiện click cho menu xóa dịch vụ đã sử dụng
            mnuXoaSuaDVSD.Click += sửaSLToolStripMenuItem_Click; // Đăng ký sự kiện click cho menu sửa số lượng dịch vụ đã sử dụng
            dgvDSDVSD.ContextMenuStrip = mnuXoaSuaDVSD; // Gán ContextMenuStrip cho DataGridView dịch vụ đã sử dụng
            dgvDSDVSD.CellEndEdit += dgvDSDVSD_CellEndEdit;
            dgvDSDVSD.CellValueChanged += dgvDSDVSD_CellValueChanged;
            dgvDSDVSD.CurrentCellDirtyStateChanged += dgvDSDVSD_CurrentCellDirtyStateChanged;
        }

        private void DgvDSDVSD_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
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
           // dgvDSDVSD.ReadOnly = false; // Cho phép chỉnh sửa toàn bảng
            dgvDSDVSD.Columns["SL_DV"].ReadOnly = false; // Chỉ cho phép sửa cột SL_DV
           // dgvDSDVSD.Columns["ThanhTien_DV"].ReadOnly = true; // Không cho sửa thành tiền

            dgvDSDVSD.EditMode = DataGridViewEditMode.EditOnEnter;

        }
        private void frmChiTiet_Load(object sender, EventArgs e)
        {
            string sqp1;
            LoaddgvDSPhongTrong();
            LoaddgvDSDV();
            TaoCotDSPD();
            //string sqlnv = "SELECT Ma_NV, Ten_NV FROM Nhan_vien "; // Lấy danh sách nhân viên
            //Class.Function.FillCombo(sqlnv, cboMaNV, "Ten_NV", "Ma_NV");
            DataTable DSMaNV = Class.Function.GoiHamTraVeBang("SELECT * FROM dbo.LayDSMaNV()"); // Lấy danh sách mã nhân viên
            cboMaNV.DataSource = DSMaNV;
            cboMaNV.DisplayMember = "Ten_NV"; // Hiển thị tên nhân viên
            cboMaNV.ValueMember = "Ma_NV"; // Giá trị của ComboBox là mã nhân viên
            cboMaNV.SelectedIndex = -1; // Đặt giá trị mặc định cho ComboBox
            //string sqlkh = "SELECT Ma_KH, Ten_KH FROM Khach_Hang "; // Lấy danh sách nhân viên
            //Class.Function.FillCombo(sqlkh, cboMaKH, "Ten_KH", "Ma_KH");
            DataTable DSMaKH = Class.Function.GoiHamTraVeBang("SELECT * FROM dbo.LayDSMaKH()");
            cboMaKH.DataSource = DSMaKH;
            cboMaKH.DisplayMember = "Ten_KH"; // Hiển thị tên khách hàng
            cboMaKH.ValueMember = "Ma_KH"; // Giá trị của ComboBox là mã khách hàng
            cboMaKH.SelectedIndex = -1; // Đặt giá trị mặc định cho ComboBox
            //Reset();
            txtThanhToan.Text = "0"; // Đặt tổng thanh toán về 0
            txtTongTienDV.Text = "0"; // Đặt tổng tiền dịch vụ về 0
            txtTongTienPhong.Text = "0"; // Đặt tổng tiền phòng về 0
            switch (mode)
            {
                case ChiTietMode.Them:
                    {
                        txtMaPhieuDat.Text = maPhietDat; // Hiển thị mã phiếu đặt
                        txtMaPhieuDat.ReadOnly = true; // Đặt ô mã phiếu đặt ở chế độ chỉ đọc
                        //cboMaNV.Focus();

                        break;
                    }
                case ChiTietMode.Sua:
                    {
                        txtMaPhieuDat.Text = maPhietDat; // Hiển thị mã phiếu đặt
                        txtMaPhieuDat.ReadOnly = true; // Đặt ô mã phiếu đặt ở chế độ chỉ đọc
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

            //dtNgayDat.Text = DateTime.Now.ToString("dd-MM-yyyy"); // Đặt ngày dự kiến trả là ngày hiện tại
            //dtNgayDuKienTra.Text = DateTime.Now.ToString("dd-MM-yyyy");
            dtNgayDat.Value = DateTime.Now; // Đặt ngày đặt là ngày hiện tại
            dtNgayDuKienTra.Value = DateTime.Now; // Đặt ngày dự kiến trả là ngày hiện tại
        }
        DataTable tbDV = new DataTable(); // Tạo DataTable để lưu dữ liệu dịch vụ
        private void LoaddgvDSDV()
        {
            //string sql = "select Ten_DV, Don_gia, Soluong  from Dich_vu where Trangthai_DV != 'Ngung hoat dong' and Soluong > 0";

            tbDV = Class.Function.GoiHamTraVeBang("SELECT * FROM dbo.DSDVDungDuoc()");
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
            //string sql = "\r\nSELECT P.Ma_phong, LP.Gia_tien\r\nFROM Phong P, Loai_phong LP\r\nWHERE P.Ma_loaiphong = LP.Ma_loaiphong AND P.Trang_thai = 'Trong' ";
            tbPhongTrong = Class.Function.GoiHamTraVeBang("SELECT * FROM dbo.DSPhongTrong()");
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
                //sql = "UPDATE Phong SET Trang_thai = 'Da dat' WHERE Ma_phong = '" + maP + "'";
                var thamso = new Dictionary<string, object>
                {
                    { "@MAP", maP }
                };
                Class.Function.ThuTucKhongTraDL("CapNhatTTPhong", thamso); // Cập nhật trạng thái phòng thành "Đã đặt"
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
            string madv = dgvDSDV.CurrentRow.Cells["Ten_DV"].Value.ToString();
            string dongiadv = dgvDSDV.CurrentRow.Cells["Don_gia"].Value.ToString();
            string sql;
            //sql = "UPDATE Dich_vu SET Soluong = Soluong - 1 WHERE Ma_DV = '" + madv + "'"; // Giảm số lượng dịch vụ
            var thamso = new Dictionary<string, object>
            {
                { "@TENDV", madv },
                { "@SL", -1 } // Giảm số lượng dịch vụ
            };
            Class.Function.ThuTucKhongTraDL("CapNhatSLDV", thamso); // Cập nhật số lượng dịch vụ
            LoaddgvDSDV(); // Tải lại DataGridView dịch vụ để cập nhật số lượng
            bool daCo = false;
            foreach (DataGridViewRow row in dgvDSDVSD.Rows)
            {
                if (row.IsNewRow) continue; //bo qua dong trang cuoi
                if (row.Cells["Ten_DV"].Value.ToString() == madv && row.Cells["Ma_phong"].Value.ToString() == mp)
                {
                    int slcu = int.Parse(row.Cells["SL_DV"].Value.ToString());
                    row.Cells["SL_DV"].Value = slcu + 1; // Tăng số lượng dịch vụ
                    row.Cells["ThanhTien_DV"].Value = (slcu + 1) * decimal.Parse(dongiadv); // Cập nhật thành tiền
                    daCo = true;

                   // dgvDSDVSD.ReadOnly = false; // Cho phép chỉnh sửa toàn bảng
                    dgvDSDVSD.Columns["SL_DV"].ReadOnly = false; // Cho phép sửa cột số lượng
                    break;
                }


            }
            if (!daCo)
            {
                dgvDSDVSD.Rows.Add(sttdv, mp, madv, 1, decimal.Parse(dongiadv)); // Thêm dòng mới với số lượng 1
                sttdv = sttdv + 1;
              //  dgvDSDVSD.ReadOnly = false; // Cho phép chỉnh sửa toàn bảng
                dgvDSDVSD.Columns["SL_DV"].ReadOnly = false; // Cho phép sửa cột số lượng


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
            frmKhachHang frm = new frmKhachHang(this);
            //frm.ShowDialog(); // Hiển thị form Khách hàng
            this.Hide();
            frm.Show();
        }

        private void frmChiTiet_Activated(object sender, EventArgs e)//dung de cap nhat lai dl sau khi dong form khach hang
        {
            //string sqlkh = "SELECT Ma_KH, Ten_KH FROM Khach_Hang "; // Lấy danh sách nhân viên

            DataTable tbKH = Class.Function.GoiHamTraVeBang("SELECT * FROM dbo.LayDSMaKH()");
            cboMaKH.DataSource = tbKH;
            cboMaKH.DisplayMember = "Ten_KH"; // Hiển thị tên khách hàng
            cboMaKH.ValueMember = "Ma_KH"; // Giá trị của ComboBox là mã khách hàng
            //cboMaKH.SelectedIndex = -1; // Đặt giá trị mặc định cho ComboBox
        }

        private void mnuQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show();
        }


        private void mnuLuu_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuDat.Text == "" && cboMaNV.Text.Trim().Length == 0 && cboMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r1 = MessageBox.Show("Bạn chắc chắn muốn lưu phiếu đặt này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r1 == DialogResult.No)
            {
                MessageBox.Show(" Bạn đã hủy thao tác lưu phiếu đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Nếu người dùng chọn "Không", thoát khỏi hàm
            }
            if (cboMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtThanhToan.Text == "0")
            {
                MessageBox.Show("Vui lòng chọn phòng muốn đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (dtNgayDuKienTra.Value < dtNgayDat.Value)
            //{
            //    MessageBox.Show("Ngày dự kiến trả không thể nhỏ hơn ngày đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    //dtNgayDuKienTra.Focus();
            //}
            string maNV = cboMaNV.SelectedValue.ToString().Trim();
            string maKH = cboMaKH.SelectedValue.ToString().Trim();

            Class.Function.ThuTucKhongTraDL("ThemPDP", new Dictionary<string, object>
            {
                { "@MAPD", txtMaPhieuDat.Text.Trim() },
                { "@NGAYDUKIENTRA", dtNgayDuKienTra.Value.Date },
                { "@NGAYDAT", dtNgayDat.Value.Date },
                { "@MAKH", maKH },
                { "@MANV", maNV }
            });
        }

        private void dtNgayDat_ValueChanged(object sender, EventArgs e)
        {
            dtNgayDuKienTra.MinDate = dtNgayDat.Value.Date;
        }

        private void mnuBoQua_Click(object sender, EventArgs e)
        {
            Reset(); // Đặt lại các trường thông tin
            foreach (DataGridViewRow row in dgvDSPhongDat.Rows)
            {
                if (row.IsNewRow) continue; // Bỏ qua dòng mới
                string maP = row.Cells["Ma_phong"].Value.ToString();
                //string sql = "UPDATE Phong SET Trang_thai = 'Trong' WHERE Ma_phong = '" + maP + "'";
                var thamso = new Dictionary<string, object>
                {
                    { "@MAP", maP }
                };
                Class.Function.ThuTucKhongTraDL("CapNhatTrong", thamso); // Cập nhật trạng thái phòng thành "Trống"
            }
            LoaddgvDSPhongTrong(); // Tải lại DataGridView phòng trống để cập nhật trạng thái
            dgvDSPhongDat.Rows.Clear(); // Xóa tất cả các dòng trong DataGridView phòng đặt
            sttp = 1; // Đặt lại số thứ tự phòng
            foreach (DataGridViewRow row in dgvDSDVSD.Rows)
            {
                if (row.IsNewRow) continue; // Bỏ qua dòng mới
                string maDV = row.Cells["Ten_DV"].Value.ToString();
                int sl = int.Parse(row.Cells["SL_DV"].Value.ToString());
                //string sql = "UPDATE Dich_vu SET Soluong = Soluong + 1 WHERE Ma_DV = '" + maDV + "'";
                var thamso = new Dictionary<string, object>
                {
                    { "@TENDV", maDV },
                    { "@SL", sl } // Tăng số lượng dịch vụ
                };
                Class.Function.ThuTucKhongTraDL("CapNhatSLDV", thamso); // Cập nhật số lượng dịch vụ
                LoaddgvDSDV(); // Tải lại DataGridView dịch vụ để cập nhật số lượng
                dgvDSDVSD.Rows.Clear(); // Xóa tất cả các dòng trong DataGridView dịch vụ đã sử dụng
                sttp = 1; // Đặt lại số thứ tự dịch vụ
            }
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmChiTietPhongDV 
        }

        private void dgvDSPhongDat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvDSPhongDat.ClearSelection(); // Xóa tất cả các lựa chọn hiện tại
                dgvDSPhongDat.Rows[e.RowIndex].Selected = true; // Chọn dòng được nhấp chuột
                dgvDSPhongDat.CurrentCell = dgvDSPhongDat.Rows[e.RowIndex].Cells[e.ColumnIndex]; // Đặt ô hiện tại
                mnuxoaPhongDat.Show(Cursor.Position); // Hiển thị menu ngữ cảnh tại vị trí con trỏ chuột
            }
        }

        private void xóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng đặt này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (dgvDSPhongDat.CurrentRow == null) return; // Kiểm tra nếu không có dòng nào được chọn
                string maP = dgvDSPhongDat.CurrentRow.Cells["Ma_phong"].Value.ToString();
                //string sql = "UPDATE Phong SET Trang_thai = 'Trong' WHERE Ma_phong = '" + maP + "'";
                var thamso = new Dictionary<string, object>
                {
                    { "@MAP", maP }
                };
                Class.Function.ThuTucKhongTraDL("CapNhatTrong", thamso); // Cập nhật trạng thái phòng thành "Trống"
                LoaddgvDSPhongTrong(); // Tải lại DataGridView phòng trống để cập nhật trạng thái
                //foreach (DataGridViewRow row in dgvDSDVSD.Rows)
                for (int i = dgvDSDVSD.Rows.Count - 1; i >= 0; i--) // Duyệt ngược để tránh lỗi khi xóa dòng
                {
                    DataGridViewRow row = dgvDSDVSD.Rows[i];

                    if (row.IsNewRow) continue; // Bỏ qua dòng mới
                    if (row.Cells["Ma_phong"].Value.ToString() == maP)
                    {
                        string maDV = row.Cells["Ten_DV"].Value.ToString();
                        int sl = int.Parse(row.Cells["SL_DV"].Value.ToString());
                        //string sql = "UPDATE Dich_vu SET Soluong = Soluong + " + sl + " WHERE Ma_DV = '" + maDV + "'";
                        var thamso1 = new Dictionary<string, object>
                        {
                            { "@TENDV", maDV },
                            { "@SL", sl } // Tăng số lượng dịch vụ
                        };
                        Class.Function.ThuTucKhongTraDL("CapNhatSLDV", thamso1); // Cập nhật số lượng dịch vụ

                        LoaddgvDSDV(); // Tải lại DataGridView dịch vụ để cập nhật số lượng
                        dgvDSDVSD.Rows.Remove(row); // Xóa dòng dịch vụ đã sử dụng liên quan đến phòng được xóa
                    }
                }
                dgvDSPhongDat.Rows.RemoveAt(dgvDSPhongDat.CurrentRow.Index); // Xóa dòng hiện tại

                sttp--; // Giảm số thứ tự phòng
                tongtienphong(); // Cập nhật tổng tiền phòng sau khi xóa dòng
                tongtiendv(); // Cập nhật tổng tiền dịch vụ sau khi xóa phòng
                Capnhattongthanhtoan(); // Cập nhật tổng thanh toán sau khi xóa phòng
            }
            else
            {
                MessageBox.Show("Bạn đã hủy thao tác xóa phòng đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Nếu người dùng chọn "Không", thoát khỏi hàm
            }

        }

        private void mnuXoaSuaDVSD_Click(object sender, EventArgs e)
        {

        }

        private void xóaDVSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này không?---nut xoa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (dgvDSDVSD.CurrentRow == null) return; // Kiểm tra nếu không có dòng nào được chọn
                string maDV = dgvDSDVSD.CurrentRow.Cells["Ten_DV"].Value.ToString();
                int sl = int.Parse(dgvDSDVSD.CurrentRow.Cells["SL_DV"].Value.ToString());
                //string sql = "UPDATE Dich_vu SET Soluong = Soluong + " + sl + " WHERE Ma_DV = '" + maDV + "'";
                var thamso = new Dictionary<string, object>
                {
                    { "@TENDV", maDV },
                    { "@SL", sl } // Tăng số lượng dịch vụ
                };
                Class.Function.ThuTucKhongTraDL("CapNhatSLDV", thamso); // Cập nhật số lượng dịch vụ
                LoaddgvDSDV(); // Tải lại DataGridView dịch vụ để cập nhật số lượng
                dgvDSDVSD.Rows.RemoveAt(dgvDSDVSD.CurrentRow.Index); // Xóa dòng hiện tại
                sttdv--; // Giảm số thứ tự dịch vụ
                tongtiendv(); // Cập nhật tổng tiền dịch vụ sau khi xóa dòng
                Capnhattongthanhtoan(); // Cập nhật tổng thanh toán sau khi xóa dịch vụ
                return;
            }
            else
            {
                MessageBox.Show("Bạn đã hủy thao tác xóa dịch vụ!-- nut xoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Nếu người dùng chọn "Không", thoát khỏi hàm
            }
        }

        int sltruockhisua = 100; // Biến để lưu số lượng dịch vụ trước khi sửa
        private void sửaSLToolStripMenuItem_Click(object sender, EventArgs e)
        {


            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn sửa số lượng dịch vụ này không?--nutsua", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy thao tác sửa số lượng dịch vụ!--nutsua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Nếu người dùng chọn "Không", thoát khỏi hàm
            }
            if (dgvDSDVSD.CurrentRow == null || dgvDSDVSD.CurrentRow.Cells["SL_DV"].Value == null) return; // Kiểm tra nếu không có dòng nào được chọn
          //  dgvDSDVSD.ReadOnly = false; // Cho phép chỉnh sửa DataGridView dịch vụ đã sử dụng
            dgvDSDVSD.Columns["SL_DV"].ReadOnly = false; // Cho phép chỉnh sửa cột số lượng dịch vụ
            dgvDSDVSD.Columns["ThanhTien_DV"].ReadOnly = true; // Cột thành tiền không cho phép chỉnh sửa
            dgvDSDVSD.CurrentCell = dgvDSDVSD.Rows[dgvDSDVSD.CurrentRow.Index].Cells["SL_DV"]; // Đặt ô hiện tại là cột số lượng dịch vụ

            sltruockhisua = int.Parse(dgvDSDVSD.CurrentRow.Cells["SL_DV"].Value.ToString()); // Lưu số lượng dịch vụ trước khi sửa

            if (dgvDSDVSD.CurrentRow == null || dgvDSDVSD.CurrentRow.Cells["SL_DV"].Value == null) return;


            dgvDSDVSD.BeginEdit(true); // Bắt đầu chỉnh sửa ô hiện tại

        }

        private void dgvDSDVSD_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvDSDVSD.ClearSelection(); // Xóa tất cả các lựa chọn hiện tại
                dgvDSDVSD.Rows[e.RowIndex].Selected = true; // Chọn dòng được nhấp chuột
                dgvDSDVSD.CurrentCell = dgvDSDVSD.Rows[e.RowIndex].Cells[e.ColumnIndex]; // Đặt ô hiện tại
                dgvDSDVSD.CurrentCell = dgvDSDVSD.Rows[e.RowIndex].Cells["SL_DV"];

                mnuXoaSuaDVSD.Show(Cursor.Position); // Hiển thị menu ngữ cảnh tại vị trí con trỏ chuột
            }
        }

        private void dgvDSDVSD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show("SL cũ cellEndEdit: " + sltruockhisua); // kiểm tra giá trị thực tế


            int slnew = int.Parse(dgvDSDVSD.CurrentRow.Cells["SL_DV"].Value.ToString());
           // if (int.TryParse(slnew, out int sl))
            {
                if (slnew < 1)
                {
                    MessageBox.Show("Số lượng dịch vụ phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvDSDVSD.CurrentRow.Cells["SL_DV"].Value = sltruockhisua; // Đặt lại số lượng về 1 nếu nhập không hợp lệ
                    return;
                }
                string maDV = dgvDSDVSD.CurrentRow.Cells["Ten_DV"].Value.ToString();
                // decimal dongia = decimal.Parse(dgvDSDVSD.CurrentRow.Cells["ThanhTien_DV"].Value.ToString()) / (int.Parse(sltruockhisua) ); // Tính lại đơn giá
                //if (sltruockhisua == 100)
                //{
                //    MessageBox.Show("Không thể xác định đơn giá dịch vụ (SL cũ không hợp lệ) endEdit2." + sltruockhisua);
                //    return;
                //}
                //decimal dongia = decimal.Parse(dgvDSDVSD.CurrentRow.Cells["ThanhTien_DV"].Value.ToString()) / sltruockhisua;
                string tenDV = dgvDSDVSD.CurrentRow.Cells["Ten_DV"].Value.ToString();
                string dongia="";
                foreach ( DataGridViewRow row in dgvDSDV.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua dòng mới
                    if (row.Cells["Ten_DV"].Value.ToString() == tenDV)
                    {
                        dongia = row.Cells["Don_gia"].Value.ToString(); // Lấy đơn giá dịch vụ từ DataGridView dịch vụ
                        break;
                    }
                }

                //  MessageBox.Show("Đơn giá dịch vụ: " + dongia.ToString("N0")); // Hiển thị đơn giá dịch vụ

                dgvDSDVSD.CurrentRow.Cells["ThanhTien_DV"].Value = slnew * int.Parse(dongia.ToString()); // Cập nhật thành tiền
                tongtiendv(); // Cập nhật tổng tiền dịch vụ sau khi chỉnh sửa
                Capnhattongthanhtoan(); // Cập nhật tổng thanh toán sau khi chỉnh sửa
                                        // dgvDSDVSD.ReadOnly = true; // Đặt DataGridView dịch vụ đã sử dụng về chế độ chỉ đọc
                dgvDSDVSD.Columns["SL_DV"].ReadOnly = true;
                
            }
        }

        private void dgvDSDVSD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSDVSD_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

        }
    }
}
