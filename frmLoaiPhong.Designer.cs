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
            txtSDT = new TextBox();
            label2 = new Label();
            txtTenKH = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            BtnTimKiem = new Button();
            BtnLuu = new Button();
            BtnBo = new Button();
            BtnXoa = new Button();
            BtnSua = new Button();
            BtnThem = new Button();
            label6 = new Label();
            txtDiaChi = new TextBox();
            dgvKH = new DataGridView();
            lable = new Label();
            panel2 = new Panel();
            btnHienThi = new Button();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.Top;
            txtSDT.BackColor = SystemColors.GradientInactiveCaption;
            txtSDT.Location = new Point(451, 43);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(363, 50);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 6;
            label2.Text = "Chất lượng";
            // 
            // txtTenKH
            // 
            txtTenKH.Anchor = AnchorStyles.Top;
            txtTenKH.BackColor = SystemColors.GradientInactiveCaption;
            txtTenKH.Location = new Point(133, 112);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(125, 27);
            txtTenKH.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Số lượng phòng";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(534, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC LOẠI PHÒNG";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(btnHienThi);
            panel1.Controls.Add(BtnTimKiem);
            panel1.Controls.Add(BtnLuu);
            panel1.Controls.Add(BtnBo);
            panel1.Controls.Add(BtnXoa);
            panel1.Controls.Add(BtnSua);
            panel1.Controls.Add(BtnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 325);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 125);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // BtnTimKiem
            // 
            BtnTimKiem.Anchor = AnchorStyles.Bottom;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = SystemColors.ControlLightLight;
            BtnTimKiem.Location = new Point(877, 56);
            BtnTimKiem.Name = "BtnTimKiem";
            BtnTimKiem.Size = new Size(94, 29);
            BtnTimKiem.TabIndex = 5;
            BtnTimKiem.Text = "Tìm Kiếm";
            BtnTimKiem.UseVisualStyleBackColor = false;
            // 
            // BtnLuu
            // 
            BtnLuu.Anchor = AnchorStyles.Bottom;
            BtnLuu.BackColor = Color.SteelBlue;
            BtnLuu.ForeColor = SystemColors.ControlLightLight;
            BtnLuu.Location = new Point(767, 56);
            BtnLuu.Name = "BtnLuu";
            BtnLuu.Size = new Size(94, 29);
            BtnLuu.TabIndex = 4;
            BtnLuu.Text = "Lưu";
            BtnLuu.UseVisualStyleBackColor = false;
            // 
            // BtnBo
            // 
            BtnBo.Anchor = AnchorStyles.Bottom;
            BtnBo.BackColor = Color.SteelBlue;
            BtnBo.ForeColor = SystemColors.ControlLightLight;
            BtnBo.Location = new Point(657, 56);
            BtnBo.Name = "BtnBo";
            BtnBo.Size = new Size(94, 29);
            BtnBo.TabIndex = 3;
            BtnBo.Text = "Bỏ";
            BtnBo.UseVisualStyleBackColor = false;
            // 
            // BtnXoa
            // 
            BtnXoa.Anchor = AnchorStyles.Bottom;
            BtnXoa.BackColor = Color.SteelBlue;
            BtnXoa.ForeColor = SystemColors.ControlLightLight;
            BtnXoa.Location = new Point(437, 56);
            BtnXoa.Name = "BtnXoa";
            BtnXoa.Size = new Size(94, 29);
            BtnXoa.TabIndex = 1;
            BtnXoa.Text = "Xóa";
         //   BtnXoa.UseVisualStyleBackColor = false;
        //    BtnXoa.Click += this.BtnXoa_Click;
            // 
            // BtnSua
            // 
            BtnSua.Anchor = AnchorStyles.Bottom;
            BtnSua.BackColor = Color.SteelBlue;
            BtnSua.ForeColor = SystemColors.ControlLightLight;
            BtnSua.Location = new Point(547, 56);
            BtnSua.Name = "BtnSua";
            BtnSua.Size = new Size(94, 29);
            BtnSua.TabIndex = 2;
            BtnSua.Text = "Sửa";
            BtnSua.UseVisualStyleBackColor = false;
            // 
            // BtnThem
            // 
            BtnThem.Anchor = AnchorStyles.Bottom;
            BtnThem.BackColor = Color.SteelBlue;
            BtnThem.ForeColor = SystemColors.ControlLightLight;
            BtnThem.ImageAlign = ContentAlignment.MiddleLeft;
            BtnThem.Location = new Point(327, 56);
            BtnThem.Name = "BtnThem";
            BtnThem.Size = new Size(94, 29);
            BtnThem.TabIndex = 0;
            BtnThem.Text = "Thêm";
            BtnThem.UseVisualStyleBackColor = false;
         //   BtnThem.Click += this.BtnThem_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(363, 119);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 9;
            label6.Text = "Giá tiền";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Top;
            txtDiaChi.BackColor = SystemColors.GradientInactiveCaption;
            txtDiaChi.Location = new Point(437, 116);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(238, 27);
            txtDiaChi.TabIndex = 4;
            // 
            // dgvKH
            // 
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKH.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.Dock = DockStyle.Fill;
            dgvKH.Location = new Point(0, 164);
            dgvKH.Name = "dgvKH";
            dgvKH.RowHeadersWidth = 51;
            dgvKH.RowTemplate.Height = 29;
            dgvKH.Size = new Size(1191, 286);
            dgvKH.TabIndex = 7;
            // 
            // lable
            // 
            lable.Anchor = AnchorStyles.Top;
            lable.AutoSize = true;
            lable.Location = new Point(12, 50);
            lable.Name = "lable";
            lable.Size = new Size(106, 20);
            lable.TabIndex = 1;
            lable.Text = "Mã loại phòng";
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTenKH);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lable);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1191, 164);
            panel2.TabIndex = 6;
            // 
            // btnHienThi
            // 
            btnHienThi.Anchor = AnchorStyles.Bottom;
            btnHienThi.BackColor = Color.SteelBlue;
            btnHienThi.ForeColor = SystemColors.ControlLightLight;
            btnHienThi.ImageAlign = ContentAlignment.MiddleLeft;
            btnHienThi.Location = new Point(209, 56);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 6;
            btnHienThi.Text = "Hiển Thị DS";
            btnHienThi.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1000, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 149);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // frmLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 450);
            Controls.Add(panel1);
            Controls.Add(dgvKH);
            Controls.Add(panel2);
            Name = "frmLoaiPhong";
            Text = "frmLoaiPhong";
            Load += frmLoaiPhong_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSDT;
        private Label label2;
        private TextBox txtTenKH;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Button btnHienThi;
        private Button BtnTimKiem;
        private Button BtnLuu;
        private Button BtnBo;
        private Button BtnXoa;
        private Button BtnSua;
        private Button BtnThem;
        private Label label6;
        private TextBox txtDiaChi;
        private DataGridView dgvKH;
        private Label lable;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
    }
}