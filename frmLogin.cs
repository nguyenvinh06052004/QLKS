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
using Guna.UI2.WinForms;
using QLKS2;
using QLKS2.Class;

namespace qlksss
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblError.Visible = false;
            lblError.ForeColor = Color.Red;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (Function.CheckLogin(username, password))
            {
                this.Hide();
                frmMain main = new frmMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false; // Hiển thị mật khẩu
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; // Ẩn mật khẩu
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmRegister registerForm = new frmRegister())
            {
                this.Hide();
                registerForm.ShowDialog(); // mở form đăng ký dạng modal
                this.Show(); // khi đóng form đăng ký sẽ hiện lại form login
            }

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Đóng ứng dụng khi form đăng nhập đóng
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}
