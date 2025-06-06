namespace qlksss
{
    partial class frmPhieuDat
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
            BtnChiTiet = new Button();
            BtnDanhSach = new Button();
            BtnQuayLai = new Button();
            BtnBoQua = new Button();
            BtnLuu = new Button();
            BtnXoa = new Button();
            BtnSua = new Button();
            BtnThem = new Button();
            label1 = new Label();
            label2 = new Label();
            dtTuNgay = new DateTimePicker();
            dtDenNgay = new DateTimePicker();
            panel2 = new Panel();
            dgvDS = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDS).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnChiTiet);
            panel1.Controls.Add(BtnDanhSach);
            panel1.Controls.Add(BtnQuayLai);
            panel1.Controls.Add(BtnBoQua);
            panel1.Controls.Add(BtnLuu);
            panel1.Controls.Add(BtnXoa);
            panel1.Controls.Add(BtnSua);
            panel1.Controls.Add(BtnThem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // BtnChiTiet
            // 
            BtnChiTiet.Anchor = AnchorStyles.Top;
            BtnChiTiet.Location = new Point(418, 78);
            BtnChiTiet.Name = "BtnChiTiet";
            BtnChiTiet.Size = new Size(94, 29);
            BtnChiTiet.TabIndex = 7;
            BtnChiTiet.Text = "Chi Tiết";
            BtnChiTiet.UseVisualStyleBackColor = true;
            BtnChiTiet.Click += BtnChiTiet_Click;
            // 
            // BtnDanhSach
            // 
            BtnDanhSach.Anchor = AnchorStyles.Top;
            BtnDanhSach.Location = new Point(287, 78);
            BtnDanhSach.Name = "BtnDanhSach";
            BtnDanhSach.Size = new Size(94, 29);
            BtnDanhSach.TabIndex = 6;
            BtnDanhSach.Text = "Danh sách";
            BtnDanhSach.UseVisualStyleBackColor = true;
            // 
            // BtnQuayLai
            // 
            BtnQuayLai.Anchor = AnchorStyles.Top;
            BtnQuayLai.Location = new Point(685, 30);
            BtnQuayLai.Name = "BtnQuayLai";
            BtnQuayLai.Size = new Size(94, 29);
            BtnQuayLai.TabIndex = 5;
            BtnQuayLai.Text = "Quay Lại";
            BtnQuayLai.UseVisualStyleBackColor = true;
            BtnQuayLai.Click += BtnQuayLai_Click;
            // 
            // BtnBoQua
            // 
            BtnBoQua.Anchor = AnchorStyles.Top;
            BtnBoQua.Location = new Point(553, 30);
            BtnBoQua.Name = "BtnBoQua";
            BtnBoQua.Size = new Size(94, 29);
            BtnBoQua.TabIndex = 4;
            BtnBoQua.Text = "Bỏ qua";
            BtnBoQua.UseVisualStyleBackColor = true;
            // 
            // BtnLuu
            // 
            BtnLuu.Anchor = AnchorStyles.Top;
            BtnLuu.Location = new Point(418, 30);
            BtnLuu.Name = "BtnLuu";
            BtnLuu.Size = new Size(94, 29);
            BtnLuu.TabIndex = 3;
            BtnLuu.Text = "Lưu";
            BtnLuu.UseVisualStyleBackColor = true;
            // 
            // BtnXoa
            // 
            BtnXoa.Anchor = AnchorStyles.Top;
            BtnXoa.Location = new Point(287, 30);
            BtnXoa.Name = "BtnXoa";
            BtnXoa.Size = new Size(94, 29);
            BtnXoa.TabIndex = 2;
            BtnXoa.Text = "Xóa";
            BtnXoa.UseVisualStyleBackColor = true;
            // 
            // BtnSua
            // 
            BtnSua.Anchor = AnchorStyles.Top;
            BtnSua.Location = new Point(152, 30);
            BtnSua.Name = "BtnSua";
            BtnSua.Size = new Size(94, 29);
            BtnSua.TabIndex = 1;
            BtnSua.Text = "Sửa";
            BtnSua.UseVisualStyleBackColor = true;
            BtnSua.Click += button2_Click;
            // 
            // BtnThem
            // 
            BtnThem.Anchor = AnchorStyles.Top;
            BtnThem.Location = new Point(24, 30);
            BtnThem.Name = "BtnThem";
            BtnThem.Size = new Size(94, 29);
            BtnThem.TabIndex = 0;
            BtnThem.Text = "Thêm";
            BtnThem.UseVisualStyleBackColor = true;
            BtnThem.Click += BtnThem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "Từ ngày";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(440, 19);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày";
            label2.Click += label2_Click;
            // 
            // dtTuNgay
            // 
            dtTuNgay.Anchor = AnchorStyles.Top;
            dtTuNgay.CustomFormat = "dd/MM/yyyy";
            dtTuNgay.Format = DateTimePickerFormat.Custom;
            dtTuNgay.Location = new Point(92, 14);
            dtTuNgay.Name = "dtTuNgay";
            dtTuNgay.Size = new Size(250, 27);
            dtTuNgay.TabIndex = 4;
            // 
            // dtDenNgay
            // 
            dtDenNgay.Anchor = AnchorStyles.Top;
            dtDenNgay.CustomFormat = "dd/MM/yyyy";
            dtDenNgay.Format = DateTimePickerFormat.Custom;
            dtDenNgay.Location = new Point(529, 14);
            dtDenNgay.Name = "dtDenNgay";
            dtDenNgay.Size = new Size(250, 27);
            dtDenNgay.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtDenNgay);
            panel2.Controls.Add(dtTuNgay);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 60);
            panel2.TabIndex = 6;
            // 
            // dgvDS
            // 
            dgvDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDS.Dock = DockStyle.Fill;
            dgvDS.Location = new Point(0, 185);
            dgvDS.Name = "dgvDS";
            dgvDS.RowHeadersWidth = 51;
            dgvDS.RowTemplate.Height = 29;
            dgvDS.Size = new Size(800, 265);
            dgvDS.TabIndex = 7;
            dgvDS.CellContentClick += dgvDS_CellContentClick;
            // 
            // frmPhieuDat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDS);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmPhieuDat";
            Text = "frmPhieuDat";
            WindowState = FormWindowState.Maximized;
            Activated += frmPhieuDat_Activated;
            Load += frmPhieuDat_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnChiTiet;
        private Button BtnDanhSach;
        private Button BtnQuayLai;
        private Button BtnBoQua;
        private Button BtnLuu;
        private Button BtnXoa;
        private Button BtnSua;
        private Button BtnThem;
        private Label label1;
        private Label label2;
        private DateTimePicker dtTuNgay;
        private DateTimePicker dtDenNgay;
        private Panel panel2;
        private DataGridView dgvDS;
    }
}