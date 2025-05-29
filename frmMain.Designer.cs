
using qlksss.Class;
namespace qlksss
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuDanhMuc = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuDichVu = new ToolStripMenuItem();
            mnuLoaiPhong = new ToolStripMenuItem();
            mnuPhong = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            mnuHoaDonTong = new ToolStripMenuItem();
            mnuHoaDonChiTiet = new ToolStripMenuItem();
            mnuPhieu = new ToolStripMenuItem();
            mnuPhieuDatPhong = new ToolStripMenuItem();
            mnuPhieuDichVu = new ToolStripMenuItem();
            mnuChiTiet = new ToolStripMenuItem();
            chiTiếtPhòngToolStripMenuItem = new ToolStripMenuItem();
            chiTiếtDịchVụToolStripMenuItem = new ToolStripMenuItem();
            mnuHuongDan = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuDanhMuc, mnuHoaDon, mnuPhieu, mnuChiTiet, mnuHuongDan, báoCáoToolStripMenuItem });
            menuStrip1.Location = new Point(74, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(552, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuThoat });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(69, 24);
            mnuFile.Text = "Tệp tin";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(130, 26);
            mnuThoat.Text = "Thoát";
            // 
            // mnuDanhMuc
            // 
            mnuDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuNhanVien, mnuKhachHang, mnuDichVu, mnuLoaiPhong, mnuPhong });
            mnuDanhMuc.Name = "mnuDanhMuc";
            mnuDanhMuc.Size = new Size(90, 24);
            mnuDanhMuc.Text = "Danh mục";
            mnuDanhMuc.Click += mnuDanhMuc_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(169, 26);
            mnuNhanVien.Text = "Nhân viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(169, 26);
            mnuKhachHang.Text = "Khách hàng";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuDichVu
            // 
            mnuDichVu.Name = "mnuDichVu";
            mnuDichVu.Size = new Size(169, 26);
            mnuDichVu.Text = "Dịch vụ";
            // 
            // mnuLoaiPhong
            // 
            mnuLoaiPhong.Name = "mnuLoaiPhong";
            mnuLoaiPhong.Size = new Size(169, 26);
            mnuLoaiPhong.Text = "Loại phòng";
            // 
            // mnuPhong
            // 
            mnuPhong.Name = "mnuPhong";
            mnuPhong.Size = new Size(169, 26);
            mnuPhong.Text = "Phòng";
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.DropDownItems.AddRange(new ToolStripItem[] { mnuHoaDonTong, mnuHoaDonChiTiet });
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(81, 24);
            mnuHoaDon.Text = "Hóa đơn";
            // 
            // mnuHoaDonTong
            // 
            mnuHoaDonTong.Name = "mnuHoaDonTong";
            mnuHoaDonTong.Size = new Size(199, 26);
            mnuHoaDonTong.Text = "Hóa đơn tổng";
            // 
            // mnuHoaDonChiTiet
            // 
            mnuHoaDonChiTiet.Name = "mnuHoaDonChiTiet";
            mnuHoaDonChiTiet.Size = new Size(199, 26);
            mnuHoaDonChiTiet.Text = "Hóa đơn chi tiết";
            // 
            // mnuPhieu
            // 
            mnuPhieu.DropDownItems.AddRange(new ToolStripItem[] { mnuPhieuDatPhong, mnuPhieuDichVu });
            mnuPhieu.Name = "mnuPhieu";
            mnuPhieu.Size = new Size(59, 24);
            mnuPhieu.Text = "Phiếu";
            mnuPhieu.Click += mnuPhieu_Click;
            // 
            // mnuPhieuDatPhong
            // 
            mnuPhieuDatPhong.Name = "mnuPhieuDatPhong";
            mnuPhieuDatPhong.Size = new Size(201, 26);
            mnuPhieuDatPhong.Text = "Phiếu đặt phòng";
            // 
            // mnuPhieuDichVu
            // 
            mnuPhieuDichVu.Name = "mnuPhieuDichVu";
            mnuPhieuDichVu.Size = new Size(201, 26);
            mnuPhieuDichVu.Text = "Phiếu dịch vụ";
            // 
            // mnuChiTiet
            // 
            mnuChiTiet.DropDownItems.AddRange(new ToolStripItem[] { chiTiếtPhòngToolStripMenuItem, chiTiếtDịchVụToolStripMenuItem });
            mnuChiTiet.Name = "mnuChiTiet";
            mnuChiTiet.Size = new Size(70, 24);
            mnuChiTiet.Text = "Chi tiết";
            // 
            // chiTiếtPhòngToolStripMenuItem
            // 
            chiTiếtPhòngToolStripMenuItem.Name = "chiTiếtPhòngToolStripMenuItem";
            chiTiếtPhòngToolStripMenuItem.Size = new Size(190, 26);
            chiTiếtPhòngToolStripMenuItem.Text = "Chi tiết phòng";
            // 
            // chiTiếtDịchVụToolStripMenuItem
            // 
            chiTiếtDịchVụToolStripMenuItem.Name = "chiTiếtDịchVụToolStripMenuItem";
            chiTiếtDịchVụToolStripMenuItem.Size = new Size(190, 26);
            chiTiếtDịchVụToolStripMenuItem.Text = "Chi tiết dịch vụ";
            // 
            // mnuHuongDan
            // 
            mnuHuongDan.Name = "mnuHuongDan";
            mnuHuongDan.Size = new Size(98, 24);
            mnuHuongDan.Text = "Hướng dẫn";
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(77, 24);
            báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chương trình quản lý khách sạn";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuDanhMuc;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuDichVu;
        private ToolStripMenuItem mnuLoaiPhong;
        private ToolStripMenuItem mnuPhong;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuHoaDonTong;
        private ToolStripMenuItem mnuHoaDonChiTiet;
        private ToolStripMenuItem mnuPhieu;
        private ToolStripMenuItem mnuPhieuDatPhong;
        private ToolStripMenuItem mnuPhieuDichVu;
        private ToolStripMenuItem mnuChiTiet;
        private ToolStripMenuItem mnuHuongDan;
        private Panel panel1;
        private ToolStripMenuItem chiTiếtPhòngToolStripMenuItem;
        private ToolStripMenuItem chiTiếtDịchVụToolStripMenuItem;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
    }
}
