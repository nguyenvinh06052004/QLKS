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
    public partial class frmChiTietPhongDV : Form
    {
        private frmPhieuDat cha; // Biến để lưu tham chiếu đến form cha
        public frmChiTietPhongDV( frmPhieuDat cha)
        {
            InitializeComponent();
            this.cha = cha; // Gán form cha vào biến
        }

        private void frmChiTietPhongDV_Load(object sender, EventArgs e)
        {

        }
    }
}
