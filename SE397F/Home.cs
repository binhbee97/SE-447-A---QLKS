using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE397F
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            tsmt_tentaikhoan.Text = thongtindangnhap.HoTenTK;
            
            
        }

        private void tsmt__qllp_Click(object sender, EventArgs e)
        {
            QanLyLoaiPhong qllp = new QanLyLoaiPhong();
     //       qllp.WindowState = FormWindowState.Maximized; // chế độ xem toàn màn hình
     //       qllp.MdiParent = this;
            qllp.Show();
        }

        private void tsmt_qlp_Click(object sender, EventArgs e)
        {
            QuanLyPhong qlp = new QuanLyPhong();
     //       qlp.WindowState = FormWindowState.Maximized; // chế độ xem toàn màn hình
      //      qlp.MdiParent = this;
            qlp.Show();
        }

        private void tsmt_qldv_Click(object sender, EventArgs e)
        {
            QuanLyDichVu qldv = new QuanLyDichVu();
            /*qldv.WindowState = FormWindowState.Maximized; // chế độ xem toàn màn hình
            qldv.MdiParent = this;*/
            qldv.Show();
        }

        private void tsmt_qlkm_Click(object sender, EventArgs e)
        {
            QuanLyKhuyenMai qlkm = new QuanLyKhuyenMai();
            qlkm.Show();
        }

        private void tsmt_qltb_Click(object sender, EventArgs e)
        {
            QuanLyThietBi qltb = new QuanLyThietBi();
            qltb.Show();
        }

        private void tsmt_thongke_Click(object sender, EventArgs e)
        {
            FThongKe tk = new FThongKe();
            tk.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTaiKhoan qltk = new QLTaiKhoan();
            qltk.ShowDialog();
        }
    }
}
