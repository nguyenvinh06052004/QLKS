using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS2.Class;

namespace QLKS2
{
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadData()
        {
           
            DataTable dt = Class.Function.GetDataUsingStoredProc("sp_LayDanhSachPhong");
            dataGridView1.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn làm mới không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                txtMaPhong.Clear();
                txtTinhTrang.Clear();
                txtMaLP.Clear();
                LoadData();
            }

        }

        private void frmPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaPhong.Text = row.Cells["Ma_phong"].Value.ToString();
                txtTinhTrang.Text = row.Cells["Trang_thai"].Value.ToString();
                txtMaLP.Text = row.Cells["Ma_loaiphong"].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlParameter[] parameters = new SqlParameter[]
    {
        new SqlParameter("@Ma_phong", txtMaPhong.Text.Trim()),
        new SqlParameter("@Trang_thai", txtTinhTrang.Text.Trim()),
        new SqlParameter("@Ma_loaiphong", txtMaLP.Text.Trim())
    };

            bool result = Class.Function.ExecuteStoredProc("sp_ThemPhong", parameters);
            if (result)
            {
                MessageBox.Show("Thêm phòng thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm phòng thất bại!");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f = new frmMain();
            f.ShowDialog();
        }
    }
}
