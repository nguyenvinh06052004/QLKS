
using qlksss.Class;
namespace qlksss
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void mnuPhieu_Click(object sender, EventArgs e)
        {
            // TODO: Xử lý khi click vào mục Phiếu
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();

        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Function.Disconnect();
            Application.Exit();

        }

        private void mnuDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frmDMNhanVien = new frmDMNhanVien();
            this.Hide();
            frmDMNhanVien.ShowDialog();

        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKhachHang = new frmKhachHang();
            this.Hide();
            frmKhachHang.ShowDialog();
        }

        private void mnuPhong_Click(object sender, EventArgs e)
        {
            frmPhong frmPhong = new frmPhong();
            this.Hide();
            frmPhong.ShowDialog();
        }

        private void mnuPhieuDatPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
