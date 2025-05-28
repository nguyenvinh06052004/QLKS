namespace qlksss

{
    partial class frmKhachHang
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
            dgvKH = new DataGridView();
            txtDiaChi = new TextBox();
            BtnXoa = new Button();
            BtnSua = new Button();
            BtnThem = new Button();
            label6 = new Label();
            BtnTimKiem = new Button();
            BtnLuu = new Button();
            panel1 = new Panel();
            BtnBo = new Button();
            txtSDT = new TextBox();
            label2 = new Label();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            label3 = new Label();
            lable = new Label();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKH
            // 
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKH.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.Dock = DockStyle.Fill;
            dgvKH.Location = new Point(0, 125);
            dgvKH.Name = "dgvKH";
            dgvKH.RowHeadersWidth = 51;
            dgvKH.RowTemplate.Height = 29;
            dgvKH.Size = new Size(1164, 200);
            dgvKH.TabIndex = 4;
            dgvKH.CellContentClick += dgvNhanVien_CellContentClick;
            dgvKH.SelectionChanged += dgvKH_SelectionChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Top;
            txtDiaChi.BackColor = SystemColors.GradientInactiveCaption;
            txtDiaChi.Location = new Point(818, 83);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(238, 27);
            txtDiaChi.TabIndex = 4;
            txtDiaChi.KeyUp += txtDiaChi_KeyUp;
            // 
            // BtnXoa
            // 
            BtnXoa.Anchor = AnchorStyles.Bottom;
            BtnXoa.BackColor = Color.SteelBlue;
            BtnXoa.ForeColor = SystemColors.ControlLightLight;
            BtnXoa.Location = new Point(338, 58);
            BtnXoa.Name = "BtnXoa";
            BtnXoa.Size = new Size(94, 29);
            BtnXoa.TabIndex = 1;
            BtnXoa.Text = "Xóa";
            BtnXoa.UseVisualStyleBackColor = false;
            BtnXoa.Click += BtnXoa_Click_1;
            // 
            // BtnSua
            // 
            BtnSua.Anchor = AnchorStyles.Bottom;
            BtnSua.BackColor = Color.SteelBlue;
            BtnSua.ForeColor = SystemColors.ControlLightLight;
            BtnSua.Location = new Point(472, 58);
            BtnSua.Name = "BtnSua";
            BtnSua.Size = new Size(94, 29);
            BtnSua.TabIndex = 2;
            BtnSua.Text = "Sửa";
            BtnSua.UseVisualStyleBackColor = false;
            BtnSua.Click += BtnSua_Click_1;
            // 
            // BtnThem
            // 
            BtnThem.Anchor = AnchorStyles.Bottom;
            BtnThem.BackColor = Color.SteelBlue;
            BtnThem.ForeColor = SystemColors.ControlLightLight;
            BtnThem.ImageAlign = ContentAlignment.MiddleLeft;
            BtnThem.Location = new Point(204, 58);
            BtnThem.Name = "BtnThem";
            BtnThem.Size = new Size(94, 29);
            BtnThem.TabIndex = 0;
            BtnThem.Text = "Thêm";
            BtnThem.UseVisualStyleBackColor = false;
            BtnThem.Click += BtnThem_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(712, 86);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 9;
            label6.Text = "Địa chỉ";
            // 
            // BtnTimKiem
            // 
            BtnTimKiem.Anchor = AnchorStyles.Bottom;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = SystemColors.ControlLightLight;
            BtnTimKiem.Location = new Point(874, 58);
            BtnTimKiem.Name = "BtnTimKiem";
            BtnTimKiem.Size = new Size(94, 29);
            BtnTimKiem.TabIndex = 5;
            BtnTimKiem.Text = "Tìm Kiếm";
            BtnTimKiem.UseVisualStyleBackColor = false;
            BtnTimKiem.Click += BtnTimKiem_Click_1;
            // 
            // BtnLuu
            // 
            BtnLuu.Anchor = AnchorStyles.Bottom;
            BtnLuu.BackColor = Color.SteelBlue;
            BtnLuu.ForeColor = SystemColors.ControlLightLight;
            BtnLuu.Location = new Point(740, 58);
            BtnLuu.Name = "BtnLuu";
            BtnLuu.Size = new Size(94, 29);
            BtnLuu.TabIndex = 4;
            BtnLuu.Text = "Lưu";
            BtnLuu.UseVisualStyleBackColor = false;
            BtnLuu.Click += BtnLuu_Click_1;
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
            panel1.Location = new Point(0, 325);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 125);
            panel1.TabIndex = 5;
            // 
            // BtnBo
            // 
            BtnBo.Anchor = AnchorStyles.Bottom;
            BtnBo.BackColor = Color.SteelBlue;
            BtnBo.ForeColor = SystemColors.ControlLightLight;
            BtnBo.Location = new Point(606, 58);
            BtnBo.Name = "BtnBo";
            BtnBo.Size = new Size(94, 29);
            BtnBo.TabIndex = 3;
            BtnBo.Text = "Bỏ";
            BtnBo.UseVisualStyleBackColor = false;
            BtnBo.Click += BtnBo_Click_1;
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.Top;
            txtSDT.BackColor = SystemColors.GradientInactiveCaption;
            txtSDT.Location = new Point(818, 50);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 3;
            txtSDT.KeyUp += txtSDT_KeyUp;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(712, 48);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 6;
            label2.Text = "Số điện thoại";
            label2.Click += label2_Click;
            // 
            // txtTenKH
            // 
            txtTenKH.Anchor = AnchorStyles.Top;
            txtTenKH.BackColor = SystemColors.GradientInactiveCaption;
            txtTenKH.Location = new Point(260, 92);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(125, 27);
            txtTenKH.TabIndex = 1;
            txtTenKH.KeyUp += txtTenKH_KeyUp;
            // 
            // txtMaKH
            // 
            txtMaKH.Anchor = AnchorStyles.Top;
            txtMaKH.BackColor = SystemColors.GradientInactiveCaption;
            txtMaKH.Location = new Point(260, 41);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(125, 27);
            txtMaKH.TabIndex = 0;
            txtMaKH.KeyUp += txtMaKH_KeyUp;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(143, 90);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên khách hàng";
            // 
            // lable
            // 
            lable.Anchor = AnchorStyles.Top;
            lable.AutoSize = true;
            lable.Location = new Point(145, 48);
            lable.Name = "lable";
            lable.Size = new Size(109, 20);
            lable.TabIndex = 1;
            lable.Text = "Mã khách hàng";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(472, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC KHÁCH HÀNG";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTenKH);
            panel2.Controls.Add(txtMaKH);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lable);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1164, 125);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // frmKhachHang
            // 
            ClientSize = new Size(1164, 450);
            Controls.Add(dgvKH);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            Load += frmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKH;
        private TextBox txtDiaChi;
        private Button BtnXoa;
        private Button BtnSua;
        private Button BtnThem;
        private Label label6;
        private Button BtnTimKiem;
        private Button BtnLuu;
        private Panel panel1;
        private Button BtnBo;
        private TextBox txtSDT;
        private Label label2;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private Label label3;
        private Label lable;
        private Label label1;
        private Panel panel2;
    }
}