namespace qlksss
{
    partial class frmPhong
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
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            txtMaPhong = new TextBox();
            cboMaLP = new ComboBox();
            label2 = new Label();
            txtTT = new TextBox();
            label3 = new Label();
            lable = new Label();
            label1 = new Label();
            dgvP = new DataGridView();
            btnHienThi = new Button();
            BtnTimKiem = new Button();
            BtnLuu = new Button();
            BtnBo = new Button();
            BtnXoa = new Button();
            BtnSua = new Button();
            BtnThem = new Button();
            panel1 = new Panel();
            BtnQuayLai = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvP).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(txtMaPhong);
            panel2.Controls.Add(cboMaLP);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTT);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lable);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1072, 95);
            panel2.TabIndex = 9;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Anchor = AnchorStyles.Top;
            txtMaPhong.BackColor = SystemColors.GradientInactiveCaption;
            txtMaPhong.Location = new Point(138, 46);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(125, 27);
            txtMaPhong.TabIndex = 13;
            txtMaPhong.TextChanged += txtMaPhong_TextChanged;
            txtMaPhong.KeyUp += txtMaPhong_KeyUp;
            // 
            // cboMaLP
            // 
            cboMaLP.Anchor = AnchorStyles.Top;
            cboMaLP.BackColor = SystemColors.GradientInactiveCaption;
            cboMaLP.FormattingEnabled = true;
            cboMaLP.Location = new Point(470, 45);
            cboMaLP.Name = "cboMaLP";
            cboMaLP.Size = new Size(125, 28);
            cboMaLP.TabIndex = 12;
            cboMaLP.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            cboMaLP.KeyUp += cboMaLP_KeyUp;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(354, 46);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 6;
            label2.Text = "Chất lượng";
            // 
            // txtTT
            // 
            txtTT.Anchor = AnchorStyles.Top;
            txtTT.BackColor = SystemColors.GradientInactiveCaption;
            txtTT.Location = new Point(733, 43);
            txtTT.Name = "txtTT";
            txtTT.Size = new Size(125, 27);
            txtTT.TabIndex = 1;
            txtTT.KeyUp += txtTT_KeyUp;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(652, 45);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái";
            // 
            // lable
            // 
            lable.Anchor = AnchorStyles.Top;
            lable.AutoSize = true;
            lable.Location = new Point(53, 46);
            lable.Name = "lable";
            lable.Size = new Size(77, 20);
            lable.TabIndex = 1;
            lable.Text = "Mã phòng";
            lable.Click += lable_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(451, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC  PHÒNG";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvP
            // 
            dgvP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvP.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvP.Dock = DockStyle.Fill;
            dgvP.Location = new Point(0, 95);
            dgvP.Name = "dgvP";
            dgvP.RowHeadersWidth = 51;
            dgvP.RowTemplate.Height = 29;
            dgvP.Size = new Size(1072, 230);
            dgvP.TabIndex = 10;
            dgvP.CellContentClick += dgvP_CellContentClick;
            dgvP.SelectionChanged += dgvP_SelectionChanged;
            // 
            // btnHienThi
            // 
            btnHienThi.Anchor = AnchorStyles.Bottom;
            btnHienThi.BackColor = Color.SteelBlue;
            btnHienThi.ForeColor = SystemColors.ControlLightLight;
            btnHienThi.ImageAlign = ContentAlignment.MiddleLeft;
            btnHienThi.Location = new Point(113, 45);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 6;
            btnHienThi.Text = "Hiển Thị DS";
            btnHienThi.UseVisualStyleBackColor = false;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // BtnTimKiem
            // 
            BtnTimKiem.Anchor = AnchorStyles.Bottom;
            BtnTimKiem.BackColor = Color.SteelBlue;
            BtnTimKiem.ForeColor = SystemColors.ControlLightLight;
            BtnTimKiem.Location = new Point(781, 45);
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
            BtnLuu.Location = new Point(671, 45);
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
            BtnBo.Location = new Point(561, 45);
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
            BtnXoa.Location = new Point(341, 45);
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
            BtnSua.Location = new Point(451, 45);
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
            BtnThem.Location = new Point(231, 45);
            BtnThem.Name = "BtnThem";
            BtnThem.Size = new Size(94, 29);
            BtnThem.TabIndex = 0;
            BtnThem.Text = "Thêm";
            BtnThem.UseVisualStyleBackColor = false;
            BtnThem.Click += BtnThem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(BtnQuayLai);
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
            panel1.Size = new Size(1072, 125);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // BtnQuayLai
            // 
            BtnQuayLai.Anchor = AnchorStyles.Bottom;
            BtnQuayLai.BackColor = Color.SteelBlue;
            BtnQuayLai.ForeColor = SystemColors.ControlLightLight;
            BtnQuayLai.Location = new Point(895, 45);
            BtnQuayLai.Name = "BtnQuayLai";
            BtnQuayLai.Size = new Size(94, 29);
            BtnQuayLai.TabIndex = 7;
            BtnQuayLai.Text = "Quay Lại";
            BtnQuayLai.UseVisualStyleBackColor = false;
            BtnQuayLai.Click += BtnQuayLai_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // frmPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 450);
            Controls.Add(dgvP);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmPhong";
            Text = "frmPhong";
            Load += frmPhong_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvP).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private TextBox txtTT;
        private Label label3;
        private Label lable;
        private Label label1;
        private DataGridView dgvP;
        private Button btnHienThi;
        private Button BtnTimKiem;
        private Button BtnLuu;
        private Button BtnBo;
        private Button BtnXoa;
        private Button BtnSua;
        private Button BtnThem;
        private Panel panel1;
        private ComboBox cboMaLP;
        private TextBox txtMaPhong;
        private ContextMenuStrip contextMenuStrip1;
        private Button BtnQuayLai;
    }
}