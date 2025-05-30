namespace qlksss
{
    partial class frmLoaiPhong
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
            panel2 = new Panel();
            txtChatLuong = new TextBox();
            label6 = new Label();
            txtDonGia = new TextBox();
            label2 = new Label();
            txtSoLuongPhong = new TextBox();
            txtMaLoaiPhong = new TextBox();
            label3 = new Label();
            lable = new Label();
            label1 = new Label();
            dgvLoaiPhong = new DataGridView();
            panel1 = new Panel();
            BtnHienThi = new Button();
            BtnQuayLai = new Button();
            BtnTimKiem = new Button();
            BtnLuu = new Button();
            BtnBo = new Button();
            BtnXoa = new Button();
            BtnSua = new Button();
            BtnThem = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(txtChatLuong);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtDonGia);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtSoLuongPhong);
            panel2.Controls.Add(txtMaLoaiPhong);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lable);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1160, 125);
            panel2.TabIndex = 4;
            // 
            // txtChatLuong
            // 
            txtChatLuong.Anchor = AnchorStyles.Top;
            txtChatLuong.BackColor = SystemColors.GradientInactiveCaption;
            txtChatLuong.Location = new Point(784, 90);
            txtChatLuong.Name = "txtChatLuong";
            txtChatLuong.Size = new Size(238, 27);
            txtChatLuong.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(696, 97);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 9;
            label6.Text = "Chất lượng";
            // 
            // txtDonGia
            // 
            txtDonGia.Anchor = AnchorStyles.Top;
            txtDonGia.BackColor = SystemColors.GradientInactiveCaption;
            txtDonGia.Location = new Point(784, 46);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(716, 53);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 6;
            label2.Text = "Đơn giá";
            // 
            // txtSoLuongPhong
            // 
            txtSoLuongPhong.Anchor = AnchorStyles.Top;
            txtSoLuongPhong.BackColor = SystemColors.GradientInactiveCaption;
            txtSoLuongPhong.Location = new Point(320, 90);
            txtSoLuongPhong.Name = "txtSoLuongPhong";
            txtSoLuongPhong.Size = new Size(125, 27);
            txtSoLuongPhong.TabIndex = 1;
            // 
            // txtMaLoaiPhong
            // 
            txtMaLoaiPhong.Anchor = AnchorStyles.Top;
            txtMaLoaiPhong.BackColor = SystemColors.GradientInactiveCaption;
            txtMaLoaiPhong.Location = new Point(320, 46);
            txtMaLoaiPhong.Name = "txtMaLoaiPhong";
            txtMaLoaiPhong.Size = new Size(125, 27);
            txtMaLoaiPhong.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(198, 97);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Số lượng phòng";
            // 
            // lable
            // 
            lable.Anchor = AnchorStyles.Top;
            lable.AutoSize = true;
            lable.Location = new Point(205, 53);
            lable.Name = "lable";
            lable.Size = new Size(106, 20);
            lable.TabIndex = 1;
            lable.Text = "Mã loại phòng";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(485, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC LOẠI PHÒNG";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvLoaiPhong
            // 
            dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiPhong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLoaiPhong.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiPhong.Location = new Point(3, 123);
            dgvLoaiPhong.Name = "dgvLoaiPhong";
            dgvLoaiPhong.RowHeadersWidth = 51;
            dgvLoaiPhong.RowTemplate.Height = 29;
            dgvLoaiPhong.Size = new Size(1160, 196);
            dgvLoaiPhong.TabIndex = 5;
            dgvLoaiPhong.SelectionChanged += dgvLoaiPhong_SelectionChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(BtnHienThi);
            panel1.Controls.Add(BtnQuayLai);
            panel1.Controls.Add(BtnTimKiem);
            panel1.Controls.Add(BtnLuu);
            panel1.Controls.Add(BtnBo);
            panel1.Controls.Add(BtnXoa);
            panel1.Controls.Add(BtnSua);
            panel1.Controls.Add(BtnThem);
            panel1.Location = new Point(0, 317);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 133);
            panel1.TabIndex = 6;
            // 
            // BtnHienThi
            // 
            BtnHienThi.Anchor = AnchorStyles.Bottom;
            BtnHienThi.BackColor = Color.SteelBlue;
            BtnHienThi.ForeColor = SystemColors.ControlLightLight;
            BtnHienThi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHienThi.Location = new Point(84, 63);
            BtnHienThi.Name = "BtnHienThi";
            BtnHienThi.Size = new Size(94, 29);
            BtnHienThi.TabIndex = 7;
            BtnHienThi.Text = "Hiển thị";
            BtnHienThi.UseVisualStyleBackColor = false;
            BtnHienThi.Click += BtnHienThi_Click;
            // 
            // BtnQuayLai
            // 
            BtnQuayLai.Anchor = AnchorStyles.Bottom;
            BtnQuayLai.BackColor = Color.SteelBlue;
            BtnQuayLai.ForeColor = SystemColors.ControlLightLight;
            BtnQuayLai.Location = new Point(1008, 63);
            BtnQuayLai.Name = "BtnQuayLai";
            BtnQuayLai.Size = new Size(94, 29);
            BtnQuayLai.TabIndex = 6;
            BtnQuayLai.Text = "Quay Lại";
            BtnQuayLai.UseVisualStyleBackColor = false;
            BtnQuayLai.Click += BtnQuayLai_Click;
            // 
            // BtnTimKiem
            // 
            BtnTimKiem.Anchor = AnchorStyles.Bottom;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = SystemColors.ControlLightLight;
            BtnTimKiem.Location = new Point(885, 63);
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
            BtnLuu.Location = new Point(751, 63);
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
            BtnBo.Location = new Point(617, 63);
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
            BtnXoa.Location = new Point(349, 63);
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
            BtnSua.Location = new Point(483, 63);
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
            BtnThem.Location = new Point(215, 63);
            BtnThem.Name = "BtnThem";
            BtnThem.Size = new Size(94, 29);
            BtnThem.TabIndex = 0;
            BtnThem.Text = "Thêm";
            BtnThem.UseVisualStyleBackColor = false;
            BtnThem.Click += BtnThem_Click;
            // 
            // frmLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1164, 450);
            Controls.Add(panel1);
            Controls.Add(dgvLoaiPhong);
            Controls.Add(panel2);
            Name = "frmLoaiPhong";
            Text = "frmLoaiPhong";
            FormClosing += frmLoaiPhong_FormClosing;
            Load += frmLoaiPhong_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtChatLuong;
        private Label label6;
        private TextBox txtDonGia;
        private Label label2;
        private TextBox txtSoLuongPhong;
        private TextBox txtMaLoaiPhong;
        private Label label3;
        private Label lable;
        private Label label1;
        private DataGridView dgvLoaiPhong;
        private Panel panel1;
        private Button BtnTimKiem;
        private Button BtnLuu;
        private Button BtnBo;
        private Button BtnXoa;
        private Button BtnSua;
        private Button BtnThem;
        private Button BtnQuayLai;
        private Button BtnHienThi;
    }
}