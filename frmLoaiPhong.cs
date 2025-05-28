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
        DataTable tblLP;
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * FROM ";

        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            // TODO: Viết mã xử lý khi bấm nút Xóa
            MessageBox.Show("Bạn đã nhấn nút Xóa");
        }

    }
}
