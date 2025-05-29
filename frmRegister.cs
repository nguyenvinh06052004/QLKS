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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string role = cboRole.SelectedItem?.ToString(); // comboBox quyền

            // Kiểm tra quyền đã chọn chưa
            if (cboRole.SelectedItem == null)
            {
                lblError.Text = "Please select a role.";
                lblError.Visible = true;
                return;
            }

            // Kiểm tra mật khẩu trùng nhau
            if (password != confirmPassword)
            {
                lblError.Text = "Your passwords do not match.";
                lblError.Visible = true;
                return;
            }

            lblError.Visible = false; // Ẩn nếu không có lỗi

            // Tiếp tục xử lý đăng ký...
            MessageBox.Show("Register successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Lưu tài khoản tạm vào bộ nhớ
            AccountManager.RegisteredUsername = username;
            AccountManager.RegisteredPassword = password;
            AccountManager.RegisteredRole = role;

            // Quay về form login
            this.Hide();
            frmLogin loginForm = new frmLogin(); // Tạo form đăng nhập
            loginForm.Show(); // Hiển thị form đăng nhập

            this.Close();
        }

        private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false; // Hiển thị mật khẩu
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; // Ẩn mật khẩu
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load_1(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
