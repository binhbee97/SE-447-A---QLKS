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
    public partial class QLKhachHang : Form
    {
        public QLKhachHang()
        {
            InitializeComponent();
        }
        void docKH()
        {
            dgvDSKhachHang.DataSource = XuLyDuLieu.docDulieu("select * from KhachHang").Tables[0];
        }
        void reset()
        {
            txtTenKhachHang.ResetText();
            txtSDT.ResetText();
            txtCMND.ResetText();
            txtDiaChi.ResetText();
        }
        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            docKH();
            reset();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "delete KhachHang where IDKhachHang = " + txtTenKhachHang.Tag;
            if (XuLyDuLieu.CapNhatDuLieu(query) == 1)
            {
                MessageBox.Show("Xóa thành công!");
                docKH();
                reset();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void dgvDSKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedRow = e.RowIndex;
                //Lưu tạm ID vào để hiệu chỉnh hoặc xóa
                txtTenKhachHang.Tag = dgvDSKhachHang.Rows[selectedRow].Cells["IDKhachHang"].Value.ToString();
                ThongTinKhachHang.IDKhachHang = (string)txtTenKhachHang.Tag;
                txtTenKhachHang.Text = dgvDSKhachHang.Rows[selectedRow].Cells["TenKhachHang"].Value.ToString();
                dtpNgaySinh.Text = dgvDSKhachHang.Rows[selectedRow].Cells["NgaySinh"].Value.ToString();
             //   cbNamNu.Checked = dgvDSKhachHang.Rows[selectedRow].Cells["GioiTinh"].Value.ToString();
                txtSDT.Text = dgvDSKhachHang.Rows[selectedRow].Cells["SDT"].Value.ToString();
                txtCMND.Text = dgvDSKhachHang.Rows[selectedRow].Cells["SoCMND"].Value.ToString();
                txtDiaChi.Text = dgvDSKhachHang.Rows[selectedRow].Cells["DiaChi"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDatPhong1_Click(object sender, EventArgs e)
        {
            ThongTinKhachHang.IDKhachHang = (string)txtTenKhachHang.Tag;
            QLDonDatPhong qlddp = new QLDonDatPhong();
            this.Hide();
            qlddp.ShowDialog();
            this.Close();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            object[] duLieu = new object[]
          {
                txtTenKhachHang.Text
                , dtpNgaySinh.Value
                , cbNamNu.Checked
                , txtSDT.Text
                , txtCMND.Text
                , txtDiaChi.Text
          };
            string[] thamSo = new string[]
            {
                 "@TenKhachHang"
                , "@NgaySinh"
                , "@GioiTinh"
                , "@SDT"
                , "@SoCMND"
                , "@DiaChi"
            };
            if (XuLyDuLieu.capNhatDuLieuStored("ThemKhachHang", duLieu, thamSo) == 1)
            {
                MessageBox.Show("Thêm mới thành công!");
                docKH();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ!");
            }
        }
    }
}
