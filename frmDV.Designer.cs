namespace qlksss
{
    partial class frmDV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "frmDV";
        }

        #endregion

            panel2 = new Panel();
            cboMaNhanVien = new ComboBox();
            label7 = new Label();
            txtDonViTinh = new TextBox();
            label5 = new Label();
            txtSoLuong = new TextBox();
            label6 = new Label();
            txtDonGia = new TextBox();
            label4 = new Label();
            txtTrangThai = new TextBox();
            label2 = new Label();
            txtTenDichVu = new TextBox();
            txtMaDichVu = new TextBox();
            label3 = new Label();
            lable = new Label();
            label1 = new Label();
            dgvDV = new DataGridView();
            panel1 = new Panel();
            BtnQuayLai = new Button();
            BtnHienThi = new Button();
            BtnTimKiem = new Button();
            BtnLuu = new Button();
            BtnBo = new Button();
            BtnXoa = new Button();
            BtnSua = new Button();
            BtnThem = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(cboMaNhanVien);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtDonViTinh);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtSoLuong);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtDonGia);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtTrangThai);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTenDichVu);
            panel2.Controls.Add(txtMaDichVu);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lable);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1071, 125);
            panel2.TabIndex = 5;
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.Anchor = AnchorStyles.Top;
            cboMaNhanVien.BackColor = SystemColors.GradientInactiveCaption;
            cboMaNhanVien.FormattingEnabled = true;
            cboMaNhanVien.Location = new Point(910, 46);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(125, 28);
            cboMaNhanVien.TabIndex = 17;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(807, 54);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 16;
            label7.Text = "Mã nhân viên";
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Anchor = AnchorStyles.Top;
            txtDonViTinh.BackColor = SystemColors.GradientInactiveCaption;
            txtDonViTinh.Location = new Point(655, 91);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(125, 27);
            txtDonViTinh.TabIndex = 14;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(568, 98);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 15;
            label5.Text = "Đơn vị tính";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Anchor = AnchorStyles.Top;
            txtSoLuong.BackColor = SystemColors.GradientInactiveCaption;
            txtSoLuong.Location = new Point(655, 47);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(125, 27);
            txtSoLuong.TabIndex = 12;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(583, 54);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 13;
            label6.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            txtDonGia.Anchor = AnchorStyles.Top;
            txtDonGia.BackColor = SystemColors.GradientInactiveCaption;
            txtDonGia.Location = new Point(383, 91);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(315, 98);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 11;
            label4.Text = "Đơn giá";
            // 
            // txtTrangThai
            // 
            txtTrangThai.Anchor = AnchorStyles.Top;
            txtTrangThai.BackColor = SystemColors.GradientInactiveCaption;
            txtTrangThai.Location = new Point(383, 47);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(125, 27);
            txtTrangThai.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(302, 54);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Trạng thái";
            // 
            // txtTenDichVu
            // 
            txtTenDichVu.Anchor = AnchorStyles.Top;
            txtTenDichVu.BackColor = SystemColors.GradientInactiveCaption;
            txtTenDichVu.Location = new Point(128, 91);
            txtTenDichVu.Name = "txtTenDichVu";
            txtTenDichVu.Size = new Size(125, 27);
            txtTenDichVu.TabIndex = 1;
            // 
            // txtMaDichVu
            // 
            txtMaDichVu.Anchor = AnchorStyles.Top;
            txtMaDichVu.BackColor = SystemColors.GradientInactiveCaption;
            txtMaDichVu.Location = new Point(128, 47);
            txtMaDichVu.Name = "txtMaDichVu";
            txtMaDichVu.Size = new Size(125, 27);
            txtMaDichVu.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(39, 98);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên dịch vụ";
            // 
            // lable
            // 
            lable.Anchor = AnchorStyles.Top;
            lable.AutoSize = true;
            lable.Location = new Point(41, 54);
            lable.Name = "lable";
            lable.Size = new Size(81, 20);
            lable.TabIndex = 1;
            lable.Text = "Mã dịch vụ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(448, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC DỊCH VỤ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvDV
            // 
            dgvDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDV.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDV.Location = new Point(0, 124);
            dgvDV.Name = "dgvDV";
            dgvDV.RowHeadersWidth = 51;
            dgvDV.RowTemplate.Height = 29;
            dgvDV.Size = new Size(1072, 230);
            dgvDV.TabIndex = 6;
            dgvDV.SelectionChanged += dgvDV_SelectionChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(BtnQuayLai);
            panel1.Controls.Add(BtnHienThi);
            panel1.Controls.Add(BtnTimKiem);
            panel1.Controls.Add(BtnLuu);
            panel1.Controls.Add(BtnBo);
            panel1.Controls.Add(BtnXoa);
            panel1.Controls.Add(BtnSua);
            panel1.Controls.Add(BtnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 353);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 97);
            panel1.TabIndex = 12;
            // 
            // BtnQuayLai
            // 
            BtnQuayLai.Anchor = AnchorStyles.Bottom;
            BtnQuayLai.BackColor = Color.SteelBlue;
            BtnQuayLai.ForeColor = SystemColors.ControlLightLight;
            BtnQuayLai.Location = new Point(893, 29);
            BtnQuayLai.Name = "BtnQuayLai";
            BtnQuayLai.Size = new Size(94, 29);
            BtnQuayLai.TabIndex = 7;
            BtnQuayLai.Text = "Quay Lại";
            BtnQuayLai.UseVisualStyleBackColor = false;
            BtnQuayLai.Click += BtnQuayLai_Click;
            // 
            // BtnHienThi
            // 
            BtnHienThi.Anchor = AnchorStyles.Bottom;
            BtnHienThi.BackColor = Color.SteelBlue;
            BtnHienThi.ForeColor = SystemColors.ControlLightLight;
            BtnHienThi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHienThi.Location = new Point(111, 29);
            BtnHienThi.Name = "BtnHienThi";
            BtnHienThi.Size = new Size(94, 29);
            BtnHienThi.TabIndex = 6;
            BtnHienThi.Text = "Hiển Thị DS";
            BtnHienThi.UseVisualStyleBackColor = false;
            BtnHienThi.Click += BtnHienThi_Click;
            // 
            // BtnTimKiem
            // 
            BtnTimKiem.Anchor = AnchorStyles.Bottom;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = SystemColors.ControlLightLight;
            BtnTimKiem.Location = new Point(779, 29);
            BtnTimKiem.Name = "BtnTimKiem";
            BtnTimKiem.Size = new Size(94, 29);
            BtnTimKiem.TabIndex = 5;
            BtnTimKiem.Text = "Tìm Kiếm";
            BtnTimKiem.UseVisualStyleBackColor = false;
            BtnTimKiem.Click += BtnTimKiem_Click;
            // 
            // BtnLuu
            // 
            BtnLuu.Anchor = AnchorStyles.Bottom;
            BtnLuu.BackColor = Color.SteelBlue;
            BtnLuu.ForeColor = SystemColors.ControlLightLight;
            BtnLuu.Location = new Point(669, 29);
            BtnLuu.Name = "BtnLuu";
            BtnLuu.Size = new Size(94, 29);
            BtnLuu.TabIndex = 4;
            BtnLuu.Text = "Lưu";
            BtnLuu.UseVisualStyleBackColor = false;
            BtnLuu.Click += BtnLuu_Click;
            // 
            // BtnBo
            // 
            BtnBo.Anchor = AnchorStyles.Bottom;
            BtnBo.BackColor = Color.SteelBlue;
            BtnBo.ForeColor = SystemColors.ControlLightLight;
            BtnBo.Location = new Point(559, 29);
            BtnBo.Name = "BtnBo";
            BtnBo.Size = new Size(94, 29);
            BtnBo.TabIndex = 3;
            BtnBo.Text = "Bỏ";
            BtnBo.UseVisualStyleBackColor = false;
            BtnBo.Click += BtnBo_Click;
            // 
            // BtnXoa
            // 
            BtnXoa.Anchor = AnchorStyles.Bottom;
            BtnXoa.BackColor = Color.SteelBlue;
            BtnXoa.ForeColor = SystemColors.ControlLightLight;
            BtnXoa.Location = new Point(339, 29);
            BtnXoa.Name = "BtnXoa";
            BtnXoa.Size = new Size(94, 29);
            BtnXoa.TabIndex = 1;
            BtnXoa.Text = "Xóa";
            BtnXoa.UseVisualStyleBackColor = false;
            BtnXoa.Click += BtnXoa_Click;
            // 
            // BtnSua
            // 
            BtnSua.Anchor = AnchorStyles.Bottom;
            BtnSua.BackColor = Color.SteelBlue;
            BtnSua.ForeColor = SystemColors.ControlLightLight;
            BtnSua.Location = new Point(449, 29);
            BtnSua.Name = "BtnSua";
            BtnSua.Size = new Size(94, 29);
            BtnSua.TabIndex = 2;
            BtnSua.Text = "Sửa";
            BtnSua.UseVisualStyleBackColor = false;
            BtnSua.Click += BtnSua_Click;
            // 
            // BtnThem
            // 
            BtnThem.Anchor = AnchorStyles.Bottom;
            BtnThem.BackColor = Color.SteelBlue;
            BtnThem.ForeColor = SystemColors.ControlLightLight;
            BtnThem.ImageAlign = ContentAlignment.MiddleLeft;
            BtnThem.Location = new Point(229, 29);
            BtnThem.Name = "BtnThem";
            BtnThem.Size = new Size(94, 29);
            BtnThem.TabIndex = 0;
            BtnThem.Text = "Thêm";
            BtnThem.UseVisualStyleBackColor = false;
            BtnThem.Click += BtnThem_Click;
            // 
            // frmDV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 450);
            Controls.Add(panel1);
            Controls.Add(dgvDV);
            Controls.Add(panel2);
            Name = "frmDV";
            Text = "frmDV";
            FormClosing += frmDV_FormClosing;
            Load += frmDV_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDV).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtTrangThai;
        private Label label2;
        private TextBox txtTenDichVu;
        private TextBox txtMaDichVu;
        private Label label3;
        private Label lable;
        private Label label1;
        private TextBox txtDonGia;
        private Label label4;
        private DataGridView dgvDV;
        private Panel panel1;
        private Button BtnQuayLai;
        private Button BtnHienThi;
        private Button BtnTimKiem;
        private Button BtnLuu;
        private Button BtnBo;
        private Button BtnXoa;
        private Button BtnSua;
        private Button BtnThem;
        private Label label7;
        private TextBox txtDonViTinh;
        private Label label5;
        private TextBox txtSoLuong;
        private Label label6;
        private ComboBox cboMaNhanVien;
    }
}