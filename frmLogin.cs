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

            if (username == AccountManager.RegisteredUsername &&
        password == AccountManager.RegisteredPassword)
            {
                // Ẩn Form đăng nhập
                this.Hide();

                // Mở Form Dashboard
                frmMain main = new frmMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.Hide();  // Ẩn form login

            frmRegister registerForm = new frmRegister();
            registerForm.ShowDialog();  // Mở form đăng ký dưới dạng dialog

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
