namespace qlksss
{
    partial class frmDMNhanVien
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
            panel1 = new Panel();
            BtnTimKiem = new Button();
            BtnLuu = new Button();
            BtnBo = new Button();
            BtnXoa = new Button();
            BtnSua = new Button();
            BtnThem = new Button();
            panel2 = new Panel();
            txtDiaChi = new TextBox();
            label6 = new Label();
            txtSDT = new TextBox();
            txtChucVu = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txtTenNhanVien = new TextBox();
            txtMaNhanVien = new TextBox();
            label3 = new Label();
            lable = new Label();
            label1 = new Label();
            dgvNhanVien = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(BtnTimKiem);
            panel1.Controls.Add(BtnLuu);
            panel1.Controls.Add(BtnBo);
            panel1.Controls.Add(BtnXoa);
            panel1.Controls.Add(BtnSua);
            panel1.Controls.Add(BtnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 294);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 125);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // BtnTimKiem
            // 
            BtnTimKiem.Anchor = AnchorStyles.Bottom;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = SystemColors.ControlLightLight;
            BtnTimKiem.Location = new Point(764, 41);
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
            BtnLuu.Location = new Point(630, 41);
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
            BtnBo.Location = new Point(496, 41);
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
            BtnXoa.Location = new Point(228, 41);
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
            BtnSua.Location = new Point(362, 41);
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
            BtnThem.Location = new Point(94, 41);
            BtnThem.Name = "BtnThem";
            BtnThem.Size = new Size(94, 29);
            BtnThem.TabIndex = 0;
            BtnThem.Text = "Thêm";
            BtnThem.UseVisualStyleBackColor = false;
            BtnThem.Click += BtnThem_Click_1;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(txtChucVu);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtTenNhanVien);
            panel2.Controls.Add(txtMaNhanVien);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lable);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(945, 125);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Top;
            txtDiaChi.BackColor = SystemColors.GradientInactiveCaption;
            txtDiaChi.Location = new Point(651, 44);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(125, 27);
            txtDiaChi.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(590, 51);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 9;
            label6.Text = "Địa chỉ";
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.Top;
            txtSDT.BackColor = SystemColors.GradientInactiveCaption;
            txtSDT.Location = new Point(411, 92);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 3;
            // 
            // txtChucVu
            // 
            txtChucVu.Anchor = AnchorStyles.Top;
            txtChucVu.BackColor = SystemColors.GradientInactiveCaption;
            txtChucVu.Location = new Point(411, 48);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(125, 27);
            txtChucVu.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(306, 99);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 6;
            label2.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(306, 48);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 5;
            label4.Text = "Chức vụ";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Anchor = AnchorStyles.Top;
            txtTenNhanVien.BackColor = SystemColors.GradientInactiveCaption;
            txtTenNhanVien.Location = new Point(128, 87);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(125, 27);
            txtTenNhanVien.TabIndex = 1;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Anchor = AnchorStyles.Top;
            txtMaNhanVien.BackColor = SystemColors.GradientInactiveCaption;
            txtMaNhanVien.Location = new Point(128, 48);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(125, 27);
            txtMaNhanVien.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên nhân viên";
            // 
            // lable
            // 
            lable.Anchor = AnchorStyles.Top;
            lable.AutoSize = true;
            lable.Location = new Point(12, 48);
            lable.Name = "lable";
            lable.Size = new Size(97, 20);
            lable.TabIndex = 1;
            lable.Text = "Mã nhân viên";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(382, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC NHÂN VIÊN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNhanVien.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 125);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 29;
            dgvNhanVien.Size = new Size(945, 169);
            dgvNhanVien.TabIndex = 1;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            dgvNhanVien.SelectionChanged += dgvNhanVien_SelectionChanged;
            // 
            // frmDMNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(945, 419);
            Controls.Add(dgvNhanVien);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDMNhanVien";
            Text = "Danh mục nhân viên";
            Load += frmDMNhanVien_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnTimKiem;
        private Button BtnLuu;
        private Button BtnBo;
        private Button BtnXoa;
        private Button BtnSua;
        private Button BtnThem;
        private Panel panel2;
        private TextBox txtMaNhanVien;
        private Label label3;
        private Label lable;
        private Label label1;
        private TextBox txtTenNhanVien;
        private TextBox txtDiaChi;
        private Label label6;
        private TextBox txtSDT;
        private TextBox txtChucVu;
        private Label label2;
        private Label label4;
        private DataGridView dgvNhanVien;
    }
}