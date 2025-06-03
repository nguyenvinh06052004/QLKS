namespace qlksss
{
    partial class frmChiTiet
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
            dgvDSPhongTrong = new DataGridView();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            mnuLuu = new ToolStripMenuItem();
            mnuBoQua = new ToolStripMenuItem();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            panel2 = new Panel();
            label7 = new Label();
            btnThemKH = new Button();
            dtNgayDuKienTra = new DateTimePicker();
            cboMaKH = new ComboBox();
            cboMaNV = new ComboBox();
            dtNgayDat = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMaPhieuDat = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel6 = new Panel();
            txtTongTienDV = new TextBox();
            txtTongTienPhong = new TextBox();
            label13 = new Label();
            label12 = new Label();
            dgvDSDV = new DataGridView();
            txtThanhToan = new TextBox();
            label11 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvDSPhongDat = new DataGridView();
            dgvDSDVSD = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhongTrong).BeginInit();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSDV).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhongDat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSDVSD).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(dgvDSPhongTrong);
            panel1.Location = new Point(0, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 371);
            panel1.TabIndex = 2;
            // 
            // dgvDSPhongTrong
            // 
            dgvDSPhongTrong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSPhongTrong.Dock = DockStyle.Fill;
            dgvDSPhongTrong.Location = new Point(0, 0);
            dgvDSPhongTrong.Name = "dgvDSPhongTrong";
            dgvDSPhongTrong.RowHeadersWidth = 51;
            dgvDSPhongTrong.RowTemplate.Height = 29;
            dgvDSPhongTrong.Size = new Size(198, 371);
            dgvDSPhongTrong.TabIndex = 1;
            dgvDSPhongTrong.CellContentDoubleClick += dgvDSPhongTrong_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 0;
            label1.Text = "Danh sách phòng trống";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuLuu, mnuBoQua });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1027, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuLuu
            // 
            mnuLuu.Name = "mnuLuu";
            mnuLuu.Size = new Size(47, 24);
            mnuLuu.Text = "Lưu";
            // 
            // mnuBoQua
            // 
            mnuBoQua.Name = "mnuBoQua";
            mnuBoQua.Size = new Size(70, 24);
            mnuBoQua.Text = "Bỏ qua";
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnThemKH);
            panel2.Controls.Add(dtNgayDuKienTra);
            panel2.Controls.Add(cboMaKH);
            panel2.Controls.Add(cboMaNV);
            panel2.Controls.Add(dtNgayDat);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtMaPhieuDat);
            panel2.Location = new Point(198, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 130);
            panel2.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 95);
            label7.Name = "label7";
            label7.Size = new Size(155, 20);
            label7.TabIndex = 11;
            label7.Text = "Thêm mới khách hàng";
            // 
            // btnThemKH
            // 
            btnThemKH.Location = new Point(473, 91);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(60, 29);
            btnThemKH.TabIndex = 10;
            btnThemKH.Text = "Thêm ";
            btnThemKH.UseVisualStyleBackColor = true;
            btnThemKH.Click += btnThemKH_Click;
            // 
            // dtNgayDuKienTra
            // 
            dtNgayDuKienTra.CustomFormat = "dd/MM/yyyy";
            dtNgayDuKienTra.Format = DateTimePickerFormat.Custom;
            dtNgayDuKienTra.Location = new Point(106, 82);
            dtNgayDuKienTra.Name = "dtNgayDuKienTra";
            dtNgayDuKienTra.ShowCheckBox = true;
            dtNgayDuKienTra.Size = new Size(143, 27);
            dtNgayDuKienTra.TabIndex = 9;
            // 
            // cboMaKH
            // 
            cboMaKH.FormattingEnabled = true;
            cboMaKH.Location = new Point(385, 53);
            cboMaKH.Name = "cboMaKH";
            cboMaKH.Size = new Size(148, 28);
            cboMaKH.TabIndex = 7;
            // 
            // cboMaNV
            // 
            cboMaNV.FormattingEnabled = true;
            cboMaNV.Location = new Point(371, 9);
            cboMaNV.Name = "cboMaNV";
            cboMaNV.Size = new Size(162, 28);
            cboMaNV.TabIndex = 6;
            // 
            // dtNgayDat
            // 
            dtNgayDat.CustomFormat = "dd/MM/yyyy";
            dtNgayDat.Format = DateTimePickerFormat.Custom;
            dtNgayDat.Location = new Point(106, 43);
            dtNgayDat.Name = "dtNgayDat";
            dtNgayDat.ShowCheckBox = true;
            dtNgayDat.Size = new Size(143, 27);
            dtNgayDat.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 61);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 5;
            label6.Text = "Mã khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 13);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 4;
            label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 45);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày đặt";
            // 
            // label3
            // 
            label3.Location = new Point(3, 69);
            label3.Name = "label3";
            label3.Size = new Size(97, 48);
            label3.TabIndex = 2;
            label3.Text = "Ngày dự kiến trả";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã phiếu đặt";
            label2.Click += label2_Click;
            // 
            // txtMaPhieuDat
            // 
            txtMaPhieuDat.Location = new Point(106, 10);
            txtMaPhieuDat.Name = "txtMaPhieuDat";
            txtMaPhieuDat.Size = new Size(91, 27);
            txtMaPhieuDat.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(541, 20);
            label8.TabIndex = 12;
            label8.Text = "Danh sách phòng đặt";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(3, 137);
            label9.Name = "label9";
            label9.Size = new Size(541, 20);
            label9.TabIndex = 13;
            label9.Text = "Danh sách dịch vụ sử dụng";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(797, 40);
            label10.Name = "label10";
            label10.Size = new Size(180, 20);
            label10.TabIndex = 14;
            label10.Text = "Danh sách dịch vụ hiện có";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel6.Controls.Add(txtTongTienDV);
            panel6.Controls.Add(txtTongTienPhong);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(dgvDSDV);
            panel6.Controls.Add(txtThanhToan);
            panel6.Controls.Add(label11);
            panel6.Location = new Point(766, 63);
            panel6.Name = "panel6";
            panel6.Size = new Size(249, 372);
            panel6.TabIndex = 8;
            // 
            // txtTongTienDV
            // 
            txtTongTienDV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTongTienDV.Location = new Point(121, 305);
            txtTongTienDV.Name = "txtTongTienDV";
            txtTongTienDV.Size = new Size(125, 27);
            txtTongTienDV.TabIndex = 21;
            // 
            // txtTongTienPhong
            // 
            txtTongTienPhong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTongTienPhong.Location = new Point(121, 272);
            txtTongTienPhong.Name = "txtTongTienPhong";
            txtTongTienPhong.Size = new Size(125, 27);
            txtTongTienPhong.TabIndex = 20;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(3, 312);
            label13.Name = "label13";
            label13.Size = new Size(88, 20);
            label13.TabIndex = 19;
            label13.Text = "Tiền dịch vụ";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(3, 274);
            label12.Name = "label12";
            label12.Size = new Size(84, 20);
            label12.TabIndex = 18;
            label12.Text = "Tiền phòng";
            // 
            // dgvDSDV
            // 
            dgvDSDV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvDSDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSDV.Location = new Point(0, 0);
            dgvDSDV.Name = "dgvDSDV";
            dgvDSDV.RowHeadersWidth = 51;
            dgvDSDV.RowTemplate.Height = 29;
            dgvDSDV.Size = new Size(249, 271);
            dgvDSDV.TabIndex = 17;
            dgvDSDV.CellContentDoubleClick += dgvDSDV_CellContentDoubleClick;
            dgvDSDV.MouseClick += dgvDSDV_MouseClick;
            // 
            // txtThanhToan
            // 
            txtThanhToan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtThanhToan.Location = new Point(121, 339);
            txtThanhToan.Name = "txtThanhToan";
            txtThanhToan.Size = new Size(125, 27);
            txtThanhToan.TabIndex = 16;
            txtThanhToan.ChangeUICues += txtThanhToan_ChangeUICues;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(3, 346);
            label11.Name = "label11";
            label11.Size = new Size(118, 20);
            label11.TabIndex = 15;
            label11.Text = "Tổng thanh toán";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label9, 0, 2);
            tableLayoutPanel1.Controls.Add(dgvDSPhongDat, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvDSDVSD, 0, 3);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Location = new Point(198, 167);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(547, 274);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // dgvDSPhongDat
            // 
            dgvDSPhongDat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSPhongDat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSPhongDat.Location = new Point(3, 23);
            dgvDSPhongDat.Name = "dgvDSPhongDat";
            dgvDSPhongDat.RowHeadersWidth = 51;
            dgvDSPhongDat.RowTemplate.Height = 29;
            dgvDSPhongDat.Size = new Size(541, 111);
            dgvDSPhongDat.TabIndex = 14;
            // 
            // dgvDSDVSD
            // 
            dgvDSDVSD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSDVSD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSDVSD.Location = new Point(3, 160);
            dgvDSDVSD.Name = "dgvDSDVSD";
            dgvDSDVSD.RowHeadersWidth = 51;
            dgvDSDVSD.RowTemplate.Height = 29;
            dgvDSDVSD.Size = new Size(541, 111);
            dgvDSDVSD.TabIndex = 15;
            // 
            // frmChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmChiTiet";
            Text = "frmChiTiet";
            Load += frmChiTiet_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSPhongTrong).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSDV).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhongDat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSDVSD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuLuu;
        private ToolStripMenuItem mnuBoQua;
        private DataGridView dgvDSPhongTrong;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtMaPhieuDat;
        private DateTimePicker dtNgayDuKienTra;
        private DateTimePicker dtNgayDat;
        private ComboBox cboMaKH;
        private ComboBox cboMaNV;
        private Label label7;
        private Button btnThemKH;
        private Panel panel6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtThanhToan;
        private DataGridView dgvDSDV;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvDSPhongDat;
        private DataGridView dgvDSDVSD;
        private Label label12;
        private TextBox txtTongTienDV;
        private TextBox txtTongTienPhong;
        private Label label13;
    }
}